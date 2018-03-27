﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buckaroo
{
	public class IdealQrGenerateRequest
	{
		public decimal Amount { get; set; }
		public DateTime Expiration { get; set; }
		public string Description { get; set; }
		public int ImageSize { get; set; }
		public bool AmountIsChangeable { get; set; }
		public decimal MaxAmount { get; set; }
		public decimal MinAmount { get; set; }
		public string PurchaseId { get; set; }
		public bool IsProcessing { get; set; }
		public bool IsOneOff { get; set; }
	}
}
