namespace Buckaroo
{
  public class TransactionRefundInfo
  {
    internal AuthenticatedRequest AuthenticatedRequest { get; set; }
    internal TransactionRefundInfoBase TransactionRefundInfoBase { get; set; }

    public TransactionRefundInfo(AuthenticatedRequest request)
    {
      this.AuthenticatedRequest = request;
    }

    public ConfiguredTransactionRefundInfo SpecificConfiguredTransactionRefundInfo(string transactionKey)
    {
      AuthenticatedRequest.Request.Endpoint += ($"{Settings.GatewaySettings.TransactionRequestEndPoint}{Settings.GatewaySettings.RefundInfoEndPoint}{transactionKey}");

      return new ConfiguredTransactionRefundInfo(this);
    }

    public ConfiguredTransactionRefundInfo MultipleConfiguredTransactionRefundInfo(
        TransactionRefundInfoBase transactionRefundInfoBase)
    {
      AuthenticatedRequest.Request.Endpoint += ($"{Settings.GatewaySettings.TransactionRequestEndPoint}{Settings.GatewaySettings.RefundInfosEndPoint}");

      return new ConfiguredTransactionRefundInfo(this);
    }
  }
}