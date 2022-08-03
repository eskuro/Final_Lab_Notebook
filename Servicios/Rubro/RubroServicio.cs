using Dominios.UnidadDeTrabajo;
using IServicios.Base;
using IServicios.Rubro;
using IServicios.Rubro.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Rubro
{
	public class RubroServicio : IRubroServicio
	{

		private readonly IUnidadDeTrabajo _unidadDeTrabajo;

		public RubroServicio(IUnidadDeTrabajo unidadDeTrabajo)
		{
			_unidadDeTrabajo = unidadDeTrabajo;
		}


		public void Eliminar(long id)
		{
			_unidadDeTrabajo.RubroRepositorio.Eliminar(id);
			_unidadDeTrabajo.Commit();
		}

		public void Insertar(BaseDto dtoEntidad)
		{
			var dto = (RubroDto)dtoEntidad;

			var entidad = new Dominios.Entidades.Rubro
			{
				
				Descripcion = dto.Descripcion,
				EstaEliminado = false
			};

			_unidadDeTrabajo.RubroRepositorio.Insertar(entidad);
			_unidadDeTrabajo.Commit();
		}

		public void Modificar(BaseDto dtoEntidad)
		{
			var dto = (RubroDto)dtoEntidad;

			var entidad = _unidadDeTrabajo.RubroRepositorio.Obtener(dto.Id);

			if (entidad == null) throw new Exception("Ocurrió un Error al Obtener la Rubro");

			entidad.Descripcion = dto.Descripcion;

			_unidadDeTrabajo.RubroRepositorio.Modificar(entidad);
			_unidadDeTrabajo.Commit();
		}

		public BaseDto Obtener(long id)
		{
			var entidad = _unidadDeTrabajo.RubroRepositorio.Obtener(id);

			return new RubroDto
			{
				Id = entidad.Id,
				Descripcion = entidad.Descripcion,
				EstaEliminado = entidad.EstaEliminado
				
			};
		}

		public IEnumerable<BaseDto> Obtener(string cadenaBuscar)
		{
			return _unidadDeTrabajo.RubroRepositorio.Obtener(x => x.Descripcion.Contains(cadenaBuscar))
			   .Select(x => new RubroDto
			   {
				   Id = x.Id,
				   Descripcion = x.Descripcion,
				   EstaEliminado = x.EstaEliminado,
				   
				   
			   })
			   .OrderBy(x => x.Descripcion)
			   .ToList();
		}

		public bool VerificarSiExiste(string datoVerificar, long? entidadId = null)
		{
			return entidadId.HasValue
			   ? _unidadDeTrabajo.RubroRepositorio.Obtener(x => !x.EstaEliminado
																	&& x.Id != entidadId.Value
																	&& x.Descripcion.Equals(datoVerificar,
																		StringComparison.CurrentCultureIgnoreCase))
				   .Any()
			   : _unidadDeTrabajo.RubroRepositorio.Obtener(x => !x.EstaEliminado
																&& x.Descripcion.Equals(datoVerificar,
																	StringComparison.CurrentCultureIgnoreCase))
				   .Any();
		}
	}
}
