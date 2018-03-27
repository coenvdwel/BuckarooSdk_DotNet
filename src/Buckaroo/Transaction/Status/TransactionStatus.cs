namespace Buckaroo
{
  public class TransactionStatus
  {
    internal AuthenticatedRequest Request { get; set; }
    internal TransactionStatusBase TransactionStatusBase { get; set; }

    public TransactionStatus(AuthenticatedRequest request)
    {
      Request = request;
    }

    public ConfiguredTransactionStatus Status(string transactionKey)
    {
      Request.Request.Endpoint += ($"{Settings.GatewaySettings.TransactionRequestEndPoint}{Settings.GatewaySettings.StatusEndPoint}{transactionKey}");

      return new ConfiguredTransactionStatus(this);
    }

    public ConfiguredTransactionStatus Statuses(TransactionStatusBase transactionStatusBase)
    {
      TransactionStatusBase = transactionStatusBase;
      Request.Request.Endpoint += Settings.GatewaySettings.TransactionRequestEndPoint + Settings.GatewaySettings.StatusesEndPoint;

      return new ConfiguredTransactionStatus(this);
    }
  }
}