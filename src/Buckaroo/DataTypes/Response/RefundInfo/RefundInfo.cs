using System.Collections.Generic;

namespace Buckaroo
{
  public class RefundInfo : IRequestResponse
  {
    public List<RefundInfoResponseRefundInfo> RefundInfoCollection { get; set; }
    public List<InvalidRefundInfo> InvalidRefundInfoCollection { get; set; }
  }
}
