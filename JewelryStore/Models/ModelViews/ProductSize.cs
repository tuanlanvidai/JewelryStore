using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelryStore.Models.ModelViews
{
	public class ProductSize
	{
		public int ID { get; set; } = 0;

		public decimal Price { get; set; } = 0;

		public int Stock { get; set; } = 0;

		public int ProductID { get; set; } = 0;

		public int SizeID { get; set; } = 0;
	}
}