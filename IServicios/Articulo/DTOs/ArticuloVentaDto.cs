using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.Articulo.DTOs
{
	public class ArticuloVentaDto
	{
		public long Id { get; set; }
		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		public string Abreviatura { get; set; }
		public decimal Stock { get; set; }
		public decimal Precio { get; set; }

		public string PrecioStr => Precio.ToString("C");
	}
}
