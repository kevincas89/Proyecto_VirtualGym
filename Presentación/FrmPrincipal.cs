using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentación
{
    public partial class FrmPrincipal : Form
    {

        // POSICIÓN INICIAL DE LOS BOTONES
        public FrmPrincipal()
        {
            InitializeComponent();
            AbrirFormHijo(new FrmInicio());
            BtnEntrenadores.Location = new Point(4, 170);
            panel_entrenadores.Location = new Point(0, 170);
            SubMenuEntrenadores.Location = new Point(48, 200);
            BtnPlanes.Location = new Point(5, 215);
            PanelPlanes.Location = new Point(0, 215);
            SubMenuEntrenadores.Visible = false;
            SubMenuPalnes.Visible = false;
            BtnContabilidad.Location = new Point(3, 258);
            PanelContabilidad.Location = new Point(0, 258);
        }

        private void PosicionInicial()
        {
            BtnPlanes.Location = new Point(5, 215);
            PanelPlanes.Location = new Point(0, 215);
            SubMenuPalnes.Location = new Point(48, 250);
            BtnEntrenadores.Location = new Point(4, 170);
            panel_entrenadores.Location = new Point(0, 170);
            SubMenuEntrenadores.Location = new Point(48, 200);
            BtnContabilidad.Location = new Point(3, 258);
            PanelContabilidad.Location = new Point(0, 258);
        }


        //ABRIR SUBVENTANAS

        private Form frmActual = null;
        private void AbrirFormHijo(Form frmHijo)
        {
            if (frmActual != null)
            {
                if (frmActual.GetType() != frmHijo.GetType())
                {
                    frmActual.Close();
                    frmActual = frmHijo;
                    frmHijo.TopLevel = false;
                    frmHijo.Dock = DockStyle.Fill;
                    PnlCentral.Controls.Add(frmHijo);
                    PnlCentral.Tag = frmHijo;
                    frmHijo.BringToFront();
                    frmHijo.Show();
                }
            }
            else
            {
                frmActual = frmHijo;
                frmHijo.TopLevel = false;
                frmHijo.Dock = DockStyle.Fill;
                PnlCentral.Controls.Add(frmHijo);
                PnlCentral.Tag = frmHijo;
                frmHijo.BringToFront();
                frmHijo.Show();
            }
        }


        //FUNCIONES DEL PANEL

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr wMsg, int wParam, int lParam, int v);

        private void PnlBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       private void BtnInicio_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmInicio());
        }

        


        //USUARIOS FUNCIONES

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {


            if (SubMenuUsuarios.Visible)
            {
                SubMenuUsuarios.Visible = false;
                PosicionInicial();
            }
            else
            {
                SubMenuUsuarios.Visible = true;
                SubMenuEntrenadores.Visible = false;
                SubMenuPalnes.Visible = false;
                BtnEntrenadores.Location = new Point(4, 295);
                panel_entrenadores.Location = new Point(0, 295);
                SubMenuEntrenadores.Location = new Point(44, 330);
                BtnPlanes.Location = new Point(5, 340);
                PanelPlanes.Location = new Point(0, 340);
                BtnContabilidad.Location = new Point(3, 383);
                PanelContabilidad.Location = new Point(0, 383);
            }
        }

        private void BtnUsuario_registrar_Click(object sender, EventArgs e)
        {
             SubMenuUsuarios.Visible = false;
             AbrirFormHijo(new FrmUsuario_Registrar());
             PosicionInicial();
        }

        private void BtnUsuarios_consultar_Click(object sender, EventArgs e)
        {

            SubMenuUsuarios.Visible = false;
            AbrirFormHijo(new FrmUsuario_Eliminar());
            PosicionInicial();
        }

        private void BtnUsuarios_informe_Click(object sender, EventArgs e)
        {

            SubMenuUsuarios.Visible = false;
            AbrirFormHijo(new FrmUsuario_Informe());
            PosicionInicial();
        }

        private void BtnUsuarios_modificar_Click(object sender, EventArgs e)
        {

            SubMenuUsuarios.Visible = false;
            AbrirFormHijo(new FrmUsuario_Modificar());
            PosicionInicial();
        }

        //ENTRENADORES FUNCIONES

        private void BtnEntrenadores_Click(object sender, EventArgs e)
        {

            if (SubMenuEntrenadores.Visible)
            {
                SubMenuEntrenadores.Visible = false;
                PosicionInicial();
            }
            else
            {
                SubMenuEntrenadores.Visible = true;
                SubMenuUsuarios.Visible = false;
                SubMenuPalnes.Visible = false;
                BtnEntrenadores.Location = new Point(4, 170);
                panel_entrenadores.Location = new Point(0, 170);
                SubMenuEntrenadores.Location = new Point(48, 200);
                BtnPlanes.Location = new Point(5, 340);
                PanelPlanes.Location = new Point(0, 340);
                BtnContabilidad.Location = new Point(3, 383);
                PanelContabilidad.Location = new Point(0, 383);

            }

        }

        private void BtnEntrenadores_registrar_Click(object sender, EventArgs e)
        {
            SubMenuEntrenadores.Visible = false;
            AbrirFormHijo(new FrmEntrenadores_Registrar());
            PosicionInicial();
        }

        private void BtnEntrenadores_consultar_Click(object sender, EventArgs e)
        {
            SubMenuEntrenadores.Visible = false;
            AbrirFormHijo(new FrmEntrenadores_Eliminar());
            PosicionInicial();
        }

        private void BtnEntrenadores_informe_Click(object sender, EventArgs e)
        {
            SubMenuEntrenadores.Visible = false;
            AbrirFormHijo(new FrmEntrenadores_Informe());
            PosicionInicial();
        }

        private void BtnEntrenadores_modificar_Click(object sender, EventArgs e)
        {
            SubMenuEntrenadores.Visible = false;
            AbrirFormHijo(new FrmEntrenadores_Modificar());
            PosicionInicial();
        }

        //PLANES FUNCIONES

        private void BtnPlanes_Click(object sender, EventArgs e)
        {
            if (SubMenuPalnes.Visible)
            {
                SubMenuPalnes.Visible = false;
                PosicionInicial();
            }
            else
            {
                SubMenuPalnes.Visible = true;
                SubMenuUsuarios.Visible = false;
                SubMenuEntrenadores.Visible = false;
                BtnPlanes.Location = new Point(5, 215);
                PanelPlanes.Location = new Point(0, 215);
                SubMenuPalnes.Location = new Point(48, 250);
                BtnContabilidad.Location = new Point(3, 350);
                PanelContabilidad.Location = new Point(0, 350);
                panel_entrenadores.Location = new Point(0, 170);
                SubMenuEntrenadores.Location = new Point(48, 200);
                BtnEntrenadores.Location = new Point(5, 170);
            }
        }

        private void BtnPlanes_registrar_Click(object sender, EventArgs e)
        {
            SubMenuPalnes.Visible = false;
            AbrirFormHijo(new FrmPlanes_Registrar());
            PosicionInicial();
        }

        private void BtnPlanes_consultar_Click(object sender, EventArgs e)
        {
            SubMenuPalnes.Visible = false;
            AbrirFormHijo(new FrmPlanes_Consultar());
            PosicionInicial();
        }

        private void BtnPlanes_modificar_Click(object sender, EventArgs e)
        {
            SubMenuPalnes.Visible = false;
            AbrirFormHijo(new FrmPlanes_Modificar());
            PosicionInicial();
        }


        //CONTABILIDAD FUNCIONES

        private void BtnContabilidad_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmContabilidad());
            SubMenuEntrenadores.Visible = false;
            SubMenuUsuarios.Visible = false;
            SubMenuPalnes.Visible = false;
            PosicionInicial();
        }

        
    }
}
