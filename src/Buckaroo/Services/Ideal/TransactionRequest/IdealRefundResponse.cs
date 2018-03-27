namespace Buckaroo
{
  public class IdealRefundResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.Ideal;

    /// <summary>
    /// The account name of the customer.
    /// </summary>
    public string CustomerAccountName { get; set; }
    /// <summary>
    /// The BIC (bank) code of the customer's account, where the refund is meant for.
    /// </summary>
    public string CustomerBic { get; set; }
    /// <summary>
    /// The IBAN of the customer's account, where the refund is meant for.
    /// </summary>
    public string CustomerIban { get; set; }
  }
}