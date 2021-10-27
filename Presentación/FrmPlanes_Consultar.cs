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

    public partial class FrmPlanes_Consultar : Form
    {
        private PlanService plan;

        public FrmPlanes_Consultar()
        {
            plan = new PlanService(ConfigConnection.connectionString);
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            var respuesta = plan.Consultar();
            if (!respuesta.Errror)
            {
                DtgPlanes.DataSource = respuesta.Planes;
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
