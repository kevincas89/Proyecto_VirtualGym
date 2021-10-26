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
    public partial class FrmPlanes_Modificar : Form
    {
        private PlanService servicio;
        public FrmPlanes_Modificar()
        {
            servicio = new PlanService(ConfigConnection.connectionString);
            InitializeComponent();
            CargarTabla();

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

        private void DtgPlanes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario plan = (Usuario)DtgPlanes.CurrentRow.DataBoundItem;
            TxtCodigoPlan.Text = plan.CodigoPlan;
            TxtNombre.Text = plan.Nombre;
            TxtValor.Text = Convert.ToString(plan.ValorPlan);
            TxtDuracion.Text =Convert.ToString(plan.Dias);
        }

        private void CargarTabla()
        {
            var respuesta = servicio.Consultar();
            if (!respuesta.Errror)
            {
                DtgPlanes.DataSource = respuesta.Planes;
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Int32.TryParse(TxtDuracion.Text, out int Dias);
            Int32.TryParse(TxtValor.Text, out int Valor);

            Usuario plan = new Usuario()
            {
                CodigoPlan = TxtCodigoPlan.Text,
                Nombre = TxtNombre.Text,
                ValorPlan = Valor,
                Dias = Dias
            };
            MessageBox.Show(servicio.Modificar(plan,plan.CodigoPlan));
           
        }
    }
}
