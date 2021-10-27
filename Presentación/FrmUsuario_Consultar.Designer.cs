
namespace Presentación
{
    partial class FrmUsuario_Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario_Consultar));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGuardar_UsuarioConsultar = new CustomControls.RJControls.RJButton();
            this.BtnCancelar_UsuarioConsultar = new CustomControls.RJControls.RJButton();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.DTClientes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(226, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese Identificación";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.DTClientes);
            this.panel1.Controls.Add(this.BtnGuardar_UsuarioConsultar);
            this.panel1.Controls.Add(this.BtnCancelar_UsuarioConsultar);
            this.panel1.Controls.Add(this.TxtIdentificacion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(193, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 534);
            this.panel1.TabIndex = 2;
            // 
            // BtnGuardar_UsuarioConsultar
            // 
            this.BtnGuardar_UsuarioConsultar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar_UsuarioConsultar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar_UsuarioConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuardar_UsuarioConsultar.BorderRadius = 3;
            this.BtnGuardar_UsuarioConsultar.BorderSize = 0;
            this.BtnGuardar_UsuarioConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar_UsuarioConsultar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar_UsuarioConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar_UsuarioConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar_UsuarioConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar_UsuarioConsultar.Location = new System.Drawing.Point(575, 494);
            this.BtnGuardar_UsuarioConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGuardar_UsuarioConsultar.Name = "BtnGuardar_UsuarioConsultar";
            this.BtnGuardar_UsuarioConsultar.Size = new System.Drawing.Size(115, 26);
            this.BtnGuardar_UsuarioConsultar.TabIndex = 18;
            this.BtnGuardar_UsuarioConsultar.Text = "Buscar";
            this.BtnGuardar_UsuarioConsultar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar_UsuarioConsultar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar_UsuarioConsultar
            // 
            this.BtnCancelar_UsuarioConsultar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_UsuarioConsultar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_UsuarioConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancelar_UsuarioConsultar.BorderRadius = 3;
            this.BtnCancelar_UsuarioConsultar.BorderSize = 0;
            this.BtnCancelar_UsuarioConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar_UsuarioConsultar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar_UsuarioConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar_UsuarioConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar_UsuarioConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar_UsuarioConsultar.Location = new System.Drawing.Point(19, 494);
            this.BtnCancelar_UsuarioConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar_UsuarioConsultar.Name = "BtnCancelar_UsuarioConsultar";
            this.BtnCancelar_UsuarioConsultar.Size = new System.Drawing.Size(115, 26);
            this.BtnCancelar_UsuarioConsultar.TabIndex = 17;
            this.BtnCancelar_UsuarioConsultar.Text = "Cancelar";
            this.BtnCancelar_UsuarioConsultar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar_UsuarioConsultar.UseVisualStyleBackColor = false;
            this.BtnCancelar_UsuarioConsultar.Click += new System.EventHandler(this.BtnCancelar_UsuarioConsultar_Click);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.Gray;
            this.TxtIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtIdentificacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(264, 118);
            this.TxtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(176, 27);
            this.TxtIdentificacion.TabIndex = 11;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 2;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(0, 641);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(1052, 17);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 2;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(-1, 0);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(704, 68);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "CONSULTA USUARIO";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // DTClientes
            // 
            this.DTClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTClientes.Location = new System.Drawing.Point(42, 171);
            this.DTClientes.Name = "DTClientes";
            this.DTClientes.RowHeadersWidth = 51;
            this.DTClientes.RowTemplate.Height = 24;
            this.DTClientes.Size = new System.Drawing.Size(619, 265);
            this.DTClientes.TabIndex = 19;
            // 
            // FrmUsuario_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1067, 736);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUsuario_Consultar";
            this.Text = "FrmUsuario_Consultar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.ErrorProvider error;
        private CustomControls.RJControls.RJButton BtnGuardar_UsuarioConsultar;
        private CustomControls.RJControls.RJButton BtnCancelar_UsuarioConsultar;
        private System.Windows.Forms.DataGridView DTClientes;
    }
}