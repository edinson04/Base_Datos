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
    public partial class Menu_Integrante : Form
    { private string cedulaInvestigador;
        public Menu_Integrante(string idUsuario)
        {
            InitializeComponent();
            cedulaInvestigador = idUsuario;
        }

        private void Btn_Cerrar_sesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cerrar la sesion investigador?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                new Login_Usuarios().Show();
                this.Close();
            }
        }

        private void Btn_consultar_proyectos_Click(object sender, EventArgs e)
        {
            Consultar_Proyecto_Integrante cpi = new Consultar_Proyecto_Integrante(cedulaInvestigador);
            cpi.Show();
        }

        private void Btn_consultar_reuniones_Click(object sender, EventArgs e)
        {
            Consultar_Reunion_Integrante cri = new Consultar_Reunion_Integrante(cedulaInvestigador);
            cri.Show();
        }

        private void Btn_consultar_semillero_Click(object sender, EventArgs e)
        {
            
        }
    }
}
