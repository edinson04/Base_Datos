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
                con = new SqlConnection("data Source = localhost\\SQLEXPRESS; Initial Catalog = Semillero_BD; Integrated Security = true");
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
