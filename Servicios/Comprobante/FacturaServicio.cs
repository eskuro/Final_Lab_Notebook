using Dominios.UnidadDeTrabajo;
using IServicios.Comprobante;
using IServicios.Comprobante.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Comprobante
{
	public class FacturaServicio:ComprobanteServicio,IFacturaServicio
	{

		public FacturaServicio(IUnidadDeTrabajo unidadDeTrabajo)
			: base(unidadDeTrabajo)
		{
		}

        public IEnumerable<ComprobanteDto> ObtenerComprobante()
        {
			return _unidadDeTrabajo.FacturaRepositorio
				.Obtener(x => !x.EstaEliminado , "DetalleComprobantes")
				.Select(x => new ComprobanteDto
				{
					Id = x.Id,										
					Fecha = x.Fecha,					
					Total = x.Total,
					Numero = x.Numero,					
					EstaEliminado = x.EstaEliminado,
					Items = x.DetalleComprobantes.Select(d => new DetalleComprobanteDto
					{
						Id = d.Id,
						Descripcion = d.Descripcion,
						Cantidad = d.Cantidad,
						Precio = d.Precio,
						SubTotal = d.SubTotal,
						EstaEliminado = d.EstaEliminado,



					}).ToList(),

				})
				.OrderByDescending(x => x.Fecha)
				.ToList();
		}
    }
}
