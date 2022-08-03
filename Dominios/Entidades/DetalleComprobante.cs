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
	[Table("DetalleComprobante")]
	[MetadataType(typeof(IDetalleComprobante))]
	public class DetalleComprobante:EntidadBase
	{

		public long ComprobanteId { get; set; }

		public long ArticuloId { get; set; }

		public string Codigo { get; set; }

		public string Descripcion { get; set; }

		public decimal Cantidad { get; set; }


		public decimal Precio { get; set; }

		public decimal SubTotal { get; set; }


		public virtual Comprobante Comprobante { get; set; }

		public virtual Articulo Articulos { get; set; }

	}
}
