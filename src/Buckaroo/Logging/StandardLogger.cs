using System.Text;

namespace Buckaroo
{
  public class StandardLogger : ILogger
  {
    private readonly StringBuilder _processLogger;
    private readonly StringBuilder _errorLogger;
    private readonly StringBuilder _warningLogger;
    internal string RawRequest;
    internal string RawResponse;

    public StandardLogger()
    {
      _errorLogger = new StringBuilder();
      _processLogger = new StringBuilder();
      _warningLogger = new StringBuilder();
    }

    public void AddErrorLogging(string errorLog)
    {
      _errorLogger.AppendLine(errorLog);
    }

    private int _processStep = 1;
    public void AddProcessLogging(string processLog)
    {
      _processLogger.AppendLine($"{_processStep}. {processLog}");
      _processStep++;
    }

    public void AddWarningLogging(string warning)
    {
      _warningLogger.AppendLine(warning);
    }

    public string GetErrorLog()
    {
      return _errorLogger.ToString();
    }

    public string GetProcessLog()
    {
      return _processLogger.ToString();
    }

    public string GetWarningLog()
    {
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
    }

    public void HandleRawResponse(string response)
    {
      RawResponse = response;
    }

    public void Dispose()
    {
    }
  }
}