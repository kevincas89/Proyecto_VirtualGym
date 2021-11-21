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
    public partial class FrmUsuario_Eliminar : Form
    {
        private ClienteService servicio;
        public FrmUsuario_Eliminar()
        {
            InitializeComponent();
            servicio = new ClienteService(ConfigConnection.connectionString);
            CargarTabla();
            BtnEliminar.Visible = false;
            DTClientes.Visible = false;
        }

        private void CargarTabla()
        {
            ClienteConsultaResponse response = servicio.Consultar();
            
            if (!response.Errror)
            {
                addsColumnas();
                foreach (var item in response.Clientes)
                {
                    DTClientes.Rows.Add(item.Identificacion, item.PrimerNombre, item.SegundoNombre,
                        item.PrimerApellido, item.SegundoApellido, item.Sexo, item.FechaNacimiento,
                        item.Celular1, item.Celular2, item.Peso, item.Altura,
                        item.IndiceMasaCorporal, item.plan.CodigoPlan, item.entrenador.Identificacion);
                }
            }
            else
            {
                MessageBox.Show(response.Mensaje);
            }
        }

        private void addsColumnas()
        {

            DTClientes.ColumnCount = 14;
            DTClientes.ColumnHeadersVisible = true;
            DTClientes.Columns[0].Name = "IdentificacionCliente";
            DTClientes.Columns[1].Name = "PrimerNombre";
            DTClientes.Columns[2].Name = "SegundoNombre";
            DTClientes.Columns[3].Name = "PrimerApellido";
            DTClientes.Columns[4].Name = "SegundoApellido";
            DTClientes.Columns[5].Name = "Sexo";
            DTClientes.Columns[6].Name = "FechaNacimiento";
            DTClientes.Columns[7].Name = "Telefono1";
            DTClientes.Columns[8].Name = "Telefono2";
            DTClientes.Columns[9].Name = "Peso";
            DTClientes.Columns[10].Name = "Altura";
            DTClientes.Columns[11].Name = "IMC";
            DTClientes.Columns[12].Name = "CodPlan";
            DTClientes.Columns[13].Name = "IdentificacionEntrenador";

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
            DTClientes.Visible = false;
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClienteConsultaResponse response = servicio.Consultar();
            var respuesta = servicio.BuscarRegistro(TxtIdentificacion.Text);           
            if (!respuesta.Errror)
            {
                foreach (var item in response.Clientes)
                {
                    if (TxtIdentificacion.Text.Equals(item.Identificacion))
                    {
                        DTClientes.Rows.Clear();
                        DTClientes.Rows.Add(item.Identificacion, item.PrimerNombre, item.SegundoNombre,
                        item.PrimerApellido, item.SegundoApellido, item.Sexo, item.FechaNacimiento,
                        item.Celular1, item.Celular2, item.Peso, item.Altura,
                        item.IndiceMasaCorporal, item.plan.CodigoPlan, item.entrenador.Identificacion);
                    }
                    
                }
                DTClientes.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = servicio.BuscarRegistro(TxtIdentificacion.Text);
            if (!respuesta.Errror)
            {               
                MessageBox.Show(servicio.EliminarCliente(TxtIdentificacion.Text));
            }
            
        }
    }
}
