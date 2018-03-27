namespace Buckaroo
{
  /// <summary>
  /// The CancelTransaction class of payment method type: PayPerMail.
  /// </summary>
  public class PayPerEmailTransaction
  {
    /// <summary>
    /// The configured transaction
    /// </summary>
    private ConfiguredTransaction ConfiguredTransaction { get; set; }

    internal PayPerEmailTransaction(ConfiguredTransaction baseTransaction)
    {
      ConfiguredTransaction = baseTransaction;
    }
    /// <summary>
    /// The pay function creates a configured transaction with a PayPerEmailPaymentInvitationRequest, 
    /// that is ready to be executed.
    /// </summary>
    /// <param name="request">A PayPerEmailPaymentInvitationRequest</param>
    /// <returns></returns>
    public ConfiguredServiceTransaction PaymentInvitation(PayPerEmailPaymentInvitationRequest request)
    {
      var parameters = ServiceHelper.CreateServiceParameters(request);
      var configuredServiceTransaction = new ConfiguredServiceTransaction(ConfiguredTransaction.BaseTransaction);
      configuredServiceTransaction.BaseTransaction.AddService("PayPerEmail", parameters, "paymentinvitation");

      return configuredServiceTransaction;
    }
  }
}