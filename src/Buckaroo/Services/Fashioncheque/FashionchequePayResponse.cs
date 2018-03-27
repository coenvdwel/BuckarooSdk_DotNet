namespace Buckaroo
{
  /// <summary>
  /// A Fashioncheque PayResponse does not have reponse parameters
  /// </summary>
  public class FashionchequePayResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Fashioncheque;
  }
}