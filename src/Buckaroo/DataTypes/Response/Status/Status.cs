using System;

namespace Buckaroo
{
  /// <summary>
  /// The overcoupling class of the current status that is returned in the response, 
  /// belonging to the transaction request.
  /// </summary>
  public class Status
  {
    public const int Success = 190;
    public const int Failed = 490;
    public const int FailedValidation = 491;
    public const int TechnicalError = 492;
    public const int Declined = 690;
    public const int PendingInput = 790;
    public const int PendingProcessing = 791;
    public const int WaitingForConsumer = 792;
    public const int OnHold = 793;
    public const int CanceledByUser = 890;
    public const int CanceledByMerchant = 891;

    /// <summary>
    /// The actual code of the status
    /// </summary>
    public StatusCode Code { get; set; }
    /// <summary>
    /// The statussubcode of the status
    /// </summary>
    public StatusSubCode SubCode { get; set; }
    /// <summary>
    /// The datetime stamp that states when the status was set.
    /// </summary>
    public DateTime DateTime { get; set; }

    /// <summary>
    /// primary status constructor
    /// </summary>
    public Status()
    {
      Code = new StatusCode();
      SubCode = new StatusSubCode();
    }
  }
}