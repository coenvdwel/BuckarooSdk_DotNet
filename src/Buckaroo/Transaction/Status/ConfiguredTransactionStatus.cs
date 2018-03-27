using System;

namespace Buckaroo
{
  public class ConfiguredTransactionStatus
  {
    internal TransactionStatus TransactionStatus { get; set; }
    internal TransactionReference TransactionReference { get; set; }

    internal ConfiguredTransactionStatus(TransactionStatus transactionStatus)
    {
      TransactionStatus = transactionStatus;
    }

    public StatusesRequestResponse GetMultipleStatuses()
    {
      if (TransactionStatus.Request.Request == null)
      {
        throw new Exception("This function is a POST method and should therefore contain a message body");
      }

      return Connector.SendRequest<IRequestBase, StatusesRequestResponse>(TransactionStatus.Request.Request, TransactionStatus.TransactionStatusBase, HttpRequestType.Post).Result;
    }

    public TransactionStatusResponse GetSingleStatus()
    {
      return Connector.SendRequest<IRequestBase, TransactionStatusResponse>(TransactionStatus.Request.Request, TransactionStatus.TransactionStatusBase, HttpRequestType.Get).Result;
    }
  }
}