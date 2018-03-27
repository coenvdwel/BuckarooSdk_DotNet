namespace Buckaroo
{
  public class VPayTransaction
  {
    private ConfiguredTransaction ConfiguredTransaction { get; }

    internal VPayTransaction(ConfiguredTransaction baseTransaction)
    {
      ConfiguredTransaction = baseTransaction;
    }

    public ConfiguredServiceTransaction Pay(VPayPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("VPay", parameters, "pay");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Refund(VPayRefundRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("VPay", parameters, "refund");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Authorize(VPayAuthorizeRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("VPay", parameters, "authorize");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRecurrent(VPayPayRecurrentRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("VPay", parameters, "payrecurrent");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRemainder(VPayPayRemainderRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("VPay", parameters, "payremainder");

      return configuredServiceTransaction;
    }
  }
}