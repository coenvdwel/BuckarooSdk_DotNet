namespace Buckaroo
{
  public class YourGiftTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; set; }

    internal YourGiftTransaction(ConfiguredTransaction configuredTransaction)
    {
      ConfiguredTransaction = configuredTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with an YourGiftPayRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A YourGiftPayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(YourGiftPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("yourgift", parameters, "pay", "1");

      return configuredServiceTransaction;
    }
  }
}