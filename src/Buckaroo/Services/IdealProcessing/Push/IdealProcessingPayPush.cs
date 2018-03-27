namespace Buckaroo
{
  public class IdealProcessingPayPush : ActionPush
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.IdealProcessing;

    public string ConsumerIban { get; set; }
    public string ConsumerBic { get; set; }
    public string ConsumerName { get; set; }
    public string ConsumerCity { get; set; }
    public string ConsumerAccountNumber { get; set; }
    public string ConsumerIssuer { get; set; }

    public override void FillFromPush(ServiceResponse serviceResponse)
    {
      base.FillFromPush(serviceResponse);
    }
  }
}