namespace Buckaroo
{
  public class AfterPayTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; }

    internal AfterPayTransaction(ConfiguredTransaction baseTransaction)
    {
      ConfiguredTransaction = baseTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with a AfterPayPayRequest, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A AfterPayPayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(AfterPayPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("afterpaydigiaccept", parameters, "pay");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Refund(AfterPayRefundRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("afterpaydigiaccept", parameters, "refund");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Authorize(AfterPayAuthorizeRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("afterpaydigiaccept", parameters, "authorize");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Capture(AfterPayCaptureRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("afterpaydigiaccept", parameters, "capture");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRecurrent(AfterPayPayRecurrentRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("afterpaydigiaccept", parameters, "payrecurrent");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRemainder(AfterPayPayRemainderRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("afterpaydigiaccept", parameters, "payremainder");

      return configuredServiceTransaction;
    }
  }
}