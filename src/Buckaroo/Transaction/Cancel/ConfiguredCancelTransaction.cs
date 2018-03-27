namespace Buckaroo
{
  public class ConfiguredCancelTransaction
  {
    internal CancelTransaction CancelTransaction { get; set; }

    public ConfiguredCancelTransaction(CancelTransaction cancelTransaction)
    {
      CancelTransaction = cancelTransaction;
    }

    /// <summary>
    /// Execute the request, a post to the Buckaroo Payment Engine is prepared and send.
    /// </summary>
    /// <returns>General TransactionResponse object is returned</returns>
    public RequestResponse Execute()
    {
      return Connector.SendRequest<IRequestBase, RequestResponse>(CancelTransaction.Request.Request, CancelTransaction.CancelTransactionBase, HttpRequestType.Post).Result;
    }
  }
}