namespace Buckaroo
{
  /// <summary>
  /// A Sofort PayResponse does not have reponse parameters
  /// </summary>
  public class SofortPayResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Sofort;
  }
}