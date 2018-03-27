namespace Buckaroo
{
  public class IdealDataRequest
  {
    private ConfiguredDataRequest ConfiguredDataRequest { get; set; }

    internal IdealDataRequest(ConfiguredDataRequest configuredDateRequest)
    {
      ConfiguredDataRequest = configuredDateRequest;
    }
  }
}