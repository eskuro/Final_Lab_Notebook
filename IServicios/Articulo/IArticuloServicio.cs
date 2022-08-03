using IServicios.Articulo.DTOs;
using IServicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.Articulo
{
	public interface IArticuloServicio : IServicio
	{

		bool VerificarSiExiste(string datoVerificar, long? entidadId = null);

		ArticuloVentaDto ObtenerPorCodigo(string codigo);

		IEnumerable<ArticuloVentaDto> ObtenerLookUp(string cadenaBuscar);

	}
}
