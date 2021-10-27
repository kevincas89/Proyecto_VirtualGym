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
    public partial class FrmPlanes_Registrar : Form
    {
        PlanService service;
        
        public FrmPlanes_Registrar()
        {

            InitializeComponent();
            service = new PlanService(ConfigConnection.connectionString);

        }

        
       

        // LIMPIAR CAMPOS
        private void LimpiarCampos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c.Controls.Count > 0) LimpiarCampos(c);
            }
            TxtCodigoPlan.Focus();
        }


        //BOTONES CANCELAR Y GUARDAR
        private void BtnCancelar_PlanesRegistro_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
        }


        //VALIDANDO CODIGO DEL PLAN
        private void TxtCodigoPlan_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigoPlan.Text.Equals(""))
            {
                error.SetError(TxtCodigoPlan, "llena este campo");
                e.Cancel = true;
                TxtCodigoPlan.Select(0, TxtCodigoPlan.Text.Length);
            }
        }

        private void TxtCodigoPlan_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtCodigoPlan, "");
        }


        //VALIDANDO NOMBRE
        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (TxtNombre.Text.Equals(""))
            {
                error.SetError(TxtNombre, "llena este campo");
                e.Cancel = true;
                TxtNombre.Select(0, TxtNombre.Text.Length);
            }
        }

        private void TxtNombre_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtNombre, "");
        }

        //VALIDANDO VALOR DEL PLAN

        private bool ValidarCampoNumerico(string numero, out string mensaje)
        {
            if (numero.Equals(""))
            {
                mensaje = "Campo obligatorio";
                return false;
            }
            else
            {
                bool succes = double.TryParse(numero, out double result);
                if (!succes)
                {
                    mensaje = "No se admiten letras en un campo numerico";
                    return false;
                }
            }
            mensaje = "Campo validado correctamente";
            return true;
        }


        private void TxtValor_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoNumerico(TxtValor.Text, out string mensaje))
            {
                error.SetError(TxtValor, mensaje);
                e.Cancel = true;
                TxtValor.Select(0, TxtValor.Text.Length);
            }
        }

        private void TxtValor_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtValor, "");
        }

        //VALIDANDO DIAS

        private void TxtDias_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoNumerico(TxtDias.Text, out string mensaje))
            {
                error.SetError(TxtDias, mensaje);
                e.Cancel = true;
                TxtDias.Select(0, TxtDias.Text.Length);
            }
        }

        private void TxtDias_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtDias, "");
        }

        private void BtnGuardar_PlanesRegistro_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Int32.TryParse(TxtDias.Text,out int Dias);
                Int32.TryParse(TxtValor.Text, out int Valor);

                Planes plan = new Planes()
                {
                    CodigoPlan = TxtCodigoPlan.Text,
                    Nombre = TxtNombre.Text,
                    ValorPlan = Valor,
                    Dias = Dias
                };
                MessageBox.Show(service.regitrarPlan(plan));
                LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Verifique los campos.");
            }
        }
    }
}
