using System;

namespace Buckaroo
{
  /// <summary>
  /// 
  /// MIT License
  /// 
  /// Copyright (c) 2018 Buckaroo - Sjaak Roos
  /// (fork by New Black BV)
  /// 
  /// </summary>
  public class SdkClient
  {
    private PushHandler PushHandler { get; set; }

    private Func<ILogger> LoggerFactory { get; set; }

    /// <summary>
    /// Default constructor. The standard logger will be used by this instance, if none is provided when creating a request.
    /// </summary>
    public SdkClient()
    {
      LoggerFactory = () => new StandardLogger();
    }

    /// <summary>
    /// Constructor where a custom logger factory can be set, for creating custom implemented loggers.
    /// </summary>
    /// <param name="loggerFactory">A locally stored function, e.g. () => new CustomImplementationLogger() </param>
    public SdkClient(Func<ILogger> loggerFactory)
    {
      this.LoggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
    }

    /// <summary>
    /// Create request function that returns a new request.
    /// </summary>
    /// <returns></returns>
    public Request CreateRequest()
    {
      return new Request(LoggerFactory());
    }

    /// <summary>
    /// Create request function that returns a new request. A ILogger implementations can be provided. If omitted, the Logger
    /// instance will be provided by the LoggerFactory.
    /// </summary>
    /// <param name="logger"></param>
    /// <returns></returns>
    public Request CreateRequest(ILogger logger)
    {
      return new Request(logger);
    }

    /// <summary>
    /// Create request function that returns a new request. A StandardLogger implementations can be provided. If omitted, the Logger
    /// instance will be provided by the LoggerFactory.
    /// </summary>
    /// <param name="logger"></param>
    /// <returns></returns>
    public Request CreateRequest(StandardLogger logger)
    {
      return new Request(logger);
    }

    /// <summary>
    /// Create request function that returns a new request. A ExtensiveLogger implementations can be provided. If omitted, the Logger
    /// instance will be provided by the LoggerFactory.
    /// </summary>
    /// <param name="logger"></param>
    /// <returns></returns>
    public Request CreateRequest(ExtensiveLogger logger)
    {
      return new Request(logger);
    }

    /// <summary>
    /// Returns a Buckaroo push handler, that can be used to process push messages.
    /// </summary>
    /// <returns></returns>
    public PushHandler GetPushHandler()
    {
      return PushHandler ?? (PushHandler = new PushHandler());
    }
  }
}