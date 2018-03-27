namespace Buckaroo
{
  /// <summary>
  /// The transaction that is configured for execution
  /// </summary>
  public class ConfiguredServiceTransaction
  {
    internal TransactionRequest BaseTransaction { get; }

    internal ConfiguredServiceTransaction(TransactionRequest transactionRequest)
    {
      BaseTransaction = transactionRequest;
    }

    /// <summary>
    /// Execute the request, a post to the Buckaroo Payment Engine is prepared and sent.
    /// </summary>
    /// <returns>General TransactionResponse object is returned</returns>
    public RequestResponse Execute()
    {
      var response = Connector.SendRequest<IRequestBase, RequestResponse>(BaseTransaction.AuthenticatedRequest.Request, BaseTransaction.TransactionBase, HttpRequestType.Post).Result;

      // relocate logger from request to response
      response.BuckarooSdkLogger = BaseTransaction.AuthenticatedRequest.Request.BuckarooSdkLogger;

      return response;
    }

    public ConfiguredAdditionalTransaction AddAdditionalService()
    {
      return new ConfiguredAdditionalTransaction(BaseTransaction);
    }

    public ILogger GetLogger()
    {
      return BaseTransaction.AuthenticatedRequest.Request.BuckarooSdkLogger;
    }
  }
}