﻿using IServicios.Comprobante.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServicios.Comprobante
{
	public interface IFacturaServicio:IComprobanteServicio
	{
		IEnumerable<ComprobanteDto> ObtenerComprobante();
	}
}
