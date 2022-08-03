using IServicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.Articulo.DTOs
{
	public class ArticuloDto : BaseDto
	{

		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		public string Abreviatura { get; set; }
		public decimal Stock { get; set; }
		public decimal Precio { get; set; }
		

		public long RubroId { get; set; }
	}
}
