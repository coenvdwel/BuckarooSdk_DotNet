using System;

namespace Buckaroo
{
  public class ConfiguredTransactionInvoiceInfo
  {
    internal TransactionInvoiceInfo TransactionInvoiceInfo { get; set; }

    internal ConfiguredTransactionInvoiceInfo(TransactionInvoiceInfo transactionInvoiceInfo)
    {
      TransactionInvoiceInfo = transactionInvoiceInfo;
    }

    public InvoiceInfoRequestInvoice GetSingleInvoiceInfoRequest()
    {
      return Connector.SendRequest<IRequestBase, InvoiceInfoRequestInvoice>(TransactionInvoiceInfo.Request.Request, TransactionInvoiceInfo.TransactionInvoiceInfoBase, HttpRequestType.Get).Result;
    }

    public InvoiceInfoResponse GetMultipleInvoiceInfoRequest()
    {
      if (TransactionInvoiceInfo.Request.Request == null)
      {
        throw new Exception("This function is a POST method and should therefore contain a message body");
      }

      return Connector.SendRequest<IRequestBase, InvoiceInfoResponse>(TransactionInvoiceInfo.Request.Request, TransactionInvoiceInfo.TransactionInvoiceInfoBase, HttpRequestType.Post).Result;
    }
  }
}