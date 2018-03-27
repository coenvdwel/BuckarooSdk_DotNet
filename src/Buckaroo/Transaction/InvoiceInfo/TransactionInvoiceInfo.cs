namespace Buckaroo
{
  public class TransactionInvoiceInfo
  {
    internal AuthenticatedRequest Request { get; set; }
    internal TransactionInvoiceInfoBase TransactionInvoiceInfoBase { get; set; }

    public TransactionInvoiceInfo(AuthenticatedRequest request)
    {
      Request = request;
    }

    public ConfiguredTransactionInvoiceInfo SpecificInvoiceInfo(string transactionKey)
    {
      Request.Request.Endpoint += $"{Settings.GatewaySettings.TransactionRequestEndPoint}{Settings.GatewaySettings.InvoiceInfoEndPoint}{transactionKey}";

      return new ConfiguredTransactionInvoiceInfo(this);
    }

    public ConfiguredTransactionInvoiceInfo MultipleInvoicesInfo(TransactionInvoiceInfoBase transactionInvoiceInfoBase)
    {
      Request.Request.Endpoint += $"{Settings.GatewaySettings.TransactionRequestEndPoint}{Settings.GatewaySettings.InvoiceInfosEndPoint}";

      return new ConfiguredTransactionInvoiceInfo(this);
    }
  }
}