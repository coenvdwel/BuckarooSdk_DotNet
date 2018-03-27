namespace Buckaroo
{
  /// <summary>
  /// A Sofort RefundResponse does not have reponse parameters
  /// </summary>
  public class SofortRefundResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Sofort;
  }
}
