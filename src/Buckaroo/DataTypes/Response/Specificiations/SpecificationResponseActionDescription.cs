using System.Collections.Generic;

namespace Buckaroo
{
  public class SpecificationResponseActionDescription
  {
    public string Name { get; set; }
    public int Type { get; set; }
    public bool Default { get; set; }
    public string Description { get; set; }
    public List<SpecificationParameterDescription> RequestParameters { get; set; }
    public List<SpecificationParameterDescription> ResponseParameters { get; set; }
    public List<OriginalTransactionReferenceDescription> OriginalTransactionReferenceDescriptions { get; set; }
  }
}