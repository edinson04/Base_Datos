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
        
        Consulta co = new Consulta();
        public Login_Usuarios()
        {
            InitializeComponent();
            
        }

        private void Form_login_Activated_1(object sender, EventArgs e)
        {
            pictureBox1.Focus(); // Pasar el foco a la imagen y no a la caja de texto
        }

        private void Login_Usuarios_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();// pasar el foco a la imagen a dar click en partes del formulario
        }

        // Logica para usuario

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
                if (string.IsNullOrWhiteSpace(txt_usuario.Text))
                {
                    txt_usuario.Text = "Usuario";
                    txt_usuario.ForeColor = Color.Silver;
                }
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

        // Logica para contraseña
        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "Contraseña")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.Black;
                txt_contraseña.UseSystemPasswordChar = true; // Activa los puntos
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
            {
                txt_contraseña.Text = "Contraseña";
                txt_contraseña.ForeColor = Color.Silver;
                txt_contraseña.UseSystemPasswordChar = false; // Muestra la palabra
            }

        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar letras", "Gestion Semilleros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Logica para ver contraseña
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

        

       
        // Logica para boton Iniciar Sesion

        private void button_Iniciar_Sesion_Click(object sender, EventArgs e)
        {
            

            if (txt_usuario.Text == "Usuario" || txt_contraseña.Text == "Contraseña")
            {
                MessageBox.Show("Complete todos los campos", "Gestion Semilleros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txt_usuario.Text == "Usuario" || txt_contraseña.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Gestion Semilleros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txt_usuario.Text == "" || txt_contraseña.Text == "Contraseña")
            {
                MessageBox.Show("Complete todos los campos", "Gestion Semilleros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (co.Iniciar_sesion(txt_usuario.Text, txt_contraseña.Text)) // llamo al metedo Iniciar Sesion y le doy los parametros
            {
                MessageBox.Show("¡Inicio de sesión exitoso!", "Gestion Semilleros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
    }
}

