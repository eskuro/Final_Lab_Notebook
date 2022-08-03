using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios.MetaData
{
	public interface IArticulo
	{

		[Required(ErrorMessage = "El campo {0} es Obligatorio")]
		int Codigo { get; set; }


		[Required(ErrorMessage = "El campo {0} es Obligatorio")]
		[StringLength(250, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
		string Descripcion { get; set; }

		[StringLength(10, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
		string Abreviatura { get; set; }

		[Required(ErrorMessage = "El campo {0} es Obligatorio")]
		[DefaultValue(0)]
		decimal Stock { get; set; }

		[Required(ErrorMessage = "El campo {0} es Obligatorio")]
		[DataType(DataType.Currency)]
		decimal Precio { get; set; }

	}
}
