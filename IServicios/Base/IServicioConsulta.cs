using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.Base
{
	public interface IServicioConsulta
	{
		BaseDto Obtener(long id);

		IEnumerable<BaseDto> Obtener(string cadenaBuscar);

	}
}
