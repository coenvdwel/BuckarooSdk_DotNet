﻿using System;

namespace Buckaroo
{
  public class TransferPayRequest
  {
    /// <summary>
    /// The first name of the customer.
    /// </summary>
    public string CustomerFirstName { get; set; }
    /// <summary>
    /// The last name of the customer.
    /// </summary>
    public string CustomerLastName { get; set; }
    /// <summary>
    /// The gender of the customer.
    /// </summary>
    public string CustomerGender { get; set; }
    /// <summary>
    /// The country of origin of the customer.
    /// </summary>
    public string CustomerCountry { get; set; }
    /// <summary>
    /// States wether an email will be sent to the customer.
    /// </summary>
    public bool SendMail { get; set; }
    /// <summary>
    /// The email address of the customer. Required if the boolean SendMail == true.
    /// </summary>
    public string CustomerEmail { get; set; }
    public DateTime DateDue { get; set; }
  }
}
