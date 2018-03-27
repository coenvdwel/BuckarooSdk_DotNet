using System;

namespace Buckaroo
{
  public class ConfiguredTransactionSpecification
  {
    internal TransactionSpecification TransactionSpecification { get; set; }

    internal ConfiguredTransactionSpecification(TransactionSpecification transactionSpecification)
    {
      TransactionSpecification = transactionSpecification;
    }

    public RequestResponse GetSingleTransactionSpecification()
    {
      if (TransactionSpecification.Request.Request != null)
      {
        throw new Exception("This function is a GET method and should therefore not contain a body.");
      }

      return Connector.SendRequest<IRequestBase, RequestResponse>(TransactionSpecification.Request.Request, TransactionSpecification.TransactionSpecificationBase, HttpRequestType.Get).Result;
    }

    public SpecificationsRequestResponse GetMultipleSpecificiations()
    {
      if (TransactionSpecification.Request.Request == null)
      {
        throw new Exception("This function is a POST method and should therefore contain a message body");
      }

      return Connector.SendRequest<IRequestBase, SpecificationsRequestResponse>(TransactionSpecification.Request.Request, TransactionSpecification.TransactionSpecificationBase, HttpRequestType.Post).Result;
    }
  }
}