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

	[Table("Rubro")]
	[MetadataType(typeof(IRubro))]
	public class Rubro : EntidadBase
	{

		public string Descripcion { get; set; }



		public virtual ICollection<Articulo> Articulos { get; set; }



	}
}
