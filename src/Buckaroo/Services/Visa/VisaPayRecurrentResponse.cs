﻿namespace Buckaroo
{
  public class VisaPayRecurrentResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Visa;
    public string CardExpirationDate { get; set; }
  }
}
