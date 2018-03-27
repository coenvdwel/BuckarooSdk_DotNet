﻿namespace Buckaroo
{
  public class IdealProcessingTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; }

    internal IdealProcessingTransaction(ConfiguredTransaction configuredTransaction)
    {
      ConfiguredTransaction = configuredTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with an IdealProcessingPayRequest, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">An IdealProcessingPayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(IdealProcessingPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("Idealprocessing", parameters, "pay", "2");

      return configuredServiceTransaction;
    }
  }
}