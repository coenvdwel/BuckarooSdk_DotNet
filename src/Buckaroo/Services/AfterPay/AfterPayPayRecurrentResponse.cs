namespace Buckaroo
{
  public class AfterPayPayRecurrentResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.AfterPay;
    public string CardExpirationDate { get; set; }
  }
}