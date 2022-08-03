using IServicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.Rubro
{
	public interface IRubroServicio : IServicio
	{


		bool VerificarSiExiste(string datoVerificar, long? entidadId = null);
	}
}
