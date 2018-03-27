namespace Buckaroo
{
  public class ConfiguredDataRequest
  {
    internal Data BaseDataRequest { get; private set; }

    /// <summary>
    /// ConfiguredDataRequest primary constructor.
    /// </summary>
    /// <param name="data"></param>
    public ConfiguredDataRequest(Data data)
    {
      BaseDataRequest = data;
    }

    public IdealDataRequest Ideal() => new IdealDataRequest(this);
    public IdealQrDataRequest IdealQr() => new IdealQrDataRequest(this);
    public CreditManagementDataRequest CreditManagement() => new CreditManagementDataRequest(this);
  }
}