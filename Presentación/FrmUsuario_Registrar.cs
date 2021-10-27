﻿using Entidad;
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
    public partial class FrmUsuario_Registrar : Form
    {
        ClienteService service;
        PlanService plan;
        List<Planes> planes = new List<Planes>();
        public FrmUsuario_Registrar()
        {
            InitializeComponent();
            plan = new PlanService(ConfigConnection.connectionString);
            service = new ClienteService(ConfigConnection.connectionString);
            CargarCombo();
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

        private void BtnCancelar_UsuarioRegistro_Click(object sender, EventArgs e)
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


        //VALIDANDO EDAD

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

        //VALIDANDO CELULAR
        private void TxtCelular_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoNumerico(TxtCelular.Text, out string mensaje))
            {
                error.SetError(TxtCelular, mensaje);
                e.Cancel = true;
                TxtCelular.Select(0, TxtCelular.Text.Length);
            }
        }

        private void TxtCelular_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtCelular, "");
        }


        //VALIDANDO ALTURA
        private void TxtAltura_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoNumerico(TxtAltura.Text, out string mensaje))
            {
                error.SetError(TxtAltura, mensaje);
                e.Cancel = true;
                TxtAltura.Select(0, TxtAltura.Text.Length);
            }
        }

        private void TxtAltura_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtAltura, "");
        }


        //VALIDANDO PESO
        private void TxtPeso_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoNumerico(TxtPeso.Text, out string mensaje))
            {
                error.SetError(TxtPeso, mensaje);
                e.Cancel = true;
                TxtPeso.Select(0, TxtPeso.Text.Length);
            }
        }

        private void TxtPeso_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtPeso, "");
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

        private void BtnGuardar_UsuarioRegistro_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Char.TryParse(CbxSexo.Text, out char Sexo);
                DateTime.TryParse(DTFecha.Text, out DateTime Fecha);
                Double.TryParse(TxtAltura.Text, out double Altura);
                Double.TryParse(TxtPeso.Text, out double Peso);


                Clientes cliente = new Clientes();


                    cliente.Identificacion = TxtIdentificacion.Text;
                    cliente.PrimerNombre = TxtNombre.Text;
                    cliente.PrimerApellido = TxtApellido.Text;
                    cliente.Sexo = Sexo; cliente.FechaNacimiento = Fecha;
                    cliente.Celular1 = TxtCelular.Text;
                    cliente.Altura = Altura;
                    cliente.Peso = Peso;
                     if (planes != null)
                     {
                        foreach (var item in planes)
                        {
                            if (item.Nombre.Equals(CbxPlanes.Text))
                            {
                                cliente.plan = item;
                                MessageBox.Show(service.regitrarUsuario(cliente));
                                LimpiarCampos(this);
                            }
                        }
                     }
                      else
                      {
                           MessageBox.Show("No se pudo guardar esta Cliente");
                      }
                                      
            }
            else
            {
                MessageBox.Show("Verifique los campos.");
            }
        }

        private void CargarCombo()
        {
            var respuesta = plan.Consultar();
            
            if (!respuesta.Errror)
            {
                planes = respuesta.Planes;
                foreach (var item in planes)
                {
                    CbxPlanes.Items.Add(item.Nombre);
                }
                
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

    }
}
