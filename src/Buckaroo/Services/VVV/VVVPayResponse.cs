namespace Buckaroo
{
  /// <summary>
  /// A VVV PayResponse does not have reponse parameters
  /// </summary>
  public class VVVPayResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.VVV;
  }
}