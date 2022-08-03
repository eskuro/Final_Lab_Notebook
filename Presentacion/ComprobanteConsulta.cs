using FormularioBase;
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
    public partial class ComprobanteConsulta : FormBase
    {

        private readonly IFacturaServicio _facturaServicio;

        public ComprobanteConsulta(IFacturaServicio facturaServicio)
        {
            InitializeComponent();
            _facturaServicio = facturaServicio;

            dgvComprobantes.DataSource = new List<ComprobanteDto>();


            dgvComprobantes.DataSource = _facturaServicio.ObtenerComprobante();

            FormatearGrilla(dgvComprobantes);

        }


        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Id"].Visible = true;
            dgv.Columns["Id"].Width = 100;
            dgv.Columns["Id"].HeaderText = @"Numero Comprobante";

            dgv.Columns["Fecha"].Visible = true;
            dgv.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Fecha"].HeaderText = @"Fecha";

            dgv.Columns["Total"].Visible = true;
            dgv.Columns["Total"].Width = 150;
            dgv.Columns["Total"].HeaderText = @"Total";



        }


    }
}
