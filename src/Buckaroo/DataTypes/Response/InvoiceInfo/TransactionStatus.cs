using System;

namespace Buckaroo
{
  public class InvoiceTransactionStatus
  {
    public bool Succes { get; set; }
    public string Code { get; set; }
    public string Message { get; set; }
    public DateTime DateTime { get; set; }
  }
}