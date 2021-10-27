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
    public partial class FrmUsuario_Informe : Form
    {
        private ClienteService cliente;
        public FrmUsuario_Informe()
        {
            InitializeComponent();
            cliente = new ClienteService(ConfigConnection.connectionString);
            CargarTabla();
        }

        private void CargarTabla()
        {
            var respuesta = cliente.Consultar();
            if (!respuesta.Errror)
            {
                DtgUsuario.DataSource = respuesta.Clientes;
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
