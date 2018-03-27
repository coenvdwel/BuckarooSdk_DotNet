namespace Buckaroo
{
  public class FashionchequeTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; set; }

    internal FashionchequeTransaction(ConfiguredTransaction configuredTransaction)
    {
      ConfiguredTransaction = configuredTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with an FashionchequePayRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A FashionchequePayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(FashionchequePayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("fashioncheque", parameters, "pay", "2");

      return configuredServiceTransaction;
    }
  }
}