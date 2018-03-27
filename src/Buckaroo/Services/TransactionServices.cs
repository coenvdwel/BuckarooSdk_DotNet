using Newtonsoft.Json;
using System.Collections.Generic;

namespace Buckaroo
{
  // INTERNAL NOTE: This class purely exists because of the legacy json message that has to be created. within
  // this message, the list of custom parameters is a value belonging to the tag: services

  /// <summary>
  /// A class that holds a list of services. 
  /// </summary>
  internal class TransactionServices
  {
    /// <summary>
    /// A list of Services.
    /// </summary>
    [JsonProperty()]
    internal List<Service> ServiceList { get; set; }

    /// <summary>
    /// primary constructor. A new list of services is instantiated.
    /// </summary>
    internal TransactionServices()
    {
      ServiceList = new List<Service>();
    }
  }
}