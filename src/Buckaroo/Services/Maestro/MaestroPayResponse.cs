namespace Buckaroo
{
  public class MaestroPayResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Maestro;
    public string CardExpirationDate { get; set; }
  }
}
