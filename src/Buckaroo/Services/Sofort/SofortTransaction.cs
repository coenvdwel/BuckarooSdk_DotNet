namespace Buckaroo
{
  public class SofortTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; set; }

    internal SofortTransaction(ConfiguredTransaction configuredTransaction)
    {
      ConfiguredTransaction = configuredTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with an SofortPayRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A SofortPayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(SofortPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("sofortueberweisung", parameters, "pay", "1");

      return configuredServiceTransaction;
    }
    /// <summary>
    /// The refund function creates a configured transaction with an SofortRefundRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A SofortRefundRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Refund(SofortRefundRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("sofortueberweisung", null, "refund", "1");

      return configuredServiceTransaction;
    }
  }
}