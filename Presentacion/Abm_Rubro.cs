using FormularioBase;
using IServicios.Rubro;
using IServicios.Rubro.DTOs;
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
	public partial class Abm_Rubro : FormAbm
	{
        private readonly IRubroServicio _rubroServicio;

        public Abm_Rubro(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _rubroServicio = ObjectFactory.GetInstance<IRubroServicio>();
            CargarDatos(entidadId);
        }

        public override void CargarDatos(long? entidadId)
        {
            base.CargarDatos(entidadId);

            if (entidadId.HasValue)
            {
                var resultado = (RubroDto)_rubroServicio.Obtener(entidadId.Value);

                if (resultado == null)
                {
                    MessageBox.Show("Ocurrio un error al obtener el registro seleccionado");
                    Close();
                }

                txtDescripcion.Text = resultado.Descripcion;

                if (TipoOperacion == TipoOperacion.Eliminar)
                    DesactivarControles(this);
            }
            else // Nuevo
            {
                btnEjecutar.Text = "Nuevo";
            }
        }

        public override bool VerificarSiExiste(long? id = null)
        {
            return _rubroServicio.VerificarSiExiste(txtDescripcion.Text, id);
        }

        public override bool VerificarDatosObligatorios()
        {
            return !string.IsNullOrEmpty(txtDescripcion.Text);
        }

      
        public override void EjecutarComandoNuevo()
        {
            var nuevoRegistro = new RubroDto();
            nuevoRegistro.Descripcion = txtDescripcion.Text;
            nuevoRegistro.EstaEliminado = false;

            _rubroServicio.Insertar(nuevoRegistro);
        }

        public override void EjecutarComandoModificar()
        {
            var modificarRegistro = new RubroDto();
            modificarRegistro.Id = EntidadId.Value;
            modificarRegistro.Descripcion = txtDescripcion.Text;
            modificarRegistro.EstaEliminado = false;

            _rubroServicio.Modificar(modificarRegistro);
        }


        public override void EjecutarComandoEliminar()
        {

            _rubroServicio.Eliminar(EntidadId.Value);
        }

        public override void LimpiarControles(Form formulario)
        {
            base.LimpiarControles(formulario);

            txtDescripcion.Focus();
        }

		
	}
}
