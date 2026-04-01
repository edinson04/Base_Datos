namespace SemilleroInvestigacionProyecto
{
    partial class Login_Usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Iniciar_Sesion = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pictureBox_ojito = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ojito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Silver;
            this.txt_usuario.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txt_usuario.Location = new System.Drawing.Point(27, 211);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(320, 29);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.Text = "Usuario";
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.Silver;
            this.txt_contraseña.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txt_contraseña.Location = new System.Drawing.Point(27, 267);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(320, 29);
            this.txt_contraseña.TabIndex = 1;
            this.txt_contraseña.Text = "Contraseña";
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_contraseña_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "SEMILLEROS SENA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(121, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese sus datos";
            // 
            // button_Iniciar_Sesion
            // 
            this.button_Iniciar_Sesion.BackColor = System.Drawing.Color.Green;
            this.button_Iniciar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Iniciar_Sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Iniciar_Sesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Iniciar_Sesion.Location = new System.Drawing.Point(27, 331);
            this.button_Iniciar_Sesion.Name = "button_Iniciar_Sesion";
            this.button_Iniciar_Sesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Iniciar_Sesion.Size = new System.Drawing.Size(320, 43);
            this.button_Iniciar_Sesion.TabIndex = 5;
            this.button_Iniciar_Sesion.Text = "INICIAR SESIÓN";
            this.button_Iniciar_Sesion.UseVisualStyleBackColor = false;
            this.button_Iniciar_Sesion.Click += new System.EventHandler(this.button_Iniciar_Sesion_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox_ojito
            // 
            this.pictureBox_ojito.Image = global::SemilleroInvestigacionProyecto.Properties.Resources.ojito;
            this.pictureBox_ojito.Location = new System.Drawing.Point(313, 271);
            this.pictureBox_ojito.Name = "pictureBox_ojito";
            this.pictureBox_ojito.Size = new System.Drawing.Size(28, 23);
            this.pictureBox_ojito.TabIndex = 6;
            this.pictureBox_ojito.TabStop = false;
            this.pictureBox_ojito.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ojito_MouseDown);
            this.pictureBox_ojito.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ojito_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SemilleroInvestigacionProyecto.Properties.Resources.senita;
            this.pictureBox1.Location = new System.Drawing.Point(174, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 54);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Crimson;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_salir.Location = new System.Drawing.Point(27, 380);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_salir.Size = new System.Drawing.Size(320, 43);
            this.Btn_salir.TabIndex = 7;
            this.Btn_salir.Text = "SALIR DEL APLICATIVO";
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Login_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.pictureBox_ojito);
            this.Controls.Add(this.button_Iniciar_Sesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_Usuarios";
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Form_login_Activated_1);
            this.Click += new System.EventHandler(this.Login_Usuarios_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ojito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Iniciar_Sesion;
        private System.Windows.Forms.PictureBox pictureBox_ojito;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button Btn_salir;
    }
}

