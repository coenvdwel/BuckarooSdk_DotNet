using System.Collections.Generic;

namespace Buckaroo
{
  public class SpecificationsRequestResponse : IRequestResponse
  {
    public List<SpecificationResponseFieldDescription> BasicFields { get; set; }
    public List<SpecificationResponseServiceDescription> Services { get; set; }
    public List<CustomParameterSpecification> CustomParameters { get; set; }
  }
}
