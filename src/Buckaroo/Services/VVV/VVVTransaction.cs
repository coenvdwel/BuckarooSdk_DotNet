namespace Buckaroo
{
  public class VVVTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; set; }

    internal VVVTransaction(ConfiguredTransaction configuredTransaction)
    {
      ConfiguredTransaction = configuredTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with an VVVPayRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A VVVPayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(VVVPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("vvvgiftcard", parameters, "pay", "1");

      return configuredServiceTransaction;
    }
  }
}