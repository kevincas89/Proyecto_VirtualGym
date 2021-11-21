
namespace Presentación
{
    partial class FrmEntrenadores_Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrenadores_Eliminar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTEntrenador = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new CustomControls.RJControls.RJButton();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new CustomControls.RJControls.RJButton();
            this.BtnCancelar_EntrenadoresConsultar = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTEntrenador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.DTEntrenador);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.TxtIdentificacion);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnCancelar_EntrenadoresConsultar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(196, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 534);
            this.panel1.TabIndex = 3;
            // 
            // DTEntrenador
            // 
            this.DTEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTEntrenador.Location = new System.Drawing.Point(37, 244);
            this.DTEntrenador.Name = "DTEntrenador";
            this.DTEntrenador.RowHeadersWidth = 51;
            this.DTEntrenador.RowTemplate.Height = 24;
            this.DTEntrenador.Size = new System.Drawing.Size(619, 110);
            this.DTEntrenador.TabIndex = 23;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEliminar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEliminar.BorderRadius = 3;
            this.BtnEliminar.BorderSize = 0;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(528, 361);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(115, 26);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextColor = System.Drawing.Color.White;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.Gray;
            this.TxtIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtIdentificacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(266, 178);
            this.TxtIdentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(176, 27);
            this.TxtIdentificacion.TabIndex = 21;
            this.TxtIdentificacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIdentificacion_Validating);
            this.TxtIdentificacion.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBuscar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBuscar.BorderRadius = 3;
            this.BtnBuscar.BorderSize = 0;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(572, 491);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(115, 26);
            this.BtnBuscar.TabIndex = 20;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCancelar_EntrenadoresConsultar
            // 
            this.BtnCancelar_EntrenadoresConsultar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_EntrenadoresConsultar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_EntrenadoresConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancelar_EntrenadoresConsultar.BorderRadius = 3;
            this.BtnCancelar_EntrenadoresConsultar.BorderSize = 0;
            this.BtnCancelar_EntrenadoresConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar_EntrenadoresConsultar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar_EntrenadoresConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar_EntrenadoresConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar_EntrenadoresConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar_EntrenadoresConsultar.Location = new System.Drawing.Point(16, 491);
            this.BtnCancelar_EntrenadoresConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar_EntrenadoresConsultar.Name = "BtnCancelar_EntrenadoresConsultar";
            this.BtnCancelar_EntrenadoresConsultar.Size = new System.Drawing.Size(115, 26);
            this.BtnCancelar_EntrenadoresConsultar.TabIndex = 19;
            this.BtnCancelar_EntrenadoresConsultar.Text = "Cancelar";
            this.BtnCancelar_EntrenadoresConsultar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar_EntrenadoresConsultar.UseVisualStyleBackColor = false;
            this.BtnCancelar_EntrenadoresConsultar.Click += new System.EventHandler(this.BtnCancelar_UsuarioConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(228, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese Identificación";
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
            this.rjButton1.Text = "ELIMINAR ENTRENADOR";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmEntrenadores_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1093, 698);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEntrenadores_Eliminar";
            this.Text = "FrmEntrenadores_Consultar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTEntrenador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.ErrorProvider error;
        private CustomControls.RJControls.RJButton BtnBuscar;
        private CustomControls.RJControls.RJButton BtnCancelar_EntrenadoresConsultar;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private CustomControls.RJControls.RJButton BtnEliminar;
        private System.Windows.Forms.DataGridView DTEntrenador;
    }
}