namespace Buckaroo
{
  public class ConfiguredServiceDataRequest
  {
    internal Data BaseData { get; set; }

    internal ConfiguredServiceDataRequest(Data data)
    {
      BaseData = data;
    }

    /// <summary>
    /// Execute the request, a post to the Buckaroo Payment Engine is prepared and send.
    /// </summary>
    /// <returns>General DataResponse object is returned</returns>
    public RequestResponse Execute()
    {
      var response = Connector.SendRequest<IRequestBase, RequestResponse>(BaseData.Request.Request, BaseData.DataRequestBase, HttpRequestType.Post).Result;

      // relocate logger from request to response
      response.BuckarooSdkLogger = BaseData.Request.Request.BuckarooSdkLogger;
      return response;
    }
  }
}