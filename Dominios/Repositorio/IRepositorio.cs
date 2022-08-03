using Dominios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominios.Repositorio
{
	public interface IRepositorio<TEntidad> where TEntidad : EntidadBase
	{

        long Insertar(TEntidad entidad);

        void Eliminar(long entidadId);

        void Modificar(TEntidad entidad);


        // Metodos de Lectura

        TEntidad Obtener(long entidadId, string propiedadNavegacion = "");

        IEnumerable<TEntidad> Obtener(Expression<Func<TEntidad, bool>> filtro = null, string propiedadesNavegacion = "");

    }
}
