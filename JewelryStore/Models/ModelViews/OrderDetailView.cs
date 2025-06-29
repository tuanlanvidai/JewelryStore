using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelryStore.Models.ModelViews
{
	public class OrderDetailView
	{
		public int ID { get; set; } = 0;

		public int Quantity { get; set; } = 0;

		public decimal Price { get; set; } = 0;

		public int OrderID { get; set; } = 0;

		public int ProductID { get; set; } = 0;
	}
}