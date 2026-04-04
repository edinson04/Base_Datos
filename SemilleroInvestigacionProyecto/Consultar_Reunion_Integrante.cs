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
    public partial class Consultar_Reunion_Integrante : Form
    {
        string cedulaInvestigador;
        public Consultar_Reunion_Integrante(string idUsuario)
        {
            InitializeComponent();
            cedulaInvestigador = idUsuario;
        }

        private void Consultar_Reunion_Integrante_Load(object sender, EventArgs e)
        {
            Dgv_reuniones.DataSource = ObtenerReunionesporUsuario(cedulaInvestigador);
        }

        public DataTable ObtenerReunionesporUsuario(string cedulaInvestigador)
        {
            DataTable dt = new DataTable();
            Conexion cn = new Conexion();
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT idReunion, fechaReunion, horaReunion, lugarReunion, motivoReunion, enlaceReunion " +
                    "FROM Reuniones r, Investigadores l, Investigadores i WHERE r.cedulaInvestigador = l.cedulaInvestigador AND l.idSemillero =" +
                    " i.idSemillero AND i.cedulaInvestigador = @cedulaInvestigador", cn.Conectar());
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
