﻿namespace Buckaroo
{
  public class AfterPayAuthorizeResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.AfterPay;
    public string CardExpirationDate { get; set; }
    public string CardEnrolled { get; set; }
    public string CardAuthentication { get; set; }
    public string CardNumberEnding { get; set; }
  }
}