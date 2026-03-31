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
        DataSet ds = new DataSet();
        public bool Iniciar_sesion(string idUsuario, string claveUsuario)
        {
            bool estado_conexion = false;
            ds.Clear();

            // Ajustado: La columna en tu SQL es 'claveUsuario'
            string query = "SELECT idUsuario, claveUsuario, tipoUsuario FROM Usuario WHERE idUsuario = @idUsuario AND claveUsuario = @claveUsuario";

            SqlCommand comando = new SqlCommand(query, cn.Conectar());
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@claveUsuario", claveUsuario); 

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(ds, "Usuario");

                if (ds.Tables["Usuario"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Usuario"].Rows[0];
                    string tipo = dr["tipoUsuario"].ToString();

                    // Redirección según tu base de datos
                    if (tipo == "Administrador")
                    {
                        
                    }
                    else if (tipo == "Integrante")
                    {
                        
                    }

                    else if(tipo == "Integrante")
                    {

                    }
                    estado_conexion = true;
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en consulta: " + ex.Message);
            }
            finally
            {
                cn.Cerrar();
            }

            return estado_conexion;
        }
    }
}
