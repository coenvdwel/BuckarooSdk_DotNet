﻿namespace Buckaroo
{
  public class MasterCardCaptureResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.MasterCard;
    public string CardNumberEnding { get; set; }
    public string CardExpirationDate { get; set; }
  }
}
