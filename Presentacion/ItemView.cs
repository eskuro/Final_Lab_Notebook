using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
	public class ItemView
	{


		public long Id { get; set; }


		public long ArticuloId { get; set; }
		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		public decimal Precio { get; set; }
		public string PrecioStr => Precio.ToString("C");
		public decimal Cantidad { get; set; }

		public decimal Subtotal => Precio * Cantidad;

		public string SubTotalStr => Subtotal.ToString();
	}
}
