using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buckaroo
{
  internal class BuckarooDelegatingHandler : DelegatingHandler
  {
    private readonly string _websiteKey;
    private readonly string _apiKey;
    private readonly string _channel;
    private readonly string _culture;
    private readonly string _software;

    internal BuckarooDelegatingHandler(string websiteKey, string apiKey, string channel, string culture)
    {
      _websiteKey = websiteKey;
      _apiKey = apiKey;
      _channel = channel;
      _culture = culture;
      _software = JsonConvert.SerializeObject(new Settings.Software());

      InnerHandler = new HttpClientHandler();
    }

    protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
      HttpResponseMessage response = null;

      var requestUri = WebUtility.UrlEncode(request.RequestUri.Authority + request.RequestUri.PathAndQuery).ToLower();
      var requestHttpMethod = request.Method.Method;

      // calculate UNIX time
      var epochStart = new DateTime(1970, 01, 01, 0, 0, 0, 0, DateTimeKind.Utc);
      var timeSpan = DateTime.UtcNow - epochStart;
      var requestTimeStamp = Convert.ToUInt64(timeSpan.TotalSeconds).ToString();

      // create random nonce for each request
      var nonce = Guid.NewGuid().ToString("N");

      // checking if the request contains body, usually will be null with HTTP GET and DELETE
      var content = request.Content;
      var authorizationHeaderString = await CalculateSignature(content, requestHttpMethod, requestTimeStamp, nonce, requestUri);

      request.Headers.Authorization = new AuthenticationHeaderValue("hmac", authorizationHeaderString);

      request.Headers.Add("culture", _culture);
      request.Headers.Add("channel", _channel);
      request.Headers.Add("software", _software);

      response = await base.SendAsync(request, cancellationToken);

      response.Headers.TryGetValues("Authorization", out IEnumerable<string> authorizationResponse);

      if (!await ValidateResponse(response, request.Method.ToString(), requestUri))
      {
        throw new AuthenticationException();
      }

      return response;
    }

    private async Task<string> CalculateSignature(HttpContent content, string requestHttpMethod, string requestTimeStamp, string nonce, string requestUri)
    {
      var requestContentBase64String = string.Empty;

      if (content != null)
      {
        var contentBytes = await content.ReadAsByteArrayAsync();
        var md5 = MD5.Create();

        // hashing the request body, any change in request body will result in different hash, we'll incure message integrity
        var requestContentHash = md5.ComputeHash(contentBytes);
        requestContentBase64String = Convert.ToBase64String(requestContentHash);

        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
      }

      // creating the raw signature string
      string signatureRawData = string.Format("{0}{1}{2}{3}{4}{5}", _websiteKey, requestHttpMethod, requestUri, requestTimeStamp, nonce, requestContentBase64String);

      var secretKeyByteArray = Encoding.UTF8.GetBytes(_apiKey);

      var signature = Encoding.UTF8.GetBytes(signatureRawData);

      using (var hmac = new HMACSHA256(secretKeyByteArray))
      {
        var signatureBytes = hmac.ComputeHash(signature);
        var requestSignatureBase64String = Convert.ToBase64String(signatureBytes);

        // setting the values in the Authorization header using custom scheme (hmac)
        return $"{_websiteKey}:{requestSignatureBase64String}:{nonce}:{requestTimeStamp}";
      }
    }

    protected async Task<bool> ValidateResponse(HttpResponseMessage response, string requestMethod, string requestUri)
    {
      var headers = response.Headers.ToDictionary(x => x.Key, x => x.Value);
      if (!headers.ContainsKey("Authorization")) return false;

      var actualHeader = headers["Authorization"].First();
      var actualAuthHeaderValues = actualHeader.Split(':', ' ');
      var nonce = actualAuthHeaderValues[3];
      var unixTimeStamp = actualAuthHeaderValues[4];

      var calculatedSignature = await this.CalculateSignature(response.Content, requestMethod, unixTimeStamp, nonce, requestUri);
      var calculatedHeader = $"hmac {calculatedSignature}";

      return string.Equals(calculatedHeader, actualHeader);
    }
  }
}