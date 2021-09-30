
namespace Presentación
{
    partial class FrmUsuario_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario_Registrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.CbxPlanes = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnGuardar_UsuarioRegistro = new CustomControls.RJControls.RJButton();
            this.BtnCancelar_UsuarioRegistro = new CustomControls.RJControls.RJButton();
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
            this.panel1.Controls.Add(this.BtnGuardar_UsuarioRegistro);
            this.panel1.Controls.Add(this.BtnCancelar_UsuarioRegistro);
            this.panel1.Controls.Add(this.CbxPlanes);
            this.panel1.Controls.Add(this.TxtCelular);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.TxtEdad);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.TxtIdentificacion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(147, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 434);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(26, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Plan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(26, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.Gray;
            this.TxtIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtIdentificacion.Location = new System.Drawing.Point(182, 86);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(133, 23);
            this.TxtIdentificacion.TabIndex = 9;
            this.TxtIdentificacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIdentificacion_Validating);
            this.TxtIdentificacion.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.Gray;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtNombre.Location = new System.Drawing.Point(182, 130);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(275, 23);
            this.TxtNombre.TabIndex = 10;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            this.TxtNombre.Validated += new System.EventHandler(this.TxtNombre_Validated);
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.Gray;
            this.TxtApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtApellido.Location = new System.Drawing.Point(182, 174);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(275, 23);
            this.TxtApellido.TabIndex = 10;
            this.TxtApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellido_Validating);
            this.TxtApellido.Validated += new System.EventHandler(this.TxtApellido_Validated);
            // 
            // TxtEdad
            // 
            this.TxtEdad.BackColor = System.Drawing.Color.Gray;
            this.TxtEdad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtEdad.Location = new System.Drawing.Point(182, 217);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(36, 23);
            this.TxtEdad.TabIndex = 10;
            this.TxtEdad.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEdad_Validating);
            this.TxtEdad.Validated += new System.EventHandler(this.TxtEdad_Validated);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.Gray;
            this.TxtDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtDireccion.Location = new System.Drawing.Point(182, 262);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(275, 23);
            this.TxtDireccion.TabIndex = 11;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            this.TxtDireccion.Validated += new System.EventHandler(this.TxtDireccion_Validated);
            // 
            // TxtCelular
            // 
            this.TxtCelular.BackColor = System.Drawing.Color.Gray;
            this.TxtCelular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtCelular.Location = new System.Drawing.Point(182, 306);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(133, 23);
            this.TxtCelular.TabIndex = 12;
            this.TxtCelular.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCelular_Validating);
            this.TxtCelular.Validated += new System.EventHandler(this.TxtCelular_Validated);
            // 
            // CbxPlanes
            // 
            this.CbxPlanes.BackColor = System.Drawing.Color.Gray;
            this.CbxPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxPlanes.FormattingEnabled = true;
            this.CbxPlanes.Location = new System.Drawing.Point(182, 348);
            this.CbxPlanes.Name = "CbxPlanes";
            this.CbxPlanes.Size = new System.Drawing.Size(133, 24);
            this.CbxPlanes.TabIndex = 13;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // BtnGuardar_UsuarioRegistro
            // 
            this.BtnGuardar_UsuarioRegistro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar_UsuarioRegistro.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar_UsuarioRegistro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuardar_UsuarioRegistro.BorderRadius = 3;
            this.BtnGuardar_UsuarioRegistro.BorderSize = 0;
            this.BtnGuardar_UsuarioRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar_UsuarioRegistro.FlatAppearance.BorderSize = 0;
            this.BtnGuardar_UsuarioRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar_UsuarioRegistro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar_UsuarioRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar_UsuarioRegistro.Location = new System.Drawing.Point(427, 400);
            this.BtnGuardar_UsuarioRegistro.Name = "BtnGuardar_UsuarioRegistro";
            this.BtnGuardar_UsuarioRegistro.Size = new System.Drawing.Size(86, 21);
            this.BtnGuardar_UsuarioRegistro.TabIndex = 15;
            this.BtnGuardar_UsuarioRegistro.Text = "Guardar";
            this.BtnGuardar_UsuarioRegistro.TextColor = System.Drawing.Color.White;
            this.BtnGuardar_UsuarioRegistro.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar_UsuarioRegistro
            // 
            this.BtnCancelar_UsuarioRegistro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_UsuarioRegistro.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_UsuarioRegistro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancelar_UsuarioRegistro.BorderRadius = 3;
            this.BtnCancelar_UsuarioRegistro.BorderSize = 0;
            this.BtnCancelar_UsuarioRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar_UsuarioRegistro.FlatAppearance.BorderSize = 0;
            this.BtnCancelar_UsuarioRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar_UsuarioRegistro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar_UsuarioRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar_UsuarioRegistro.Location = new System.Drawing.Point(13, 400);
            this.BtnCancelar_UsuarioRegistro.Name = "BtnCancelar_UsuarioRegistro";
            this.BtnCancelar_UsuarioRegistro.Size = new System.Drawing.Size(86, 21);
            this.BtnCancelar_UsuarioRegistro.TabIndex = 14;
            this.BtnCancelar_UsuarioRegistro.Text = "Cancelar";
            this.BtnCancelar_UsuarioRegistro.TextColor = System.Drawing.Color.White;
            this.BtnCancelar_UsuarioRegistro.UseVisualStyleBackColor = false;
            this.BtnCancelar_UsuarioRegistro.Click += new System.EventHandler(this.BtnCancelar_UsuarioRegistro_Click);
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
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(-1, 0);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(528, 55);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "REGISTRO USUARIO";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // FrmUsuario_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(899, 557);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuario_Registrar";
            this.Text = "FrmUsuario_Registrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton BtnGuardar_UsuarioRegistro;
        private CustomControls.RJControls.RJButton BtnCancelar_UsuarioRegistro;
        private System.Windows.Forms.ComboBox CbxPlanes;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.ErrorProvider error;
    }
}