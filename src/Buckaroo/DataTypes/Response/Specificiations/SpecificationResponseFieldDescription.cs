using System.Collections.Generic;

namespace Buckaroo
{
  public class SpecificationResponseFieldDescription
  {
    public List<SpecificationResponseAttributeDescription> Attributes { get; set; }
    public List<ListItemDescription> ListItemDescriptions { get; set; }
    public string Name { get; set; }
    public int DataType { get; set; }
    public bool Required { get; set; }
    public string Description { get; set; }

  }
}
