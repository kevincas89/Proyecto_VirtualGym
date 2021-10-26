
namespace Presentación
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PictureInicio = new System.Windows.Forms.PictureBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureInicio
            // 
            this.PictureInicio.Image = ((System.Drawing.Image)(resources.GetObject("PictureInicio.Image")));
            this.PictureInicio.Location = new System.Drawing.Point(191, 15);
            this.PictureInicio.Name = "PictureInicio";
            this.PictureInicio.Size = new System.Drawing.Size(450, 340);
            this.PictureInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureInicio.TabIndex = 1;
            this.PictureInicio.TabStop = false;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Bahnschrift Condensed", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(306, 454);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(117, 57);
            this.LblFecha.TabIndex = 4;
            this.LblFecha.Text = "Fecha";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Bahnschrift Condensed", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(256, 341);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(218, 128);
            this.LblHora.TabIndex = 3;
            this.LblHora.Text = "Hora";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(804, 558);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.PictureInicio);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.PictureInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureInicio;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer HoraFecha;
    }
}