using Buckaroo;

namespace Buckaroo
{
  public class CancelTransaction
  {
    internal AuthenticatedRequest Request { get; set; }

    internal CancelTransactionBase CancelTransactionBase { get; set; }

    public CancelTransaction(AuthenticatedRequest authenticatedRequest)
    {
      this.Request = authenticatedRequest;
    }

    public ConfiguredCancelTransaction CancelMultiple(CancelTransactionBase cancelTransaction)
    {
      CancelTransactionBase = cancelTransaction;
      Request.Request.Endpoint += $"{Settings.GatewaySettings.TransactionRequestEndPoint}{Settings.GatewaySettings.CancelMultipleEndPoint}";
      return new ConfiguredCancelTransaction(this);
    }
  }
}