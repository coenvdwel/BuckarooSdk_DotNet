namespace Buckaroo
{
  public class WebshopGiftcardTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; set; }

    internal WebshopGiftcardTransaction(ConfiguredTransaction configuredTransaction)
    {
      this.ConfiguredTransaction = configuredTransaction;
    }

    /// <summary>
    /// The pay function creates a configured transaction with an WebshopGiftcardPayRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A WebshopGiftcardPayRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Pay(WebshopGiftcardPayRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("webshopgiftcard", parameters, "pay", "1");

      return configuredServiceTransaction;
    }
    /// <summary>
    /// The refund function creates a configured transaction with an WebshopGiftcardRefundRequest request, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A WebshopGiftcardRefundRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction Refund(WebshopGiftcardRefundRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("webshopgiftcard", null, "refund", "1");

      return configuredServiceTransaction;
    }
  }
}