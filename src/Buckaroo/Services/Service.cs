using System.Collections.Generic;

namespace Buckaroo
{
  internal class Service
  {
    public string Name { get; set; }
    public string Action { get; set; }
    public string Version { get; set; }
    public List<RequestParameter> Parameters { get; set; }
  }
}