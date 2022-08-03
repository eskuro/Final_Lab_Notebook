using FormularioBase;
using IServicios.Articulo;
using IServicios.Articulo.DTOs;
using IServicios.Rubro;
using StructureMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
	public partial class Abm_Articulos : FormAbm
	{

		private readonly IArticuloServicio _articuloServicio;
		private readonly IRubroServicio _rubroServicio;
		public Abm_Articulos(TipoOperacion tipoOperacion, long? entidadId = null)
			: base(tipoOperacion, entidadId)
		{
			InitializeComponent();


			_articuloServicio = ObjectFactory.GetInstance<IArticuloServicio>();
			_rubroServicio = ObjectFactory.GetInstance<IRubroServicio>();

			PoblarComboBox(cmbRubro, _rubroServicio.Obtener(string.Empty), "Descripcion", "Id");
			CargarDatos(entidadId);
		}


		public override void CargarDatos(long? entidadId)
		{
			base.CargarDatos(entidadId);
			if (entidadId.HasValue)
			{				
				nudStock.Enabled = false;
				var resultado = (ArticuloDto)_articuloServicio.Obtener(entidadId.Value);
				if (resultado == null)
				{
					MessageBox.Show("Ocurrio un error al obtener el registro seleccionado");
					Close();
				}
				// ==================================================== //
				// =============== Datos del Articulo ========== //
				// ==================================================== //
				txtCodigo.Text = resultado.Codigo.ToString();				
				txtDescripcion.Text = resultado.Descripcion;
				txtAbreviatura.Text = resultado.Abreviatura;		
				cmbRubro.SelectedValue = resultado.RubroId;
				nudPrecio.Value = resultado.Precio;
				nudStock.Value = resultado.Stock;
		
				if (TipoOperacion == TipoOperacion.Eliminar)
					DesactivarControles(this);
			}
			else // Nuevo
			{
				btnEjecutar.Text = "Grabar";
				LimpiarControles(this);
			}
		}

		public override bool VerificarDatosObligatorios()
		{
			if (string.IsNullOrEmpty(txtCodigo.Text)) return false;			
			if (string.IsNullOrEmpty(txtDescripcion.Text)) return false;			
			if (cmbRubro.Items.Count <= 0) return false;			
			return true;
		}

		public override void EjecutarComandoNuevo()
		{
			var nuevoRegistro = new ArticuloDto
			{
				Codigo = txtCodigo.Text,				
				Descripcion = txtDescripcion.Text,
				Abreviatura = txtAbreviatura.Text,										
				RubroId = (long)cmbRubro.SelectedValue,				
				Precio = nudPrecio.Value,			
				Stock = nudStock.Value,	
				EstaEliminado = false
			};
			_articuloServicio.Insertar(nuevoRegistro);
		}

		public override void EjecutarComandoModificar()
		{
			var modificarRegistro = new ArticuloDto
			{
				Id = EntidadId.Value,
				Codigo = txtCodigo.Text,
				Descripcion = txtDescripcion.Text,
				Abreviatura = txtAbreviatura.Text,
				RubroId = (long)cmbRubro.SelectedValue,
				Precio = nudPrecio.Value,
				Stock = nudStock.Value,
				EstaEliminado = false
			};
			_articuloServicio.Modificar(modificarRegistro);
		}

		public override void EjecutarComandoEliminar()
		{
			_articuloServicio.Eliminar(EntidadId.Value);
		}
		public override bool VerificarSiExiste(long? id = null)
		{
			return _articuloServicio.VerificarSiExiste(txtDescripcion.Text, id);
		}

		private void btnNuevoRubro_Click(object sender, EventArgs e)
		{
			var fNuevoRubro = new Abm_Rubro(TipoOperacion.Nuevo);
			fNuevoRubro.ShowDialog();
			if (fNuevoRubro.RealizoAlgunaOperacion)
			{
				PoblarComboBox(cmbRubro, _rubroServicio.Obtener(string.Empty));
			}
		}

		private void txtCodigo_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
