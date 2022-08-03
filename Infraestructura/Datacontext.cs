using Dominios.Entidades;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using static CadenaConexion.CadenaConexion;
namespace Infraestructura
{
	public class Datacontext : DbContext
	{

		public Datacontext()
			: base(ObtenerCadenaSql)
		{


			

		}



		public DbSet<Articulo> Articulos { get; set; }

		public DbSet<Rubro>Rubros { get; set; }

		public DbSet<Comprobante> Comprobantes { get; set; }

		public DbSet<DetalleComprobante> DetalleComprobantes { get; set; }

		public DbSet<Factura> Facturas { get; set; }
	}
}
