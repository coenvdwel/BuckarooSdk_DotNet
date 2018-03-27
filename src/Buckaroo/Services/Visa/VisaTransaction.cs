namespace Buckaroo
{
  public class VisaTransaction
  {
    private ConfiguredTransaction ConfiguredTransaction { get; set; }

    internal VisaTransaction(ConfiguredTransaction baseTransaction)
    {
      ConfiguredTransaction = baseTransaction;
    }

    public ConfiguredServiceTransaction Pay(VisaPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Visa", parameters, "pay");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Refund(VisaRefundRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Visa", parameters, "refund");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Authorize(VisaAuthorizeRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Visa", parameters, "authorize");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Capture(VisaCaptureRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Visa", parameters, "capture");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRecurrent(VisaPayRecurrentRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Visa", parameters, "payrecurrent");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRemainder(VisaPayRemainderRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Visa", parameters, "payremainder");

      return configuredServiceTransaction;
    }
  }
}