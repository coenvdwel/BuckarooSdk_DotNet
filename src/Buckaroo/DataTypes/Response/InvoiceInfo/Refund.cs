﻿using System;

namespace Buckaroo
{
  public class Refund
  {
    public string Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime RefundDate { get; set; }
    public TransactionStatus Status { get; set; }
  }
}
