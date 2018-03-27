﻿namespace Buckaroo
{
  /// <summary>
  /// The idealrequest class, where the issuer of the request is specified.
  /// </summary>
  public class IdealPayRemainderRequest
  {
    /// <summary>
    /// Use constants in BuckarooSdk.Services.Ideal.IdealIssuer
    /// </summary>
    public string Issuer { get; set; }
  }
}
