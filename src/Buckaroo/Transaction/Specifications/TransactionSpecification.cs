namespace Buckaroo
{
  public class TransactionSpecification
  {
    internal AuthenticatedRequest Request { get; set; }
    internal TransactionSpecificationBase TransactionSpecificationBase { get; set; }

    public TransactionSpecification(AuthenticatedRequest request)
    {
      Request = request;
    }

    public ConfiguredTransactionSpecification SpecificServiceSpecification(string serviceName, int serviceVersion = 1)
    {
      Request.Request.Endpoint += ($"{Settings.GatewaySettings.TransactionRequestEndPoint}{Settings.GatewaySettings.SpecificationEndpoint}{serviceName}?serviceVersion={serviceVersion}");

      return new ConfiguredTransactionSpecification(this);
    }

    public ConfiguredTransactionSpecification MultipleServiceSpecifications(TransactionSpecificationBase transactionSpecificationBase)
    {
      TransactionSpecificationBase = transactionSpecificationBase;
      Request.Request.Endpoint += Settings.GatewaySettings.TransactionRequestEndPoint + Settings.GatewaySettings.SpecificationsEndpoint;

      return new ConfiguredTransactionSpecification(this);
    }
  }
}