namespace Buckaroo
{
  public class BancontactTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; set; }

    internal BancontactTransaction(ConfiguredTransaction configuredTransaction)
    {
      ConfiguredTransaction = configuredTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with an BancontactPayRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A BancontactPayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(BancontactPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("bancontactmrcash", parameters, "pay", "1");

      return configuredServiceTransaction;
    }

    /// <summary>
    /// The refund function creates a configured transaction with an BancontactRefundRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A BancontactRefundRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Refund(BancontactRefundRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("bancontactmrcash", null, "refund", "1");

      return configuredServiceTransaction;
    }
  }
}