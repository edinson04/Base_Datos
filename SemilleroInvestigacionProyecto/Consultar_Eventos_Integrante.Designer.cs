namespace SemilleroInvestigacionProyecto
{
    partial class Consultar_Evento_Integrante
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
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_eventos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_eventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Eventos del semillero";
            // 
            // Dgv_eventos
            // 
            this.Dgv_eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_eventos.Location = new System.Drawing.Point(34, 187);
            this.Dgv_eventos.Name = "Dgv_eventos";
            this.Dgv_eventos.ReadOnly = true;
            this.Dgv_eventos.Size = new System.Drawing.Size(314, 206);
            this.Dgv_eventos.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SemilleroInvestigacionProyecto.Properties.Resources.senita;
            this.pictureBox1.Location = new System.Drawing.Point(171, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 54);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Consultar_Evento_Integrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_eventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Consultar_Evento_Integrante";
            this.Text = "Consultar Evento Integrante";
            this.Load += new System.EventHandler(this.Consultar_Evento_Integrante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_eventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_eventos;
    }
}