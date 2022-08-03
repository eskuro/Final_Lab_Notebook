using Dominios.Repositorio;
using Dominios.UnidadDeTrabajo;
using Infraestructura.Repositorio;
using Infraestructura.UnidadDeTrabajo;
using IServicios.Articulo;
using IServicios.Comprobante;
using IServicios.Rubro;
using Servicios.Articulo;
using Servicios.Comprobante;
using Servicios.Rubro;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIoc
{
	public class StructureMapContainer
	{

		public void Configure() 
		{
			ObjectFactory.Configure(x =>
			{

				x.For(typeof(IRepositorio<>)).Use(typeof(Repositorio<>));

				x.ForSingletonOf<DbContext>();

				x.For<IUnidadDeTrabajo>().Use<UnidadDeTrabajo>();


				x.For<IArticuloServicio>().Use<ArticuloServicio>();

				x.For<IRubroServicio>().Use<RubroServicio>();

				x.For<IFacturaServicio>().Use<FacturaServicio>();


			});


		}

	}
}
