namespace Buckaroo
{
  public class VPayPayRemainderResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.VPay;
    public string CardExpirationDate { get; set; }
  }
}