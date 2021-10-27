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
    public partial class FrmEntrenadores_Informe : Form
    {
        private EntrenadorService entrenador;
        public FrmEntrenadores_Informe()
        {
            InitializeComponent();
            entrenador = new EntrenadorService(ConfigConnection.connectionString);
            CargarTabla();
        }
        private void CargarTabla()
        {
            var respuesta = entrenador.ConsultarEntrenador();
            if (!respuesta.Errror)
            {
                DtgEntrenadores.DataSource = respuesta.Entrenador;
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
