using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FrmEntrenadores_Eliminar : Form
    {
        private EntrenadorService servicio;
        public FrmEntrenadores_Eliminar()
        {
            InitializeComponent();
            servicio = new EntrenadorService(ConfigConnection.connectionString);
            CargarTabla();
            DTEntrenador.Visible = false;
            BtnEliminar.Visible = false;
        }


        //LIMPIAR CAMPOS

        private void LimpiarCampos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c.Controls.Count > 0) LimpiarCampos(c);
            }
            TxtIdentificacion.Focus();
        }

        //BOTONES CANCELAR Y BUSCAR

        private void BtnCancelar_UsuarioConsultar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
            DTEntrenador.Visible = false;
            BtnEliminar.Visible = false;
        }


        //VALIDANDO IDENTIFICACIÓN

        private void TxtIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            if (TxtIdentificacion.Text.Equals(""))
            {
                error.SetError(TxtIdentificacion, "llena este campo");
                e.Cancel = true;
                TxtIdentificacion.Select(0, TxtIdentificacion.Text.Length);
            }
        }

        private void TxtIdentificacion_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtIdentificacion, "");
        }

        private void CargarTabla()
        {
            EntrenadorConsultaResponse response = servicio.ConsultarEntrenador();

            if (!response.Errror)
            {
                addsColumnas();
                foreach (var item in response.Entrenador)
                {
                    DTEntrenador.Rows.Add(item.Identificacion, item.PrimerNombre, item.SegundoNombre,
                        item.PrimerApellido, item.SegundoApellido, item.Sexo, item.FechaNacimiento,
                        item.Celular1, item.Celular2, item.Sueldo);
                }
            }
            else
            {
                MessageBox.Show(response.Mensaje);
            }
        }

        private void addsColumnas()
        {

            DTEntrenador.ColumnCount = 10;
            DTEntrenador.ColumnHeadersVisible = true;
            DTEntrenador.Columns[0].Name = "IdentificacionEntrenador";
            DTEntrenador.Columns[1].Name = "PrimerNombre";
            DTEntrenador.Columns[2].Name = "SegundoNombre";
            DTEntrenador.Columns[3].Name = "PrimerApellido";
            DTEntrenador.Columns[4].Name = "SegundoApellido";
            DTEntrenador.Columns[5].Name = "Sexo";
            DTEntrenador.Columns[6].Name = "FechaNacimiento";
            DTEntrenador.Columns[7].Name = "Telefono1";
            DTEntrenador.Columns[8].Name = "Telefono2";
            DTEntrenador.Columns[9].Name = "Sueldo";         

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = servicio.BuscarRegistro(TxtIdentificacion.Text);
            if (!respuesta.Errror)
            {
                MessageBox.Show(servicio.EliminarEntrenador(TxtIdentificacion.Text));
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            EntrenadorConsultaResponse response = servicio.ConsultarEntrenador();
            var respuesta = servicio.BuscarRegistro(TxtIdentificacion.Text);
            if (!respuesta.Errror)
            {
                foreach (var item in response.Entrenador)
                {
                    if (TxtIdentificacion.Text.Equals(item.Identificacion))
                    {
                        DTEntrenador.Rows.Clear();
                        DTEntrenador.Rows.Add(item.Identificacion, item.PrimerNombre, item.SegundoNombre,
                        item.PrimerApellido, item.SegundoApellido, item.Sexo, item.FechaNacimiento,
                        item.Celular1, item.Celular2, item.Sueldo);
                    }

                }
                DTEntrenador.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }
    }
}
