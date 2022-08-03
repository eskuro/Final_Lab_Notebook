using Dominios.Entidades;
using Dominios.Repositorio;
using Dominios.UnidadDeTrabajo;
using Infraestructura.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.UnidadDeTrabajo
{
	public class UnidadDeTrabajo : IUnidadDeTrabajo
	{

		private readonly Datacontext _context;

		public UnidadDeTrabajo(Datacontext context)
		{
			_context = context;
		}

		public void Commit()
		{

			try
			{
				_context.SaveChanges();
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
			{
				Exception raise = dbEx;

				foreach (var validationErrors in dbEx.EntityValidationErrors)
				{
					foreach (var validationError in validationErrors.ValidationErrors)
					{
						var message = $"{validationErrors.Entry.Entity.ToString()}:{validationError.ErrorMessage}";

						raise = new InvalidOperationException(message, raise);
					}
				}

				throw raise;
			}


		}

		public void Disposed()
		{
			_context.Dispose();
		}


		private IRepositorio<Articulo> articuloRepositorio;

		public IRepositorio<Articulo> ArticuloRepositorio => articuloRepositorio
															 ?? (articuloRepositorio =
																 new Repositorio<Articulo>(_context));

		private IRepositorio<Rubro> rubroRepositorio;

		public IRepositorio<Rubro> RubroRepositorio => rubroRepositorio
													   ?? (rubroRepositorio =
														   new Repositorio<Rubro>(_context));



		private IFacturaRepositorio facturaRepositorio;

		public IFacturaRepositorio FacturaRepositorio => facturaRepositorio
															 ?? (facturaRepositorio =
																 new FacturaRepositorio(_context));
	}
}
