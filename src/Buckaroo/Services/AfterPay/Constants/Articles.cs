using System.Collections.Generic;

namespace Buckaroo
{
  public class Articles : ParameterGroupCollection<Article>
  {
    public Articles(IList<Article> articles = null) : base("Article")
    {
      if (articles != null) AddRange(articles);
    }
  }
}