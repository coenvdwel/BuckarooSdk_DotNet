using System;

namespace Buckaroo
{
  public class ConfiguredTransactionRefundInfo
  {
    internal TransactionRefundInfo TransactionRefundInfo { get; set; }

    internal ConfiguredTransactionRefundInfo(TransactionRefundInfo transactionRefundInfo)
    {
      TransactionRefundInfo = transactionRefundInfo;
    }

    public RefundInfoRequestRefundInfo GetSingleRefundInfo()
    {
      return Connector.SendRequest<IRequestBase, RefundInfoRequestRefundInfo>(TransactionRefundInfo.AuthenticatedRequest.Request, TransactionRefundInfo.TransactionRefundInfoBase, HttpRequestType.Get).Result;
    }

    public RefundInfo GetMultipleRefundsInfo()
    {
      if (TransactionRefundInfo.AuthenticatedRequest.Request == null)
      {
        throw new Exception("This function is a POST method and should therefore contain a message body");
      }

      return Connector.SendRequest<IRequestBase, RefundInfo>(TransactionRefundInfo.AuthenticatedRequest.Request, TransactionRefundInfo.TransactionRefundInfoBase, HttpRequestType.Post).Result;
    }
  }
}