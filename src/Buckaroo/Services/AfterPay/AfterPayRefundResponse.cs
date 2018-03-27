namespace Buckaroo
{
  /// <summary>
  /// A AfterPay Refund Response does not have response parameters
  /// </summary>
  public class AfterPayRefundResponsen : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.AfterPay;
  }
}