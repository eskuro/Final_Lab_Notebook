using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
	public class FacturaView
	{

		public FacturaView() 
		{
		
		
			if (Items == null) 
			{

				Items = new List<ItemView>();
			}
		
		}


		public int ContadorItem { get; set; } = 0;

		public List<ItemView> Items { get; set; }

		public decimal SubTotal => Items.Sum(x => x.Subtotal);

		public string SubTotalStr => SubTotal.ToString("C");

		public decimal Descuento { get; set; }

		public decimal Total => SubTotal - (SubTotal * Descuento / 100m);

		public string TotalStr => Total.ToString("C");

	}
}
