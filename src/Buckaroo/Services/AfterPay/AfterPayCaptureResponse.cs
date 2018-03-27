namespace Buckaroo
{
  public class AfterPayCaptureResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.AfterPay;
    public string CardNumberEnding { get; set; }
    public string CardExpirationDate { get; set; }
  }
}