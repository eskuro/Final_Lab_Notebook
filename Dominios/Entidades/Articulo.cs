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
	[Table("Articulo")]
	[MetadataType(typeof(IArticulo))]

	public class Articulo : EntidadBase
	{

		public long RubroId { get; set; }

		public int Codigo { get; set; }
		public string Descripcion { get; set; }
		public string Abreviatura { get; set; }
		public decimal Stock { get; set; }
		public decimal Precio { get; set; }




		public virtual ICollection<DetalleComprobante> DetalleComprobantes { get; set; }
		public virtual Rubro Rubro { get; set; }

	}
}
