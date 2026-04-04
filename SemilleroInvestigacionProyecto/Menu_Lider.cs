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
    public partial class Menu_Lider : Form
    {
        string cedulaInvestigador;
        public Menu_Lider(string idUsuario)
        {
            InitializeComponent();
            cedulaInvestigador = idUsuario;
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("¿Seguro desea cerrar la sesion lider?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                new Login_Usuarios().Show();
                this.Close();
            }
        }
    }
}
