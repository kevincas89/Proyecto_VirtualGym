using Entidad;
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
    public partial class FrmUsuario_Modificar : Form
    {
        private ClienteService servicio;
        public FrmUsuario_Modificar()
        {
            servicio = new ClienteService(ConfigConnection.connectionString);
            InitializeComponent();
            LblPrimerNombre.Visible = false;
            TxtPrimerNombre.Visible = false;
            LblSegundoNombre.Visible = false;
            TxtSegundoNombre.Visible = false;
            LblPrimerApellido.Visible = false;
            TxtPrimerApellido.Visible = false;
            LblSegundoApellido.Visible = false;
            TxtSegundoApellido.Visible = false;
            LblSexo.Visible = false;
            CbxSexo.Visible = false;
            LblFechaDeNacimiento.Visible = false;
            DTFecha.Visible = false;
            LblCelular.Visible = false;
            TxtCelular.Visible = false;
            LblAltura.Visible = false;
            TxtAltura.Visible = false;
            LblMt.Visible = false;
            LblPeso.Visible = false;
            TxtPeso.Visible = false;
            LblKg.Visible = false;

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
        private void BtnCancelar_UsuarioModificar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
        }

        private void BtnGuardar_UsuarioModificar_Click(object sender, EventArgs e)
        {
            LblPrimerNombre.Visible = true;
            TxtPrimerNombre.Visible = true;
            LblSegundoNombre.Visible = true;
            TxtSegundoNombre.Visible = true;
            LblPrimerApellido.Visible = true;
            TxtPrimerApellido.Visible = true;
            LblSegundoApellido.Visible = true;
            TxtSegundoApellido.Visible = true;
            LblSexo.Visible = true;
            CbxSexo.Visible = true;
            LblFechaDeNacimiento.Visible = true;
            DTFecha.Visible = true;
            LblCelular.Visible = true;
            TxtCelular.Visible = true;
            LblAltura.Visible = true;
            TxtAltura.Visible = true;
            LblMt.Visible = true;
            LblPeso.Visible = true;
            TxtPeso.Visible = true;
            LblKg.Visible = true;

            /*TxtPrimerNombre.Text = Cliente.;
            TxtNombre.Text = plan.Nombre;
            TxtValor.Text = Convert.ToString(plan.ValorPlan);
            TxtDuracion.Text = Convert.ToString(plan.Dias);*/


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
