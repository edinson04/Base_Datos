using System;
using System.Data;
using System.Data.SqlClient;
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
                SqlCommand consulta = new SqlCommand("SELECT e.*, tituloProyecto AS Proyecto_participante FROM Eventos e, Proyectos p, Eventos_proyectos ep, " +
                    "Proyectos_investigadores pi WHERE e.idEvento = ep.idEvento AND p.idProyecto = ep.idProyecto AND p.idProyecto = pi.idProyecto AND " +
                    "pi.cedulaInvestigador = @cedulaInvestigador", cn.Conectar());
                consulta.Parameters.AddWithValue("@cedulaInvestigador", cedulaInvestigador);
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
