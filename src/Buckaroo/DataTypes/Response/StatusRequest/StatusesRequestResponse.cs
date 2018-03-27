using System.Collections.Generic;

namespace Buckaroo
{
  public class StatusesRequestResponse : IRequestResponse
  {
    public List<TransactionStatus> Transactions { get; set; }
    public List<InvalidTransaction> ErrorTransactions { get; set; }
  }
}
