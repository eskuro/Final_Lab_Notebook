using FormularioBase;
using Presentacion;
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

namespace Principal
{
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
		}

		private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var fconsultaArticulo = ObjectFactory.GetInstance<ArticuloConsulta>();

			AgregarFormulario(fconsultaArticulo);
		}


		private void AgregarFormulario(object form)
		{
			if (this.panelContenedor.Controls.Count > 0)
				this.panelContenedor.Controls.RemoveAt(0);
			Form fh = form as Form;

			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;

			this.panelContenedor.Controls.Add(fh);
			this.panelContenedor.Tag = fh;
			fh.Show();
		}

		private void creToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var nuevoArticulo = new Abm_Articulos(TipoOperacion.Nuevo);

			AgregarFormulario(nuevoArticulo);
		}

		private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var consultaRubro = ObjectFactory.GetInstance<RubroConsulta>();

			AgregarFormulario(consultaRubro);
		}

		private void nuevoRubroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var nuevoRubro = new Abm_Rubro(TipoOperacion.Nuevo);

			AgregarFormulario(nuevoRubro);
		}

		private void generarVentaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ObjectFactory.GetInstance<Venta>().Show();
		}

        private void comprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ObjectFactory.GetInstance<ComprobanteConsulta>().Show();
		}
    }
}
