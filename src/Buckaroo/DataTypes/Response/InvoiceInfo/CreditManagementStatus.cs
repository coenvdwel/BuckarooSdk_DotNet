using System.Collections.Generic;

namespace Buckaroo
{
  public class CreditManagementStatus
  {
    public int CmStatus { get; set; }
    public bool Running { get; set; }
    public int RemindersSent { get; set; }
    public int AgencyStatusAsString { get; set; }
    public List<AgencyUpdate> AgencyUpdates { get; set; }
  }
}
