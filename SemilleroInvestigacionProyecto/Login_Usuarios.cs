using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SemilleroInvestigacionProyecto
{
    public partial class Login_Usuarios : Form
    {
        
        public Login_Usuarios()
        {
            InitializeComponent();
            
        }

        private void Form_login_Activated_1(object sender, EventArgs e)
        {
           this.ActiveControl = null;
        }

        private void Login_Usuarios_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "Usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_usuario.Text))
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.Silver;
            }
        }
      
        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros", "Gestion Semilleros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "Contraseña")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.Black;
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
            {
                txt_contraseña.Text = "Contraseña";
                txt_contraseña.ForeColor = Color.Silver;
                txt_contraseña.UseSystemPasswordChar = false; 
            }

        }

        private void pictureBox_ojito_MouseDown(object sender, MouseEventArgs e)
        {
            if (txt_contraseña.Text != "Contraseña")
            {
                txt_contraseña.UseSystemPasswordChar = false;
            }
        }
        
        private void pictureBox_ojito_MouseUp(object sender, MouseEventArgs e)
        {
            if (txt_contraseña.Text != "Contraseña")
            {
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void button_Iniciar_Sesion_Click(object sender, EventArgs e)
        {

            if (txt_usuario.Text == "Usuario" || txt_contraseña.Text == "Contraseña" || txt_usuario.Text == "" || txt_contraseña.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Gestion Semilleros", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    Consulta co = new Consulta();
                    var resultado = co.Iniciar_sesion(txt_usuario.Text, txt_contraseña.Text);
                    if (resultado.ok)
                    {
                        if ("Administrador" == resultado.tipoUsuario)
                        {
                            MessageBox.Show("¡Bienvenido Administrador!", "Adminstrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else if ("Lider" == resultado.tipoUsuario)
                        {
                            MessageBox.Show("¡Bienvenido Lider de semillero!", "Lider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menu_Lider lider = new Menu_Lider(txt_usuario.Text);
                            lider.Show();
                        }
                        else
                        {
                            MessageBox.Show("¡Bienvenido Investigador!", "Investigador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menu_Integrante integrante = new Menu_Integrante(txt_usuario.Text);
                            integrante.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        this.Hide();
                        MessageBox.Show("Usuario o contraseña incorrectos", "Credenciales Incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        new Login_Usuarios().Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro desea salir del aplicativo?", "Salir del Aplicativo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

