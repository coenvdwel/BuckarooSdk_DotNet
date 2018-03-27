using System;

namespace Buckaroo
{
  public class PayPerEmailPaymentInvitationResponse : ActionResponse
  {
    public override ServiceEnum ServiceEnum => ServiceEnum.PayPerEmail;
    public DateTime ExpirationDate { get; set; }
    public string PayLink { get; set; }
  }
}
