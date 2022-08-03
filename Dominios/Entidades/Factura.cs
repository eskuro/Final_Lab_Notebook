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
	[Table("Comprobante_Factura")]
	[MetadataType(typeof(IFactura))]
	public class Factura:Comprobante
	{
	}
}
