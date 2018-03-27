﻿namespace Buckaroo
{
  public class MasterCardTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; }

    internal MasterCardTransaction(ConfiguredTransaction baseTransaction)
    {
      ConfiguredTransaction = baseTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with a MasterCardPayRequest, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A MasterCardPayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(MasterCardPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "pay");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Refund(MasterCardRefundRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "refund");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Authorize(MasterCardAuthorizeRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "authorize");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction Capture(MasterCardCaptureRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "capture");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRecurrent(MasterCardPayRecurrentRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "payrecurrent");

      return configuredServiceTransaction;
    }

    public ConfiguredServiceTransaction PayRemainder(MasterCardPayRemainderRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "payremainder");

      return configuredServiceTransaction;
    }
  }
}