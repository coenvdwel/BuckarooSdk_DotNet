using System;

namespace Buckaroo
{
  internal class BuckarooException : Exception
  {
    internal string ErrorMessage { get; set; }

    internal BuckarooException()
    {
      ErrorMessage = "unknown exception";
    }

    internal BuckarooException(string errorMessage)
    {
      ErrorMessage = errorMessage + Message;
    }
  }
}