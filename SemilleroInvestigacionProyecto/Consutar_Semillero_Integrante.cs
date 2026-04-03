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
    public partial class Consutar_Semillero_Integrante : Form
    {
        string cedulaInvestigador;
        public Consutar_Semillero_Integrante(string idUsuario)
        {
            InitializeComponent();
            cedulaInvestigador = idUsuario;
        }

        private void Consutar_Semillero_Integrante_Load(object sender, EventArgs e)
        {
            Dgv_semillero.DataSource = ObtenerSemilleroporUsuario(cedulaInvestigador);
        }

        public DataTable ObtenerSemilleroporUsuario(string cedulaInvestigaador)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion cn = new Conexion();
                SqlCommand consulta = new SqlCommand("SELECT s.* FROM Semillero s, Investigadores i WHERE s.idSemillero = i.idSemillero AND " +
                    "i.cedulaInvestigador = @cedulaInvestigador", cn.Conectar());
                consulta.Parameters.AddWithValue("@cedulaInvestigador", cedulaInvestigaador);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                da.Fill(dt);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
    }
}
