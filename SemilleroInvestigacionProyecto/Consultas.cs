using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SemilleroInvestigacionProyecto
{
    internal class Consulta
    {
        Conexion cn = new Conexion();   
        public (bool ok, string tipoUsuario) Iniciar_sesion(string idUsuario, string claveUsuario)
        {
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT tipoUsuario FROM Usuario WHERE idUsuario = @idUsuario AND claveUsuario = @claveUsuario", cn.Conectar());
                consulta.Parameters.AddWithValue("@idUsuario", idUsuario);
                consulta.Parameters.AddWithValue("@claveUsuario", claveUsuario);
                SqlDataReader dr = consulta.ExecuteReader();
                if (dr.Read())
                {
                    string tipo = dr["tipoUsuario"].ToString();
                    return (true, tipo);
                }
                else
                {
                    return (false, null);
                }
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cn.Cerrar();
            }
        }
    }
}
