namespace Buckaroo
{
  /// <summary>
  /// A PayPal RefundResponse does not have reponse parameters
  /// </summary>
  public class PayPalRefundResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.PayPal;
  }
}
