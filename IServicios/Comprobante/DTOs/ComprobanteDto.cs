using IServicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.Comprobante.DTOs
{
	public class ComprobanteDto:BaseDto
	{

		public ComprobanteDto()
		{
			if (Items == null)
				Items = new List<DetalleComprobanteDto>();
		}
		public int Numero { get; set; }
		public decimal SubTotal { get; set; }
		public decimal Descuento { get; set; }
		public decimal Total { get; set; }

		public DateTime Fecha { get; set; }
		public List<DetalleComprobanteDto> Items { get; set; }
	}
}
