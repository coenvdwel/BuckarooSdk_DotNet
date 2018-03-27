﻿using System;

namespace Buckaroo
{
  public class AfterPayPayRequest
  {
    public string BillingTitle { get; set; }
    public Gender BillingGender { get; set; }
    public string BillingInitials { get; set; }
    public string BillingLastName { get; set; }
    public DateTime BillingBirthDate { get; set; }
    public string BillingStreet { get; set; }
    public int BillingHouseNumber { get; set; }
    public string BillingPostalCode { get; set; }
    public string BillingCity { get; set; }
    public string BillingCountry { get; set; }
    public string BillingEmail { get; set; }
    public string BillingPhoneNumber { get; set; }
    public string BillingLanguage { get; set; }

    public bool AddressesDiffer { get; set; }

    public string ShippingTitle { get; set; }
    public Gender ShippingGender { get; set; }
    public string ShippingInitials { get; set; }
    public string ShippingLastName { get; set; }
    public DateTime ShippingBirthDate { get; set; }
    public string ShippingStreet { get; set; }
    public int ShippingHouseNumber { get; set; }
    public string ShippingPostalCode { get; set; }
    public string ShippingCity { get; set; }
    public string ShippingCountryCode { get; set; }
    public string ShippingEmail { get; set; }
    public string ShippingPhoneNumber { get; set; }
    public string ShippingLanguage { get; set; }

    public bool B2B { get; set; }

    public string CompanyCOCRegistration { get; set; }
    public string CompanyName { get; set; }
    public string CostCentre { get; set; }
    public string Department { get; set; }
    public string EstablishmentNumber { get; set; }
    public string VatNumber { get; set; }

    public bool Accept { get; set; }
    public decimal ShippingCosts { get; set; }
    public string CustomerIPAddress { get; set; }
    public Articles Articles { get; set; }
  }
}