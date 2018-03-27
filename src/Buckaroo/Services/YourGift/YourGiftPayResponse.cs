namespace Buckaroo
{
  /// <summary>
  /// A YourGift PayResponse does not have reponse parameters
  /// </summary>
  public class YourGiftPayResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.YourGift;
  }
}