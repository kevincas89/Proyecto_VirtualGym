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
    public partial class FrmEntrenadores_Registrar : Form
    {
        EntrenadorService entrenadores;
        public FrmEntrenadores_Registrar()
        {
            InitializeComponent();
            entrenadores = new EntrenadorService(ConfigConnection.connectionString);

        }


        // LIMPIAR CAMPOS
        private void LimpiarCampos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c.Controls.Count > 0) LimpiarCampos(c);
            }
            TxtIdentificacion.Focus();
        }


        //BOTONES CANCELAR Y GUARDAR

        private void BtnCancelar_EntrenadoresRegistro_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
        }


        //VALIDANDO IDENTIFACIÓN
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


        //VALIDANDO APELLIDOS

        private void TxtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (TxtApellido.Text.Equals(""))
            {
                error.SetError(TxtApellido, "llena este campo");
                e.Cancel = true;
                TxtApellido.Select(0, TxtApellido.Text.Length);
            }
        }

        private void TxtApellido_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtApellido, "");
        }


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

        //VALIDANDO SUELDO
        private void TxtSueldo_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoNumerico(TxtSueldo.Text, out string mensaje))
            {
                error.SetError(TxtSueldo, mensaje);
                e.Cancel = true;
                TxtSueldo.Select(0, TxtSueldo.Text.Length);
            }
        }

        private void TxtSueldo_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtSueldo, "");
        }

        //VALIDANDO SEXO
        private void CbxSexo_Validating(object sender, CancelEventArgs e)
        {
            if (CbxSexo.Text.Equals(""))
            {
                error.SetError(CbxSexo, "llena este campo");
                e.Cancel = true;
                CbxSexo.Select(0, CbxSexo.Text.Length);
            }
        }

        private void CbxSexo_Validated(object sender, EventArgs e)
        {
            error.SetError(CbxSexo, "");
        }


        private void BtnGuardar_EntrenadoresRegistro_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Char.TryParse(CbxSexo.Text, out char Sexo);
                DateTime.TryParse(DTFecha.Text, out DateTime Fecha);
                Double.TryParse(TxtSueldo.Text,out double Sueldo);

                Entrenador entrenador = new Entrenador();

                entrenador.Identificacion = TxtIdentificacion.Text;
                entrenador.PrimerNombre = TxtNombre.Text;
                entrenador.PrimerApellido = TxtApellido.Text;
                entrenador.Sexo = Sexo; entrenador.FechaNacimiento = Fecha;
                entrenador.Celular1 = TxtCelular1.Text;
                entrenador.Sueldo = Sueldo;
                
                MessageBox.Show(entrenadores.regitrarEntrenador(entrenador));         
                LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Verifique los campos.");
            }

        }
    }
}


