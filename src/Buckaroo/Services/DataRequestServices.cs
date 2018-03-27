using Newtonsoft.Json;
using System.Collections.Generic;

namespace Buckaroo
{
  internal class DataRequestServices
  {
    /// <summary>
    /// A list of Services.
    /// </summary>
    [JsonProperty()]
    internal List<Service> ServiceList { get; set; }

    [JsonProperty()]
    internal List<Global> Global { get; set; }

    /// <summary>
    /// primary constructor. A new list of services is instantiated.
    /// </summary>
    internal DataRequestServices()
    {
      ServiceList = new List<Service>();
      Global = new List<Global>();
    }
  }
}