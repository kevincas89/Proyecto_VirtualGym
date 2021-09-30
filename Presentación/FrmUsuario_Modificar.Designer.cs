
namespace Presentación
{
    partial class FrmUsuario_Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario_Modificar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnGuardar_UsuarioModificar = new CustomControls.RJControls.RJButton();
            this.BtnCancelar_UsuarioModificar = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnGuardar_UsuarioModificar);
            this.panel1.Controls.Add(this.BtnCancelar_UsuarioModificar);
            this.panel1.Controls.Add(this.TxtIdentificacion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(147, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 434);
            this.panel1.TabIndex = 3;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.Gray;
            this.TxtIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtIdentificacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(192, 151);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(133, 23);
            this.TxtIdentificacion.TabIndex = 10;
            this.TxtIdentificacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIdentificacion_Validating);
            this.TxtIdentificacion.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(154, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese Identificación";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // BtnGuardar_UsuarioModificar
            // 
            this.BtnGuardar_UsuarioModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar_UsuarioModificar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar_UsuarioModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuardar_UsuarioModificar.BorderRadius = 3;
            this.BtnGuardar_UsuarioModificar.BorderSize = 0;
            this.BtnGuardar_UsuarioModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar_UsuarioModificar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar_UsuarioModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar_UsuarioModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar_UsuarioModificar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar_UsuarioModificar.Location = new System.Drawing.Point(429, 400);
            this.BtnGuardar_UsuarioModificar.Name = "BtnGuardar_UsuarioModificar";
            this.BtnGuardar_UsuarioModificar.Size = new System.Drawing.Size(86, 21);
            this.BtnGuardar_UsuarioModificar.TabIndex = 16;
            this.BtnGuardar_UsuarioModificar.Text = "Buscar";
            this.BtnGuardar_UsuarioModificar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar_UsuarioModificar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar_UsuarioModificar
            // 
            this.BtnCancelar_UsuarioModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_UsuarioModificar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_UsuarioModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancelar_UsuarioModificar.BorderRadius = 3;
            this.BtnCancelar_UsuarioModificar.BorderSize = 0;
            this.BtnCancelar_UsuarioModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar_UsuarioModificar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar_UsuarioModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar_UsuarioModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar_UsuarioModificar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar_UsuarioModificar.Location = new System.Drawing.Point(12, 400);
            this.BtnCancelar_UsuarioModificar.Name = "BtnCancelar_UsuarioModificar";
            this.BtnCancelar_UsuarioModificar.Size = new System.Drawing.Size(86, 21);
            this.BtnCancelar_UsuarioModificar.TabIndex = 15;
            this.BtnCancelar_UsuarioModificar.Text = "Cancelar";
            this.BtnCancelar_UsuarioModificar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar_UsuarioModificar.UseVisualStyleBackColor = false;
            this.BtnCancelar_UsuarioModificar.Click += new System.EventHandler(this.BtnCancelar_UsuarioModificar_Click);
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
            this.rjButton2.Location = new System.Drawing.Point(0, 521);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(789, 14);
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
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(528, 55);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "MODIFICAR USUARIO";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // FrmUsuario_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario_Modificar";
            this.Text = "FrmUsuario_Modificar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.ErrorProvider error;
        private CustomControls.RJControls.RJButton BtnCancelar_UsuarioModificar;
        private CustomControls.RJControls.RJButton BtnGuardar_UsuarioModificar;
    }
}