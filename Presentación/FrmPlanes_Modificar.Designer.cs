
namespace Presentación
{
    partial class FrmPlanes_Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanes_Modificar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new CustomControls.RJControls.RJButton();
            this.LbDuracion = new System.Windows.Forms.Label();
            this.LbValor = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DtgPlanes = new System.Windows.Forms.DataGridView();
            this.BtnBuscarPlanes = new CustomControls.RJControls.RJButton();
            this.BtnCancelar_PlanesModificar = new CustomControls.RJControls.RJButton();
            this.TxtCodigoPlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnEliminar = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.LbDuracion);
            this.panel1.Controls.Add(this.LbValor);
            this.panel1.Controls.Add(this.LbNombre);
            this.panel1.Controls.Add(this.TxtDuracion);
            this.panel1.Controls.Add(this.TxtValor);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.DtgPlanes);
            this.panel1.Controls.Add(this.BtnBuscarPlanes);
            this.panel1.Controls.Add(this.BtnCancelar_PlanesModificar);
            this.panel1.Controls.Add(this.TxtCodigoPlan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(204, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 534);
            this.panel1.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuardar.BorderRadius = 3;
            this.BtnGuardar.BorderSize = 0;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(525, 490);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 26);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LbDuracion
            // 
            this.LbDuracion.AutoSize = true;
            this.LbDuracion.BackColor = System.Drawing.Color.Transparent;
            this.LbDuracion.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDuracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbDuracion.Location = new System.Drawing.Point(451, 358);
            this.LbDuracion.Name = "LbDuracion";
            this.LbDuracion.Size = new System.Drawing.Size(108, 17);
            this.LbDuracion.TabIndex = 25;
            this.LbDuracion.Text = "Nueva duracion";
            // 
            // LbValor
            // 
            this.LbValor.AutoSize = true;
            this.LbValor.BackColor = System.Drawing.Color.Transparent;
            this.LbValor.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbValor.Location = new System.Drawing.Point(451, 294);
            this.LbValor.Name = "LbValor";
            this.LbValor.Size = new System.Drawing.Size(139, 17);
            this.LbValor.TabIndex = 24;
            this.LbValor.Text = "Nuevo valor del Plan";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.BackColor = System.Drawing.Color.Transparent;
            this.LbNombre.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbNombre.Location = new System.Drawing.Point(451, 229);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(158, 17);
            this.LbNombre.TabIndex = 23;
            this.LbNombre.Text = "Nuevo Nombre del Plan";
            // 
            // TxtDuracion
            // 
            this.TxtDuracion.Location = new System.Drawing.Point(453, 378);
            this.TxtDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDuracion.Name = "TxtDuracion";
            this.TxtDuracion.Size = new System.Drawing.Size(147, 22);
            this.TxtDuracion.TabIndex = 22;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(453, 314);
            this.TxtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(147, 22);
            this.TxtValor.TabIndex = 21;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(453, 250);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(147, 22);
            this.TxtNombre.TabIndex = 20;
            // 
            // DtgPlanes
            // 
            this.DtgPlanes.BackgroundColor = System.Drawing.Color.White;
            this.DtgPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPlanes.Location = new System.Drawing.Point(17, 229);
            this.DtgPlanes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtgPlanes.Name = "DtgPlanes";
            this.DtgPlanes.RowHeadersWidth = 51;
            this.DtgPlanes.RowTemplate.Height = 24;
            this.DtgPlanes.Size = new System.Drawing.Size(405, 225);
            this.DtgPlanes.TabIndex = 19;
            this.DtgPlanes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPlanes_CellDoubleClick);
            // 
            // BtnBuscarPlanes
            // 
            this.BtnBuscarPlanes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBuscarPlanes.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBuscarPlanes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBuscarPlanes.BorderRadius = 3;
            this.BtnBuscarPlanes.BorderSize = 0;
            this.BtnBuscarPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarPlanes.FlatAppearance.BorderSize = 0;
            this.BtnBuscarPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarPlanes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPlanes.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarPlanes.Location = new System.Drawing.Point(245, 174);
            this.BtnBuscarPlanes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscarPlanes.Name = "BtnBuscarPlanes";
            this.BtnBuscarPlanes.Size = new System.Drawing.Size(115, 26);
            this.BtnBuscarPlanes.TabIndex = 18;
            this.BtnBuscarPlanes.Text = "Buscar";
            this.BtnBuscarPlanes.TextColor = System.Drawing.Color.White;
            this.BtnBuscarPlanes.UseVisualStyleBackColor = false;
            this.BtnBuscarPlanes.Click += new System.EventHandler(this.BtnBuscarPlanes_Click);
            // 
            // BtnCancelar_PlanesModificar
            // 
            this.BtnCancelar_PlanesModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_PlanesModificar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar_PlanesModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancelar_PlanesModificar.BorderRadius = 3;
            this.BtnCancelar_PlanesModificar.BorderSize = 0;
            this.BtnCancelar_PlanesModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar_PlanesModificar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar_PlanesModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar_PlanesModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar_PlanesModificar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar_PlanesModificar.Location = new System.Drawing.Point(17, 490);
            this.BtnCancelar_PlanesModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar_PlanesModificar.Name = "BtnCancelar_PlanesModificar";
            this.BtnCancelar_PlanesModificar.Size = new System.Drawing.Size(115, 26);
            this.BtnCancelar_PlanesModificar.TabIndex = 17;
            this.BtnCancelar_PlanesModificar.Text = "Cancelar";
            this.BtnCancelar_PlanesModificar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar_PlanesModificar.UseVisualStyleBackColor = false;
            this.BtnCancelar_PlanesModificar.Click += new System.EventHandler(this.BtnCancelar_PlanesModificar_Click);
            // 
            // TxtCodigoPlan
            // 
            this.TxtCodigoPlan.BackColor = System.Drawing.Color.White;
            this.TxtCodigoPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtCodigoPlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPlan.Location = new System.Drawing.Point(17, 174);
            this.TxtCodigoPlan.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigoPlan.Name = "TxtCodigoPlan";
            this.TxtCodigoPlan.Size = new System.Drawing.Size(176, 27);
            this.TxtCodigoPlan.TabIndex = 11;
            this.TxtCodigoPlan.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigoPlan_Validating);
            this.TxtCodigoPlan.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese codigo del plan";
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
            this.rjButton1.Size = new System.Drawing.Size(657, 68);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "MODIFICAR PLAN";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
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
            this.BtnEliminar.Location = new System.Drawing.Point(307, 460);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(115, 26);
            this.BtnEliminar.TabIndex = 27;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextColor = System.Drawing.Color.White;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FrmPlanes_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1067, 699);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPlanes_Modificar";
            this.Text = "FrmPlanes_Modificar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.TextBox TxtCodigoPlan;
        private CustomControls.RJControls.RJButton BtnBuscarPlanes;
        private CustomControls.RJControls.RJButton BtnCancelar_PlanesModificar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label LbDuracion;
        private System.Windows.Forms.Label LbValor;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.TextBox TxtDuracion;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView DtgPlanes;
        private CustomControls.RJControls.RJButton BtnGuardar;
        private CustomControls.RJControls.RJButton BtnEliminar;
    }
}