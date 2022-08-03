using Dominios.Entidades;
using IServicios.Comprobante.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Servicios.Comprobante
{
	public class Factura : Comprobante
	{


		public override long Insertar(ComprobanteDto comprobante)
		{
			using (var tran = new TransactionScope())
			{
				try
				{


					int numeroComprobante = 0;				
					var facturaDto = (FacturaDto)comprobante;
					Dominios.Entidades.Factura _facturaNueva = new Dominios.Entidades.Factura();
					numeroComprobante = comprobante.Numero;
					
					numeroComprobante++;

					_facturaNueva = new Dominios.Entidades.Factura
					{

						Descuento = facturaDto.Descuento,
						Numero = numeroComprobante,
						Fecha = DateTime.Now,
						SubTotal = facturaDto.SubTotal,
						Total = facturaDto.Total,
						DetalleComprobantes = new List<DetalleComprobante>(),
						EstaEliminado = false

					};


					foreach (var item in facturaDto.Items)
					{

						_facturaNueva.DetalleComprobantes.Add(new DetalleComprobante
						{
							
							Cantidad = item.Cantidad,
							ArticuloId = item.ArticuloId,
							Descripcion = item.Descripcion,
							Precio = item.Precio,							
							Codigo = item.Codigo,
							SubTotal = item.SubTotal
						});

					}

					_unidadDeTrabajo.FacturaRepositorio.Insertar(_facturaNueva);
					_unidadDeTrabajo.Commit();
					tran.Complete();
					return 0;

				}
				catch(Exception ex)
				{

					tran.Dispose();
					throw new Exception(ex.Message);

				}
				



			
			
		}
		}
	} 
}
