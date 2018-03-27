namespace Buckaroo
{
  /// <summary>
  /// A Visa Refund Response does not have response parameters
  /// </summary>
  public class VisaRefundResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Visa;
  }
}