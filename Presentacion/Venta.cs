using FormularioBase;
using IServicios.Articulo;
using IServicios.Articulo.DTOs;
using IServicios.Comprobante;
using IServicios.Comprobante.DTOs;
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
	public partial class Venta : FormBase
	{
		private FacturaView _factura;
		private ItemView _itemSeleccionado;
		private ArticuloVentaDto _articuloSeleccionado;

		private bool _cambiarCantidadError;


		private readonly IArticuloServicio _articuloServicio;
		private readonly IFacturaServicio _facturaServicio;
		public Venta(IArticuloServicio articuloServicio, IFacturaServicio facturaServicio)
		{
			InitializeComponent();

			_articuloServicio = articuloServicio;
			_facturaServicio = facturaServicio;
			_factura = new FacturaView();

			_cambiarCantidadError = false;
		}

		private void AgregarItem(ArticuloVentaDto articulo , decimal cantidad) 
		{

			var totalArticulosItems = _factura.Items
					   .Where(x => x.ArticuloId == articulo.Id)
					   .Sum(x => x.Cantidad);

			_factura.Items.Add(AsignarDatosItem(articulo, cantidad));


		}

		private ItemView AsignarDatosItem(ArticuloVentaDto articulo, decimal cantidad)
		{

			_factura.ContadorItem++;
			return new ItemView
			{
				Id = _factura.ContadorItem,
				Descripcion = articulo.Descripcion,				
				Precio = articulo.Precio,		
				Codigo = articulo.Codigo,
				Cantidad = cantidad,			
				ArticuloId = articulo.Id,
			
			};
		}

		private void btnFacturar_Click(object sender, EventArgs e)
		{

			if (dgvGrilla.RowCount >= 0)
			{
				try
				{
					var nuevocomprobante = new FacturaDto
					{
						
						Descuento = _factura.Descuento,
						SubTotal = _factura.SubTotal,
						Total = _factura.Total,
						EstaEliminado = false,

					};

					foreach (var item in _factura.Items)
					{
						nuevocomprobante.Items.Add(new DetalleComprobanteDto
						{
							Id = item.Id,
							Cantidad = item.Cantidad,
							Precio = item.Precio,
							Descripcion = item.Descripcion,
							SubTotal = item.Subtotal,
							ArticuloId = item.ArticuloId,
							Codigo = item.Codigo,							
							EstaEliminado = false


						});

					}

					_facturaServicio.Insertar(nuevocomprobante);

					MessageBox.Show("Los datos se grabaro correctamente");
					LimpiarParaNuevaFactura();
				}
				catch(Exception ex) 
				{
					MessageBox.Show(ex.Message);

				}
			}

		}

		private void LimpiarParaNuevaFactura()
		{
			_factura = new FacturaView();
			
			LimpiarParaNuevoItem();
		}
		private void LimpiarParaNuevoItem()
		{
			txtCodigo.Clear();
			txtDescripcion.Clear();
			txtPrecio.Clear();
			nudCantidad.Value = 1;
			nudCantidad.Enabled = true;			
			_articuloSeleccionado = null;
			txtCodigo.Focus();
		}

		private void btnBorrarItem_Click(object sender, EventArgs e)
		{
			if (dgvGrilla.RowCount <= 0) return;

			if (MessageBox.Show($"Esta seguro de Eliminar el Item {_itemSeleccionado.Descripcion}", "Atencion", MessageBoxButtons.OKCancel
				, MessageBoxIcon.Question) == DialogResult.OK)
			{

				_factura.Items.Remove(_itemSeleccionado);
				LimpiarParaNuevoItem();
				CargarCuerpo();
				CargarPie();

				

			}
		}
		private void CargarPie()
		{
			txtSubTotal.Text = _factura.SubTotalStr;
			nudDescuento.Value = _factura.Descuento;
			txtTotal.Text = _factura.TotalStr;
		}

		private void CargarCuerpo()
		{
			dgvGrilla.DataSource = _factura.Items.ToList();
			FormatearGrilla(dgvGrilla);

			
		}

		private void Venta_Load(object sender, EventArgs e)
		{
			CargarCuerpo();
		}

		private void nudDescuento_ValueChanged(object sender, EventArgs e)
		{
			_factura.Descuento = nudDescuento.Value;
		}

		private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyValue)
			{
				
				// F8
				case 119:

					var lookUpArticulo = new ArticuloLookUp();
					lookUpArticulo.ShowDialog();

					if (lookUpArticulo.EntidadSeleccionada != null)
					{
						_articuloSeleccionado = (ArticuloVentaDto)lookUpArticulo.EntidadSeleccionada;

						
							txtCodigo.Text = _articuloSeleccionado.Codigo;
							txtDescripcion.Text = _articuloSeleccionado.Descripcion;
							txtPrecio.Text = _articuloSeleccionado.Precio.ToString();
							nudCantidad.Focus();
							nudCantidad.Select(0, nudCantidad.Text.Length);
							return;
						
					}
					else
					{
						LimpiarParaNuevoItem();
					}

					break;
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (_articuloSeleccionado != null)
			{
					
			  AgregarItem(_articuloSeleccionado,  nudCantidad.Value);
					
		
			}

			LimpiarParaNuevoItem();
			CargarCuerpo();
			CargarPie();
			

		}

		public override void FormatearGrilla(DataGridView dgv)
		{
			base.FormatearGrilla(dgv);

			dgv.Columns["Codigo"].Visible = true;
			dgv.Columns["Codigo"].Width = 100;
			dgv.Columns["Codigo"].HeaderText = "Código";
			dgv.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			dgv.Columns["Descripcion"].Visible = true;
			dgv.Columns["Descripcion"].HeaderText = "Articulo";
			dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			

			dgv.Columns["PrecioStr"].Visible = true;
			dgv.Columns["PrecioStr"].Width = 120;
			dgv.Columns["PrecioStr"].HeaderText = "Precio";
			dgv.Columns["PrecioStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

			dgv.Columns["Cantidad"].Visible = true;
			dgv.Columns["Cantidad"].Width = 120;
			dgv.Columns["Cantidad"].HeaderText = "Cantidad";
			dgv.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			dgv.Columns["SubTotalStr"].Visible = true;
			dgv.Columns["SubTotalStr"].Width = 120;
			dgv.Columns["SubTotalStr"].HeaderText = "Sub-Total";
			dgv.Columns["SubTotalStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		}

		private void btnCambiarCantidad_Click(object sender, EventArgs e)
		{
			if (_itemSeleccionado == null) return;

			var respaldoSeleccionado = _itemSeleccionado;
			var respaldoCantidad = _itemSeleccionado.Cantidad;

			var cambiarCantidadItem = new CambiarCantidad(_itemSeleccionado);
			cambiarCantidadItem.ShowDialog();

			if (cambiarCantidadItem.Item != null)
			{
				var item = _factura.Items.FirstOrDefault(x => x.Id == cambiarCantidadItem.Item.Id);
				_factura.Items.Remove(item);

				if (cambiarCantidadItem.Item.Cantidad > 0)
				{
					_articuloSeleccionado = _articuloServicio.ObtenerPorCodigo(_itemSeleccionado.Codigo);

					nudCantidad.Value = cambiarCantidadItem.Item.Cantidad;
					btnAgregar.PerformClick();

					if (_cambiarCantidadError)
					{
						respaldoSeleccionado.Cantidad = respaldoCantidad;

						_factura.Items.Add(respaldoSeleccionado);
						_cambiarCantidadError = false;
					}

				}


			}

			LimpiarParaNuevoItem();
			CargarCuerpo();
		}

		private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvGrilla.RowCount > 0)
			{
				_itemSeleccionado = (ItemView)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
			}
			else
			{

				_itemSeleccionado = null;

			}
		}

		private void dgvGrilla_DoubleClick(object sender, EventArgs e)
		{

			if (dgvGrilla.RowCount > 0)
			{
				var cantidadRespaldo = _itemSeleccionado.Cantidad;

				var cambiarCantidadItem = new CambiarCantidad(_itemSeleccionado);
				cambiarCantidadItem.ShowDialog();


				if (cambiarCantidadItem.Item != null)
				{
					var item = _factura.Items.FirstOrDefault(x => x.Id == cambiarCantidadItem.Item.Id);
					_factura.Items.Remove(item);

					if (cambiarCantidadItem.Item.Cantidad > 0)
					{
						_articuloSeleccionado = _articuloServicio.ObtenerPorCodigo(_itemSeleccionado.Codigo);

						nudCantidad.Value = cambiarCantidadItem.Item.Cantidad;
						btnAgregar.PerformClick();

						if (_cambiarCantidadError)
						{
							_itemSeleccionado.Cantidad = cantidadRespaldo;

							_factura.Items.Add(_itemSeleccionado);
							_cambiarCantidadError = false;
						}

					}


				}

				CargarCuerpo();
				CargarPie();
				LimpiarParaNuevoItem();

			}

		}

		
	}
}
