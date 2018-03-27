using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Buckaroo
{
  internal static class Connector
  {
    public const string CheckoutUrl = "https://checkout.buckaroo.nl";
    public const string TestCheckoutUrl = "https://testcheckout.buckaroo.nl";

    public static async Task<TResponse> SendRequest<TRequest, TResponse>(Request request, TRequest data, HttpRequestType requestType) where TResponse : IRequestResponse
    {
      try
      {
        var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
        var requestJson = String.Empty;

        try
        {
          requestJson = JsonConvert.SerializeObject(data, settings);

          request.BuckarooSdkLogger.AddProcessLogging(Messages.SerializedRequestJson(requestJson));
          request.BuckarooSdkLogger.HandleRawRequest(requestJson);
        }
        catch (JsonSerializationException exception)
        {
          request.BuckarooSdkLogger.AddErrorLogging(exception.ToString());
          return default(TResponse);
        }

        // live or test url
        var apiBaseAddress = request.IsLive ? CheckoutUrl : TestCheckoutUrl;

        // use BuckarooDelegatingHandler for HMAC auth
        var customDelegatingHandler = new BuckarooDelegatingHandler(request.WebsiteKey, request.ApiKey, request.Channel.ToString(), request.Culture.Name);
        var client = new HttpClient(customDelegatingHandler);

        request.BuckarooSdkLogger.AddProcessLogging(Messages.RequestTypeAndAddress(requestType, apiBaseAddress + request.Endpoint));

        HttpResponseMessage response;
        switch (requestType)
        {
          case HttpRequestType.Post:
            response = await client.PostAsync(apiBaseAddress + request.Endpoint, new StringContent(requestJson, Encoding.UTF8, "application/json"));
            break;
          case HttpRequestType.Get:
            response = await client.GetAsync(apiBaseAddress + request.Endpoint);
            break;
          default:
            request.BuckarooSdkLogger.AddErrorLogging(Messages.BadImplementation);
            throw new Exception(Messages.BadImplementation);
        }

        // perform request and get response
        var responseJson = response.Content.ReadAsStringAsync().Result;

        try
        {
          // deserialize to response type
          var deserializedResponse = JsonConvert.DeserializeObject<TResponse>(responseJson);

          if (responseJson != null)
          {
            request.BuckarooSdkLogger.AddProcessLogging(Messages.RequestSuccessful(true, responseJson));
            request.BuckarooSdkLogger.HandleRawResponse(responseJson);
          }

          request.BuckarooSdkLogger.AddProcessLogging(Messages.ResponseDeserialized);

          return deserializedResponse;
        }
        catch (JsonSerializationException exception)
        {
          request.BuckarooSdkLogger.AddErrorLogging(Messages.FailedSerializationResponseJson(responseJson) + exception);
          return default(TResponse);
        }
      }
      catch (Exception ex)
      {
        request.BuckarooSdkLogger.AddErrorLogging(ex.ToString());
        return default(TResponse);
      }
    }
  }
}