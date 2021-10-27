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
    public partial class FrmUsuario_Consultar : Form
    {
        private ClienteService cliente;
        public FrmUsuario_Consultar()
        {
            InitializeComponent();
            cliente = new ClienteService(ConfigConnection.connectionString);
            CargarTabla();
        }

        private void CargarTabla()
        {
            var respuesta = cliente.Consultar();
            if (!respuesta.Errror)
            {
                DTClientes.DataSource = respuesta.Clientes;
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
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

        
    }
}
