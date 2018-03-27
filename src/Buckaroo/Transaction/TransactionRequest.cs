using System.Collections.Generic;

namespace Buckaroo
{
  /// <summary>
  /// The actual transaction, that can only be obtained by defining a transaction request.
  /// </summary>
  public class TransactionRequest
  {
    internal AuthenticatedRequest AuthenticatedRequest { get; set; }

    /// <summary>
    /// The base transaction info
    /// </summary>
    internal TransactionBase TransactionBase { get; private set; }

    /// <summary>
    /// Setter for the basic fields of the transaction.
    /// </summary>
    /// <param name="basicFields"></param>
    /// <returns> A configured transaction </returns>
    public ConfiguredTransaction SetBasicFields(TransactionBase basicFields)
    {
      TransactionBase = basicFields;
      return new ConfiguredTransaction(this);
    }

    /// <summary>
    /// Primary constructor
    /// </summary>
    /// <param name="request"></param>
    internal TransactionRequest(AuthenticatedRequest authenticatedRequest)
    {
      authenticatedRequest.Request.Endpoint = Settings.GatewaySettings.TransactionRequestEndPoint;
      AuthenticatedRequest = authenticatedRequest;
    }

    internal void AddService(string serviceName, List<RequestParameter> parameters, string action, string version = "1")
    {
      var service = new Service
      {
        Name = serviceName,
        Action = action,
        Version = version,
        Parameters = parameters
      };

      TransactionBase.Services.ServiceList.Add(service);
    }

    internal void AddAdditionalService(string serviceName, List<RequestParameter> parameters, string action, string version = "1")
    {
      var service = new Service
      {
        Name = serviceName,
        Action = action,
        Version = version,
        Parameters = parameters
      };

      TransactionBase.Services.ServiceList.Add(service);
    }
  }
}