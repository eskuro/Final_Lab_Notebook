using Dominios.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominios.Entidades
{
	[Table("Articulo")]
	[MetadataType(typeof(IArticulo))]

	public class Articulo:EntidadBase
	{
		public int Codigo { get; set; }

		public string Descripcion { get; set; }
		
		public string Abreviatura { get; set; }
		public decimal Precio { get; set; }
		//public long RubroId { get; set; }
	}
	
}
