namespace Buckaroo
{
  public class ConfiguredAdditionalTransaction
  {
    internal TransactionRequest BaseTransaction { get; private set; }

    public ConfiguredAdditionalTransaction(TransactionRequest transactionRequest)
    {
      BaseTransaction = transactionRequest;
    }

    public CreditManagementTransaction CreditManagement() => new CreditManagementTransaction(this);
  }
}