
namespace Presentación
{
    partial class FrmEntrenadores_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrenadores_Registrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSueldo = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnGuardar_EntrenadoresRegistro = new CustomControls.RJControls.RJButton();
            this.BtnCancelar_EntrenadoresRegistro = new CustomControls.RJControls.RJButton();
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
            this.panel1.Controls.Add(this.DTFecha);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CbxSexo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BtnGuardar_EntrenadoresRegistro);
            this.panel1.Controls.Add(this.BtnCancelar_EntrenadoresRegistro);
            this.panel1.Controls.Add(this.TxtSueldo);
            this.panel1.Controls.Add(this.TxtCelular);
            this.panel1.Controls.Add(this.TxtIdentificacion);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(196, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 534);
            this.panel1.TabIndex = 1;
            // 
            // CbxSexo
            // 
            this.CbxSexo.BackColor = System.Drawing.Color.Gray;
            this.CbxSexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CbxSexo.Location = new System.Drawing.Point(232, 276);
            this.CbxSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(83, 24);
            this.CbxSexo.TabIndex = 26;
            this.CbxSexo.Validating += new System.ComponentModel.CancelEventHandler(this.CbxSexo_Validating);
            this.CbxSexo.Validated += new System.EventHandler(this.CbxSexo_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(35, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sexo";
            // 
            // TxtSueldo
            // 
            this.TxtSueldo.BackColor = System.Drawing.Color.Gray;
            this.TxtSueldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtSueldo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtSueldo.Location = new System.Drawing.Point(232, 433);
            this.TxtSueldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSueldo.Name = "TxtSueldo";
            this.TxtSueldo.Size = new System.Drawing.Size(176, 27);
            this.TxtSueldo.TabIndex = 22;
            this.TxtSueldo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSueldo_Validating);
            this.TxtSueldo.Validated += new System.EventHandler(this.TxtSueldo_Validated);
            // 
            // TxtCelular
            // 
            this.TxtCelular.BackColor = System.Drawing.Color.Gray;
            this.TxtCelular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtCelular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtCelular.Location = new System.Drawing.Point(232, 378);
            this.TxtCelular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(176, 27);
            this.TxtCelular.TabIndex = 21;
            this.TxtCelular.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCelular_Validating);
            this.TxtCelular.Validated += new System.EventHandler(this.TxtCelular_Validated);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.Gray;
            this.TxtIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtIdentificacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtIdentificacion.Location = new System.Drawing.Point(232, 105);
            this.TxtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(176, 27);
            this.TxtIdentificacion.TabIndex = 18;
            this.TxtIdentificacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIdentificacion_Validating);
            this.TxtIdentificacion.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.Gray;
            this.TxtApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtApellido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtApellido.Location = new System.Drawing.Point(232, 217);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(365, 27);
            this.TxtApellido.TabIndex = 13;
            this.TxtApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellido_Validating);
            this.TxtApellido.Validated += new System.EventHandler(this.TxtApellido_Validated);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.Gray;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.Location = new System.Drawing.Point(232, 162);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(365, 27);
            this.TxtNombre.TabIndex = 12;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            this.TxtNombre.Validated += new System.EventHandler(this.TxtNombre_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(35, 434);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sueldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(35, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(35, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(25, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Fecha de nacimiento";
            // 
            // DTFecha
            // 
            this.DTFecha.Location = new System.Drawing.Point(289, 326);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(266, 22);
            this.DTFecha.TabIndex = 28;
            // 
            // BtnGuardar_EntrenadoresRegistro
            // 
            this.BtnGuardar_EntrenadoresRegistro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar_EntrenadoresRegistro.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar_EntrenadoresRegistro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuardar_EntrenadoresRegistro.BorderRadius = 3;
            this.BtnGuardar_EntrenadoresRegistro.BorderSize = 0;
            this.BtnGuardar_EntrenadoresRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar_EntrenadoresRegistro.FlatAppearance.BorderSize = 0;
            this.BtnGuardar_EntrenadoresRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar_EntrenadoresRegistro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar_EntrenadoresRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar_EntrenadoresRegistro.Location = new System.Drawing.Point(563, 494);
            this.BtnGuardar_EntrenadoresRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar_EntrenadoresRegistro.Name = "BtnGuardar_EntrenadoresRegistro";
            this.BtnGuardar_EntrenadoresRegistro.Size = new System.Drawing.Size(115, 26);
            this.BtnGuardar_EntrenadoresRegistro.TabIndex = 24;
            this.BtnGuardar_EntrenadoresRegistro.Text = "Guardar";
            this.BtnGuardar_EntrenadoresRegistro.TextColor = System.Drawing.Color.White;
            this.BtnGuardar_EntrenadoresRegistro.UseVisualStyleBackColor = false;
            this.BtnGuardar_EntrenadoresRegistro.Click += new System.EventHandler(this.BtnGuardar_EntrenadoresRegistro_Click);
            // 
            // BtnCancelar_EntrenadoresRegistro
            // 
            this.BtnCancelar_EntrenadoresRegistro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_EntrenadoresRegistro.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_EntrenadoresRegistro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancelar_EntrenadoresRegistro.BorderRadius = 3;
            this.BtnCancelar_EntrenadoresRegistro.BorderSize = 0;
            this.BtnCancelar_EntrenadoresRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar_EntrenadoresRegistro.FlatAppearance.BorderSize = 0;
            this.BtnCancelar_EntrenadoresRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar_EntrenadoresRegistro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar_EntrenadoresRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar_EntrenadoresRegistro.Location = new System.Drawing.Point(29, 494);
            this.BtnCancelar_EntrenadoresRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar_EntrenadoresRegistro.Name = "BtnCancelar_EntrenadoresRegistro";
            this.BtnCancelar_EntrenadoresRegistro.Size = new System.Drawing.Size(115, 26);
            this.BtnCancelar_EntrenadoresRegistro.TabIndex = 23;
            this.BtnCancelar_EntrenadoresRegistro.Text = "Cancelar";
            this.BtnCancelar_EntrenadoresRegistro.TextColor = System.Drawing.Color.White;
            this.BtnCancelar_EntrenadoresRegistro.UseVisualStyleBackColor = false;
            this.BtnCancelar_EntrenadoresRegistro.Click += new System.EventHandler(this.BtnCancelar_EntrenadoresRegistro_Click);
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
            this.rjButton2.Margin = new System.Windows.Forms.Padding(5);
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
            this.rjButton1.Margin = new System.Windows.Forms.Padding(5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(704, 68);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "REGISTRO ENTRENADOR";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // FrmEntrenadores_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1067, 673);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEntrenadores_Registrar";
            this.Text = "FrmEntrenadores_Registrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtSueldo;
        private System.Windows.Forms.TextBox TxtCelular;
        private CustomControls.RJControls.RJButton BtnGuardar_EntrenadoresRegistro;
        private CustomControls.RJControls.RJButton BtnCancelar_EntrenadoresRegistro;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbxSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTFecha;
    }
}