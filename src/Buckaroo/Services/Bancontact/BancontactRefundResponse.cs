namespace Buckaroo
{
  /// <summary>
  /// A Bancontact RefundResponse does not have reponse parameters
  /// </summary>
  public class BancontactRefundResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Bancontact;
  }
}
