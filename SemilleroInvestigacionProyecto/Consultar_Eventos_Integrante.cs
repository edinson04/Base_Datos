using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemilleroInvestigacionProyecto
{
    public partial class Consultar_Evento_Integrante : Form
    {
        string cedulaInvestigador;
        public Consultar_Evento_Integrante(String idUsuario)
        {
            InitializeComponent();
            cedulaInvestigador = idUsuario;
        }

        private void Consultar_Evento_Integrante_Load(object sender, EventArgs e)
        {
            Dgv_eventos.DataSource = ObtenerEventosporUsuario(cedulaInvestigador);
        }

        private DataTable ObtenerEventosporUsuario(string cedulaInvestigador)
        {
            DataTable dt = new DataTable();
            Conexion cn = new Conexion();
            try 
            {
                SqlCommand consulta = new SqlCommand("");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cn.Cerrar();
            }
            return dt;
        }
    }
}
