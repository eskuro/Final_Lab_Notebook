using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.Base
{
	public interface IServicioAbm
	{

		void Insertar(BaseDto dtoEntidad);

		void Modificar(BaseDto dtoEntidad);

		void Eliminar(long id);
	}
}
