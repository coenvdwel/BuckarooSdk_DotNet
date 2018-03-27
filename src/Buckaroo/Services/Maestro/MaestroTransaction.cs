namespace Buckaroo
{
  public class MaestroTransaction
  {
    private ConfiguredTransaction ConfiguredTransaction { get; }

    internal MaestroTransaction(ConfiguredTransaction baseTransaction)
    {
      ConfiguredTransaction = baseTransaction;
    }

    public ConfiguredServiceTransaction Pay(MaestroPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Maestro", parameters, "pay");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Refund(MaestroRefundRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Maestro", parameters, "refund");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Authorize(MaestroAuthorizeRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Maestro", parameters, "authorize");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRecurrent(MaestroPayRecurrentRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Maestro", parameters, "payrecurrent");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRemainder(MaestroPayRemainderRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Maestro", parameters, "payremainder");

      return configuredServiceTransaction;
    }
  }
}