﻿namespace Buckaroo
{
	public class CreditManagementCreateInvoiceResponse : ActionResponse
	{
		// No response Parameters
		public override ServiceEnum ServiceEnum => ServiceEnum.CreditManagement;

		public string InvoiceKey { get;set; }
	}
}
