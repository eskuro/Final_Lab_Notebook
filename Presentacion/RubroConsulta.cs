using FormularioBase;
using IServicios.Rubro;
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
	public partial class RubroConsulta : FormConsulta
	{
		private readonly IRubroServicio _rubroServicio;

		public RubroConsulta(IRubroServicio rubroServicio)
		{
			InitializeComponent();
			_rubroServicio = rubroServicio;
		}

		public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
		{
			dgv.DataSource = _rubroServicio.Obtener(cadenaBuscar);

			base.ActualizarDatos(dgv, cadenaBuscar);
		}

		public override void FormatearGrilla(DataGridView dgv)
		{
			base.FormatearGrilla(dgv); // Pongo Invisible las Columnas

			dgv.Columns["Descripcion"].Visible = true;
			dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgv.Columns["Descripcion"].HeaderText = @"Descripción";

			
		}


		public override bool EjecutarComando(TipoOperacion tipoOperacion, long? id = null)
		{
			var form = new Abm_Rubro(tipoOperacion, id);
			form.ShowDialog();
			

			return form.RealizoAlgunaOperacion;
		}
	}
}

