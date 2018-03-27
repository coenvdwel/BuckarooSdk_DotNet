namespace Buckaroo
{
  public class Address : ParameterGroup
  {
    /// <summary>
    /// 
    /// </summary>
    public string Street { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string HouseNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string HouseNumberSuffix { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string ZipCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string State { get; set; }
    /// <summary>
    /// Country the consumer is located in.
    /// </summary>
    public string Country { get; set; }
  }
}