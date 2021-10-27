
namespace Presentación
{
    partial class FrmPlanes_Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanes_Consultar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtgPlanes = new System.Windows.Forms.DataGridView();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.BtnActualizar = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.DtgPlanes);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(61, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 527);
            this.panel1.TabIndex = 1;
            // 
            // DtgPlanes
            // 
            this.DtgPlanes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtgPlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPlanes.Location = new System.Drawing.Point(170, 103);
            this.DtgPlanes.Margin = new System.Windows.Forms.Padding(4);
            this.DtgPlanes.Name = "DtgPlanes";
            this.DtgPlanes.RowHeadersWidth = 51;
            this.DtgPlanes.Size = new System.Drawing.Size(603, 379);
            this.DtgPlanes.TabIndex = 3;
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
            this.rjButton1.Location = new System.Drawing.Point(0, 0);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(960, 68);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "INFORME PLANES";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnActualizar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnActualizar.BorderRadius = 3;
            this.BtnActualizar.BorderSize = 0;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(774, 497);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(115, 26);
            this.BtnActualizar.TabIndex = 19;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextColor = System.Drawing.Color.White;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmPlanes_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1067, 718);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPlanes_Consultar";
            this.Text = "FrmPlanes_Consultar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPlanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.DataGridView DtgPlanes;
        private CustomControls.RJControls.RJButton BtnActualizar;
    }
}