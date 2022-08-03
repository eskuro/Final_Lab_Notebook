using Dominios.Entidades;
using Dominios.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios.UnidadDeTrabajo
{
	public interface IUnidadDeTrabajo
	{
		void Commit();

		void Disposed();


		IRepositorio<Rubro> RubroRepositorio { get; }

		IRepositorio<Articulo> ArticuloRepositorio { get; }

		IFacturaRepositorio FacturaRepositorio { get; }

	}
}
