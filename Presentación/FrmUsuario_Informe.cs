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

        private void addsColumnas()
        {
            
            DtgUsuarios.ColumnCount = 14;
            DtgUsuarios.ColumnHeadersVisible = true;                        
            DtgUsuarios.Columns[0].Name = "IdentificacionCliente";
            DtgUsuarios.Columns[1].Name = "PrimerNombre";
            DtgUsuarios.Columns[2].Name = "SegundoNombre";
            DtgUsuarios.Columns[3].Name = "PrimerApellido";
            DtgUsuarios.Columns[4].Name = "SegundoApellido";
            DtgUsuarios.Columns[5].Name = "Sexo";
            DtgUsuarios.Columns[6].Name = "FechaNacimiento";
            DtgUsuarios.Columns[7].Name = "Telefono1";
            DtgUsuarios.Columns[8].Name = "Telefono2";
            DtgUsuarios.Columns[9].Name = "Peso";
            DtgUsuarios.Columns[10].Name = "Altura";
            DtgUsuarios.Columns[11].Name = "IMC";
            DtgUsuarios.Columns[12].Name = "CodPlan";
            DtgUsuarios.Columns[13].Name = "IdentificacionEntrenador";
            
        }
        
        private void CargarTabla()
        {
            ClienteConsultaResponse response = cliente.Consultar();

            if (!response.Errror)
            {
                addsColumnas();
                foreach (var item in response.Clientes)
                {
                    DtgUsuarios.Rows.Add(item.Identificacion, item.PrimerNombre, item.SegundoNombre,
                        item.PrimerApellido,item.SegundoApellido,item.Sexo,item.FechaNacimiento,
                        item.Celular1, item.Celular2, item.Peso, item.Altura,
                        item.IndiceMasaCorporal,item.plan.CodigoPlan,item.entrenador.Identificacion);
                }

            }
            else { MessageBox.Show(response.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ConfigurarGrid()
        {
            // Create an unbound DataGridView by declaring a column count.
            DtgUsuarios.ColumnCount = 7;
            DtgUsuarios.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);
            DtgUsuarios.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DtgUsuarios.Rows.Clear();
            CargarTabla();
            
        }
    }
}
