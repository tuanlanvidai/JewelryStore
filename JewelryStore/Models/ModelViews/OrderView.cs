using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelryStore.Models.ModelViews
{
	public class OrderView
	{
		public int ID { get; set; } = 0;

		public int Stock { get; set; } = 0;

		public string ShippingAddress { get; set; } = "";

		public int Status { get; set; } = 0;

		public DateTime OrderDate { get; set; } = DateTime.Now;

		public string order_note { get; set; } = "";

		public int discountID { get; set; } = 0;

		public int UserID { get; set; } = 0;
    }
}