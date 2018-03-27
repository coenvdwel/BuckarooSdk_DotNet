using System.Collections.Generic;

namespace Buckaroo
{
  public class TransactionSpecificationBase : IRequestBase
  {
    public List<SpecificationRequestedService> Services { get; set; }

    public TransactionSpecificationBase()
    {
      this.Services = new List<SpecificationRequestedService>();
    }

    public TransactionSpecificationBase AddService(string service, int? version = null)
    {
      var serviceToBeAdded = new SpecificationRequestedService()
      {
        Name = service,
        Version = version,
      };

      this.Services.Add(serviceToBeAdded);

      return this;
    }

    public TransactionSpecificationBase AddService(SpecificationRequestedService addedService)
    {
      this.Services.Add(addedService);

      return this;
    }
  }
}