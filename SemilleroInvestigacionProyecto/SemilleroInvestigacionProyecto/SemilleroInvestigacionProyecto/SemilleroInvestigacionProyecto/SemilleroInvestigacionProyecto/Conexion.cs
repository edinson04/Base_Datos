using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SemilleroInvestigacionProyecto
{
    internal class Conexion // Se declara una clase llamada conexion
    {
        SqlConnection con;

        public SqlConnection Conectar()
        {
            try
            {
                // Ajustado a tu servidor y base de datos
                con = new SqlConnection("Data Source=COIN_COMPUTERS\\SQLEXPRESS; Initial Catalog=semillero_BD; Integrated Security=True");
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexión: " + e.Message);
            }
            return con;
        }

        public void Cerrar()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
