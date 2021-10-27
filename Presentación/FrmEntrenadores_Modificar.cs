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
    public partial class FrmEntrenadores_Modificar : Form
    {
        public FrmEntrenadores_Modificar()
        {
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
            LblCelular1.Visible = false;
            TxtCelular1.Visible = false;
            LblCelular2.Visible = false;
            TxtCelular2.Visible = false;
            LblSueldo.Visible = false;
            TxtSueldo.Visible = false;
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
        private void BtnCancelar_EntrenadoresModificar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
        }

        private void BtnGuardar_EntrenadoresModificar_Click(object sender, EventArgs e)
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
            LblCelular1.Visible = true;
            TxtCelular1.Visible = true;
            LblCelular2.Visible = true;
            TxtCelular2.Visible = true;
            LblSueldo.Visible = true;
            TxtSueldo.Visible = true;


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
