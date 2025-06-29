using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelryStore.Models.ModelViews
{
	public class PaymentView
	{
		public int ID { get; set; } = 0;

		public string PaymentMethod { get; set; } = "";

		public string PaymentStatus { get; set; } = "";

		public DateTime PaymentDate { get; set; } = DateTime.Now;

		public decimal Amount { get; set; } = 0;

		public int BillID { get; set; } = 0;
	}
}