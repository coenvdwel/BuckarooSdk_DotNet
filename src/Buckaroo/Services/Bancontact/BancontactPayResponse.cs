namespace Buckaroo
{
  /// <summary>
  /// A Bancontact PayResponse does not have reponse parameters
  /// </summary>
  public class BancontactPayResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Bancontact;
  }
}