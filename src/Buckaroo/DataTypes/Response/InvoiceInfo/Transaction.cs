﻿using System;
using System.Collections.Generic;

namespace Buckaroo
{
  public class Transaction
  {
    public string Id { get; set; }
    public string Type { get; set; }
    public string TypeDescription { get; set; }
    public bool Test { get; set; }
    public string Currency { get; set; }
    public decimal AmountDebit { get; set; }
    public decimal AmountCredit { get; set; }
    public decimal AmountRefundable { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDatetime { get; set; }
    public string Status { get; set; }
    public List<Refund> Refunds { get; set; }
  }
}
