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
    public partial class Consultar_Proyecto_Integrante : Form
    {
        private string cedulaInvestigador;
        public Consultar_Proyecto_Integrante(string idUsuario)
        {
            InitializeComponent();
            cedulaInvestigador = idUsuario;
        }
        private void consultar_proyecto_Integrante_Load(object sender, EventArgs e)
        {
            Dgv_proyectos.DataSource = ObtenerProyectosPorUsuario(cedulaInvestigador);
        }

        public DataTable ObtenerProyectosPorUsuario(string cedulaInvestigador)
        {
            DataTable dt = new DataTable();

            try
            {
                Conexion cn = new Conexion();
                {
                    SqlCommand cmd = new SqlCommand("SELECT p.* FROM Proyectos p, Proyectos_investigadores pi WHERE p.idProyecto = pi.idProyecto AND pi.cedulaInvestigador = @cedulaInvestigador", cn.Conectar());

                    cmd.Parameters.AddWithValue("@cedulaInvestigador", cedulaInvestigador);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message);
            }

            return dt;
        }
    }
}
