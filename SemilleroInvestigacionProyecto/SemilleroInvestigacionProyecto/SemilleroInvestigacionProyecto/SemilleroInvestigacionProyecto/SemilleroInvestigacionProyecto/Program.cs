using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemilleroInvestigacionProyecto
{
    internal class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Creamos el formulario de Login
            Login_Usuarios login = new Login_Usuarios();

            // 2. Lo mostramos como un cuadro de diálogo
            if (login.ShowDialog() == DialogResult.OK)
            {
                // 3. Si el login fue exitoso, arrancamos el Menú
                // Esto hace que el Menú sea ahora el formulario principal
                Application.Run(new Menu_Integrante());
            }
        }
    }

 }


