using System;
using System.Collections.Generic;
using System.Linq;

namespace Buckaroo
{
  internal static class Messages
  {
    internal const string RequestCreated = "A new request is created";
    internal const string RequestSerialized = "The request is successfuly serialized to JSON";
    internal const string ResponseDeserialized = "The reponse is succesfully deserialized";
    internal const string BadImplementation = "Request type is badly implemented in the buckaroo SDK. Please contact Buckaroo";
    internal const string SecretKeyToShort = "The secret key that is used in your implementation is shorter than recommended. We recommend a secret key of at least 10 characters.";
    internal static string RequestTypeAndAddress(HttpRequestType requestType, string requestAddress) => $"The request type is: {requestType} \nThe request address is: {requestAddress}";
    internal static string SerializedRequestJson(string requestJson) => $"The serialized request in JSON format is: \n{requestJson} \n";
    internal static string SerializedResponseJson(string responseJson) => $"The returned response in JSON format is: \n{responseJson} \n";
    internal static string FailedSerializationResponseJson(string responseJson) => $"The returned response in JSON format could not be serialized: \n{responseJson} \n";
    internal static string RequestSuccessful(bool successful, string jsonResponse) => successful ? $"Response is returned properly \n{SerializedResponseJson(jsonResponse)}\n" : "Response is not returned properly";
    internal static string RequestAuthenticated(string[] values) => $"Requst authenticated with values:{CreateValueListLog(values)}";
    internal static string CreateValueListLog(IEnumerable<String> values) => values.Aggregate("", (current, value) => current + $"\n{value} ");
    internal static string CheckSecretKey(string secretKey) => secretKey.Length < 10 ? SecretKeyToShort : string.Empty;
  }
}