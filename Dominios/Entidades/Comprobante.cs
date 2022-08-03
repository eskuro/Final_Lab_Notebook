using Dominios.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios.Entidades
{
	[Table("Comprobante")]
	[MetadataType(typeof(IComprobante))]
	public class Comprobante:EntidadBase
	{
		public DateTime Fecha { get; set; }

		public int Numero { get; set; }

		public decimal SubTotal { get; set; }

		public decimal Descuento { get; set; }
		public decimal Total { get; set; }

		public virtual ICollection<DetalleComprobante> DetalleComprobantes { get; set; }
	}
}
