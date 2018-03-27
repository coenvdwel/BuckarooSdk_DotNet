namespace Buckaroo
{
  public class Article : ParameterGroup
  {
    public string ArticleDescription { get; set; }
    public string ArticleId { get; set; }
    public decimal ArticleQuantity { get; set; }
    public decimal ArticleUnitprice { get; set; }
    public ArticleVatcategory ArticleVatcategory { get; set; }
  }
}