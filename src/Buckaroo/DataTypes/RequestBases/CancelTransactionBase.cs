using System.Collections.Generic;

namespace Buckaroo
{
  public class CancelTransactionBase : IRequestBase
  {
    public List<RequestCancelTransaction> Transactions { get; set; }

    public CancelTransactionBase(IEnumerable<string> transactions)
    {
      Transactions = new List<RequestCancelTransaction>();

      foreach (var transaction in transactions)
      {
        Transactions.Add(new RequestCancelTransaction(transaction));
      }
    }

    public CancelTransactionBase(string transactionToBeCanceled)
    {
      Transactions = new List<RequestCancelTransaction>
      {
        new RequestCancelTransaction(transactionToBeCanceled)
      };
    }
  }

  public class RequestCancelTransaction
  {
    public string Key { get; set; }

    public RequestCancelTransaction(string key)
    {
      Key = key;
    }

    public RequestCancelTransaction()
    {
    }
  }
}