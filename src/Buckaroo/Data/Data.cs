using System.Collections.Generic;

namespace Buckaroo
{
  /// <summary>
  /// General data class, to hold a Request object and a list of services
  /// </summary>
  public class Data
  {
    internal AuthenticatedRequest Request { get; set; }

    internal List<Service> Services { get; set; }
    internal DataBase DataRequestBase { get; private set; }

    internal Data(AuthenticatedRequest request)
    {
      request.Request.Endpoint = Settings.GatewaySettings.DataRequestEndPoint;
      Request = request;
    }

    public ConfiguredDataRequest SetBasicFields(DataBase basicFields)
    {
      DataRequestBase = basicFields;
      return new ConfiguredDataRequest(this);
    }

    /// <summary>
    /// Adding a service to the datarequest.
    /// </summary>
    /// <param name="serviceName">The name of the service</param>
    /// <param name="parameters">The list of service parameters</param>
    internal void AddService(string serviceName, List<RequestParameter> parameters, string action, string version = "1")
    {
      var service = new Service
      {
        Name = serviceName,
        Action = action,
        Version = version,
        Parameters = parameters,
      };

      if (DataRequestBase.Services.ServiceList == null)
      {
        DataRequestBase.Services.ServiceList = new List<Service>();
      }

      DataRequestBase.Services.ServiceList.Add(service);
    }

    internal void AddGlobal(string serviceName, List<RequestParameter> parameters, string action, string version = "1")
    {
      var global = new Global
      {
        Name = serviceName,
        Action = action,
        Version = version,
        Parameters = parameters,
      };

      if (DataRequestBase.Services.ServiceList == null)
      {
        DataRequestBase.Services.ServiceList = new List<Service>();
      }

      DataRequestBase.Services.ServiceList.Add(global);
    }
  }
}