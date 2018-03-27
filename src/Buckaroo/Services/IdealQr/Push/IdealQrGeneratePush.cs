namespace Buckaroo
{
  public class IdealQrGeneratePush : ActionPush
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.IdealQr;
    public string QrImageUrl { get; set; }

    public override void FillFromPush(ServiceResponse serviceResponse)
    {
      base.FillFromPush(serviceResponse);
    }
  }
}