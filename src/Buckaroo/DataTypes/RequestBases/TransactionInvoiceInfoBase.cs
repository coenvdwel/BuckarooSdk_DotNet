using System.Collections.Generic;

namespace Buckaroo
{
  public class TransactionInvoiceInfoBase : IRequestBase
  {
    public List<InvoiceInfoRequestInvoice> InvoiceCollection { get; set; }
  }
}
