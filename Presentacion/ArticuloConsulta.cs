using FormularioBase;
using IServicios.Articulo;
using IServicios.Articulo.DTOs;
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
	public partial class ArticuloConsulta : FormConsulta
	{
		private readonly IArticuloServicio _articuloServicio;

		public ArticuloConsulta(IArticuloServicio articuloServicio)
		{
			InitializeComponent();

			_articuloServicio = articuloServicio;
		}

		public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
		{
			
			dgv.DataSource = _articuloServicio.Obtener(cadenaBuscar);

			base.ActualizarDatos(dgv, cadenaBuscar);
		}

		public override void FormatearGrilla(DataGridView dgv)
		{
			base.FormatearGrilla(dgv);

		
			dgv.Columns["Codigo"].Visible = true;
			dgv.Columns["Codigo"].Width = 70;
			dgv.Columns["Codigo"].HeaderText = "Código";
			dgv.Columns["Abreviatura"].Visible = true;
			dgv.Columns["Abreviatura"].Width = 100;
			dgv.Columns["Abreviatura"].HeaderText = "Abreviatura";
			dgv.Columns["Descripcion"].Visible = true;
			dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgv.Columns["Descripcion"].HeaderText = @"Descripción";
			dgv.Columns["Stock"].Visible = true;
			dgv.Columns["Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgv.Columns["Stock"].HeaderText = @"Stock";

			dgv.Columns["Precio"].Visible = true;
			dgv.Columns["Precio"].Width = 60;
			dgv.Columns["Precio"].HeaderText = "Precio";
			dgv.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		public override bool EjecutarComando(TipoOperacion tipoOperacion, long? id = null)
		{
			var form = new Abm_Articulos(tipoOperacion, id);
			form.ShowDialog();
			return form.RealizoAlgunaOperacion;
		}


	}
}
