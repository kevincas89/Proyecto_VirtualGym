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
    public partial class FrmPlanes_Modificar : Form
    {
        public FrmPlanes_Modificar()
        {
            InitializeComponent();
        }

        
        //LIMPIAR CAMPOS
        private void LimpiarCampos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c.Controls.Count > 0) LimpiarCampos(c);
            }
            TxtCodigoPlan.Focus();
        }


        //BOTONES CANCELAR Y BUSCAR
        private void BtnCancelar_PlanesModificar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
        }


        //VALIDANDO IDENTIFICACIÓN

        private void TxtCodigoPlan_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigoPlan.Text.Equals(""))
            {
                error.SetError(TxtCodigoPlan, "llena este campo");
                e.Cancel = true;
                TxtCodigoPlan.Select(0, TxtCodigoPlan.Text.Length);
            }
        }

        private void TxtIdentificacion_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtCodigoPlan, "");
        }




    }
}
