using System.Collections.Generic;

namespace Buckaroo
{
  /// <summary>
  /// Service class used for data handling the service part of the resonse.
  /// </summary>
  public class ServiceResponse
  {
    /// <summary>
    /// The version of the service
    /// </summary>
    public uint VersionAsProperty { get; set; }
    /// <summary>
    /// The name of the service that the response belongs to.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The name of the action that the response belongs to.
    /// </summary>
    public string Action { get; set; }

    /// <summary>
    /// The list of response parameters.
    /// </summary>
    public List<ResponseParameter> Parameters { get; set; }
  }
}