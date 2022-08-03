using Dominios.UnidadDeTrabajo;
using IServicios.Articulo;
using IServicios.Articulo.DTOs;
using IServicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Articulo
{


	public class ArticuloServicio : IArticuloServicio
	{
		private readonly IUnidadDeTrabajo _unidadDeTrabajo;


		public ArticuloServicio(IUnidadDeTrabajo unidadDeTrabajo)
		{
			_unidadDeTrabajo = unidadDeTrabajo;
		}

		public void Eliminar(long id)
		{
			_unidadDeTrabajo.ArticuloRepositorio.Eliminar(id);
			_unidadDeTrabajo.Commit();
		}

		public void Insertar(BaseDto dtoEntidad)
		{
			
			var dto = (ArticuloDto)dtoEntidad;
		
			var entidad = new Dominios.Entidades.Articulo
			{
				RubroId = dto.RubroId,
				EstaEliminado = dto.EstaEliminado,
				Descripcion = dto.Descripcion,
				Abreviatura = dto.Abreviatura,
				Codigo = int.Parse(dto.Codigo),
				Precio = dto.Precio,
				Stock = dto.Stock

			};

			_unidadDeTrabajo.ArticuloRepositorio.Insertar(entidad);
			_unidadDeTrabajo.Commit();
		}

		public void Modificar(BaseDto dtoEntidad)
		{
			var dto = (ArticuloDto)dtoEntidad;

			var entidad = _unidadDeTrabajo.ArticuloRepositorio.Obtener(dto.Id);

			if (entidad == null) throw new Exception("Ocurrió un Error al Obtener la Rubro");

			entidad.Descripcion = dto.Descripcion;

			_unidadDeTrabajo.ArticuloRepositorio.Modificar(entidad);
			_unidadDeTrabajo.Commit();
		}

		public BaseDto Obtener(long id)
		{
			var entidad = _unidadDeTrabajo.ArticuloRepositorio.Obtener(id, "Rubro");
			

			return new ArticuloDto
			{
				Id = entidad.Id,
				RubroId = entidad.RubroId,
				Descripcion = entidad.Descripcion,
				EstaEliminado = entidad.EstaEliminado,
				Abreviatura = entidad.Abreviatura,
				Codigo = entidad.Codigo.ToString(),
				Precio = entidad.Precio,
				Stock = entidad.Stock,

			};
		}

		public IEnumerable<BaseDto> Obtener(string cadenaBuscar)
		{
			


			Expression<Func<Dominios.Entidades.Articulo, bool>> filtro = x =>
			x.Descripcion.Contains(cadenaBuscar)
			|| x.Rubro.Descripcion.Contains(cadenaBuscar);

			return _unidadDeTrabajo.ArticuloRepositorio.Obtener(filtro, "Rubro")
			.Select(x => new ArticuloDto
			{

				Id = x.Id,
				RubroId = x.RubroId,
				Descripcion = x.Descripcion,
				EstaEliminado = x.EstaEliminado,
				Abreviatura = x.Abreviatura,
				Codigo = x.Codigo.ToString(),
				Precio = x.Precio,
				Stock = x.Stock,

			}).OrderBy(x => x.Descripcion)
			.ToList(); 
		}

		public IEnumerable<ArticuloVentaDto> ObtenerLookUp(string cadenaBuscar)
		{
			int.TryParse(cadenaBuscar, out int codigoArticulo);

			Expression<Func<Dominios.Entidades.Articulo, bool>> filtro = x => !x.EstaEliminado
																			 && x.Codigo.ToString() == cadenaBuscar
																			 || x.Descripcion.Contains(cadenaBuscar)
																			 || x.Codigo == codigoArticulo;

			return _unidadDeTrabajo.ArticuloRepositorio.Obtener(filtro,
					"")
				.Select(x => new ArticuloVentaDto()
				{
					Id = x.Id,					
					Descripcion = x.Descripcion,				
					Abreviatura = x.Abreviatura,
					Codigo = x.Codigo.ToString(),
					Precio = x.Precio,
					Stock = x.Stock,
				}).ToList();
		}

		public ArticuloVentaDto ObtenerPorCodigo(string codigo)
		{
			 var fechaActual = DateTime.Now;

			int.TryParse(codigo, out int _codigo);

			return _unidadDeTrabajo.ArticuloRepositorio.Obtener(x => x.Codigo.ToString() == codigo || x.Codigo == _codigo,
					"Rubro")
				.Select(x => new ArticuloVentaDto()
				{
					Id = x.Id,					
					Codigo = x.Codigo.ToString(),
					Descripcion = x.Descripcion,
					Precio = x.Precio,
					Stock = x.Stock,
					Abreviatura = x.Abreviatura,
					
				}).FirstOrDefault();
		}

		public bool VerificarSiExiste(string datoVerificar, long? entidadId = null)
		{
			return entidadId.HasValue
			? _unidadDeTrabajo.ArticuloRepositorio.Obtener(x => !x.EstaEliminado
			&& x.Id != entidadId.Value
			&& x.Descripcion.Equals(datoVerificar,
			StringComparison.CurrentCultureIgnoreCase))
			.Any()
			: _unidadDeTrabajo.ArticuloRepositorio.Obtener(x => !x.EstaEliminado
			&& x.Descripcion.Equals(datoVerificar,
			StringComparison.CurrentCultureIgnoreCase))
			.Any();
		}

		
	}
}
