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
            LblCelular1.Visible = false;
            TxtCelular1.Visible = false;
            LblCelular2.Visible = false;
            TxtCelular2.Visible = false;
            LblAltura.Visible = false;
            TxtAltura.Visible = false;
            LblMt.Visible = false;
            LblPeso.Visible = false;
            TxtPeso.Visible = false;
            LblKg.Visible = false;
            BtnActualizar.Visible = false;

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
            LblAltura.Visible = false;
            TxtAltura.Visible = false;
            LblMt.Visible = false;
            LblPeso.Visible = false;
            TxtPeso.Visible = false;
            LblKg.Visible = false;
            BtnActualizar.Visible = false;

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
            LblCelular1.Visible = true;
            TxtCelular1.Visible = true;
            LblCelular2.Visible = true;
            TxtCelular2.Visible = true;
            LblAltura.Visible = true;
            TxtAltura.Visible = true;
            LblMt.Visible = true;
            LblPeso.Visible = true;
            TxtPeso.Visible = true;
            LblKg.Visible = true;
            BtnActualizar.Visible = true;

            var respuesta = servicio.BuscarRegistro(TxtIdentificacion.Text);
            char sexo = respuesta.cliente.Sexo;
            if (!respuesta.Errror)
            {

                
                TxtIdentificacion.Text = respuesta.cliente.Identificacion;
                TxtPrimerNombre.Text = respuesta.cliente.PrimerNombre;
                TxtSegundoNombre.Text = respuesta.cliente.SegundoNombre;
                TxtPrimerApellido.Text = respuesta.cliente.PrimerApellido;
                TxtSegundoApellido.Text = respuesta.cliente.SegundoApellido;
                CbxSexo.SelectedItem = Convert.ToString(sexo);
                DTFecha.Value = respuesta.cliente.FechaNacimiento;
                TxtCelular1.Text = respuesta.cliente.Celular1;
                TxtCelular2.Text = respuesta.cliente.Celular2;
                TxtAltura.Text = Convert.ToString(respuesta.cliente.Altura);
                TxtPeso.Text = Convert.ToString(respuesta.cliente.Peso);

                


            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }


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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Double.TryParse(TxtAltura.Text, out double Altura);
            Double.TryParse(TxtPeso.Text, out double Peso);
            Char.TryParse(CbxSexo.Text, out char Sexo);
            DateTime.TryParse(DTFecha.Text, out DateTime Fecha);

            Clientes cliente = new Clientes()
            {

                Identificacion = TxtIdentificacion.Text,
                PrimerNombre = TxtPrimerNombre.Text,
                SegundoNombre = TxtSegundoNombre.Text,
                PrimerApellido = TxtPrimerApellido.Text, 
                SegundoApellido = TxtSegundoApellido.Text, 
                Sexo = Sexo,
                FechaNacimiento = Fecha,
                Celular1 = TxtCelular1.Text,
                Celular2 = TxtCelular2.Text,
                Altura = Altura,
                Peso = Peso,             
            };
            MessageBox.Show(servicio.Modificar(cliente, cliente.Identificacion));
        }
    }
}
