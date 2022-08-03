using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioBase
{
	public partial class FormLookUp : FormBase
	{

		private long? entidadId;
		public object EntidadSeleccionada;
		public FormLookUp()
		{
			InitializeComponent();
			
		}

		private void FormLookUp_Load(object sender, EventArgs e)
		{
			ActualizarDatos(dgvGrilla, string.Empty);
		}
		public virtual void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
		{
			FormatearGrilla(dgv);
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			ActualizarDatos(dgvGrilla, txtBuscar.Text);
		}

		private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				// Tecla Enter
				case (char)Keys.Enter when !string.IsNullOrEmpty(txtBuscar.Text):
					btnBuscar.PerformClick();
					break;
				case (char)Keys.Enter:
					EntidadSeleccionada = null;
					Close();
					break;
				// Tecla Escape
				case (char)Keys.Escape:
					EntidadSeleccionada = null;
					Close();
					break;
			}
		}

		private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvGrilla.RowCount <= 0) return;

			entidadId = (long)dgvGrilla["Id", e.RowIndex].Value;

			// Obtener el Objeto completo seleccionado
			EntidadSeleccionada = dgvGrilla.Rows[e.RowIndex].DataBoundItem;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			EntidadSeleccionada = null;
			this.Close();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			ActualizarDatos(dgvGrilla, string.Empty);
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvGrilla_DoubleClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvGrilla_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				// Tecla Escape
				case Keys.Escape:
					EntidadSeleccionada = null;
					Close();
					break;
				// Tecla Enter
				case Keys.Enter:
					Close();
					break;
			}
		}
	}
}
