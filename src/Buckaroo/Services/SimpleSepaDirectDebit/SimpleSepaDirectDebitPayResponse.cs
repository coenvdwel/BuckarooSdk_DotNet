﻿using System;

namespace Buckaroo
{
    public class SimpleSepaDirectDebitPayResponse : ActionResponse
    {
	    public override ServiceEnum ServiceEnum => ServiceEnum.SimpleSepaDirectDebit;
		/// <summary>
		/// The date the mandate has been registered
		/// </summary>
        public DateTime MandateDate { get; set; }
		/// <summary>
		/// The type of direct debit that will be processed.
		/// </summary>
        public string DirectDebitType { get; set; }
		/// <summary>
		/// The date the mandate has been registered.
		/// </summary>
        public DateTime CollectDate { get; set; }
		/// <summary>
		/// The mandate reference number.
		/// </summary>
        public string MandateReference { get; set; }
		/// <summary>
		/// The IBAN of the customers account.
		/// </summary>
		public string CustomerIban { get; set; }
		/// <summary>
		/// The BIC of the customers account.
		/// </summary>
		public string CustomerBic { get; set; }
    }
}
