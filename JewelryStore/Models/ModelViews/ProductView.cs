using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelryStore.Models.ModelViews
{
	public class ProductView
	{
		public int ID { get; set; } = 0;

		public string ProductName { get; set; } = "";

		public int Stock { get; set; } = 0;

		public decimal Price { get; set; } = 0;

		public string Description { get; set; } = "";

		public string Image { get; set; } = "";

		public int ProductSizeID { get; set; } = 0;

		public int MaterialID { get; set; } = 0;

		public int GemstoneTypeID { get; set; } = 0;

		public int CategoryID { get; set; } = 0;
	}
}