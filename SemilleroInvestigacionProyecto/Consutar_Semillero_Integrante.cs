using System;
using System.Data;
using System.Data.SqlClient;
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
            Conexion cn = new Conexion();
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT s.*, l.nombreInvestigador AS lider_del_semillero FROM Semillero s, Investigadores i," +
                    " Investigadores l WHERE s.idSemillero = l.idSemillero AND l.rolInvestigador = 'Lider' AND i.idSemillero = l.idSemillero AND" +
                    " i.cedulaInvestigador = @cedulaInvestigador", cn.Conectar());
                consulta.Parameters.AddWithValue("@cedulaInvestigador", cedulaInvestigaador);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                da.Fill(dt);
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
