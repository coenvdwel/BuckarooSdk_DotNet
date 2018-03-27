using System.Collections.Generic;

namespace Buckaroo
{
  public class InvoiceInfoResponse : IRequestResponse
  {
    public List<InvoiceInfoResponseInvoice> InvoiceCollection { get; set; }
    public List<InvalidInvoice> InvalidInvoiceCollection { get; set; }
  }
}
