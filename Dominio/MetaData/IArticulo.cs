using System.ComponentModel.DataAnnotations;

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
		[DataType(DataType.Currency)]
		decimal Precio { get; set; }
	}
}
