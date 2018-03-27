using Newtonsoft.Json;

namespace Buckaroo
{
  public class DataBase : IRequestBase
  {
    public IpAddress ClientIp { get; set; }
    public string ReturnUrl { get; set; }
    public string ReturnUrlCancel { get; set; }
    public string ReturnUrlError { get; set; }
    public string ReturnUrlReject { get; set; }
    public string Invoice { get; set; }
    public string Description { get; set; }
    public string Currency { get; set; }
    public decimal Amount { get; set; }
    public decimal AmountCredit { get; set; }
    public string OriginalTransactionKey { get; set; }
    public TransactionReference OriginalTransactionReference { get; set; }
    public ContinueOnIncomplete ContinueOnIncomplete { get; set; }
    public string ClientUserAgent { get; set; }
    [JsonProperty()]
    internal DataRequestServices Services { get; set; }
    [JsonProperty()]
    internal CustomParameters CustomParameters { get; set; }
    [JsonProperty()]
    internal AdditionalParameters AdditionalParameters { get; set; }

    public DataBase()
    {
      Services = new DataRequestServices();
      OriginalTransactionReference = new TransactionReference();
      ClientIp = new IpAddress();
    }

    /// <summary>
    /// Adds a custom parameter to the transactionbase. requires a parameter key and a parameter value.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public DataBase AddCustomParameter(string key, string value)
    {
      CustomParameters.List.Add(new CustomParameter
      {
        Name = key,
        Value = value
      });

      return this;
    }

    /// <summary>
    /// Adds an additional parameter to the transactionbase. requires a parameter key and a parameter value.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public DataBase AddAdditionalParameter(string key, string value)
    {
      AdditionalParameters.AdditionalParameter.Add(new AdditionalParameter
      {
        Name = key,
        Value = value
      });

      return this;
    }
  }
}