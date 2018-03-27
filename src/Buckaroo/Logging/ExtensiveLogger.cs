using System.Diagnostics;
using System.Text;

namespace Buckaroo
{
  public class ExtensiveLogger : ILogger
  {
    private readonly StringBuilder _processLogger = new StringBuilder();
    private readonly StringBuilder _errorLogger = new StringBuilder();
    private readonly StringBuilder _warningLogger = new StringBuilder();

    internal string RawRequest;
    internal string RawResponse;

    public void AddErrorLogging(string errorLog)
    {
      _errorLogger.AppendLine(errorLog);
      Debug.WriteLine(errorLog);
    }

    public void AddProcessLogging(string processLog)
    {
      _processLogger.AppendLine(processLog);
      Debug.WriteLine(processLog);
    }

    public void AddWarningLogging(string warning)
    {
      _warningLogger.AppendLine(warning);
      Debug.WriteLine(warning);
    }

    public string GetErrorLog()
    {
      Debug.WriteLine("ErrorLog retrieved.");
      return _errorLogger.ToString();
    }

    public string GetProcessLog()
    {
      Debug.WriteLine("ProcessLog retrieved.");
      return _processLogger.ToString();
    }

    public string GetWarningLog()
    {
      Debug.WriteLine("WarningLog retrieved.");
      return _warningLogger.ToString();
    }
    public string GetFullLog()
    {
      var fullLog = new StringBuilder()
          .AppendLine("\n---ERRORLOG---\n\n" + _errorLogger + "\n\n---END ERRORLOG---")
          .AppendLine("\n---PROCESSLOG---\n\n" + _processLogger + "\n\n---END PROCESSLOG---")
          .AppendLine("\n---WARNINGLOG---\n\n" + _warningLogger + "\n\n---END WARNINGLOG---");

      return fullLog.ToString();
    }

    public string GetRawRequest()
    {
      return RawRequest;
    }

    public string GetRawResponse()
    {
      return RawResponse;
    }

    public void HandleRawRequest(string request)
    {
      RawRequest = request;
      Debug.WriteLine(request);
    }

    public void HandleRawResponse(string response)
    {
      RawResponse = response;
      Debug.WriteLine(response);
    }

    public void Dispose()
    {
    }
  }
}