using ExamenNezter.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNezter.Datos
{
    public class LoginData : Conexion
    {
        public bool Verify(string Usuario, string Contrasena)
        {
            Conectar();
            List<EstadosModel> lista = new List<EstadosModel>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_login_verify", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usuario", Usuario);
                comando.Parameters.AddWithValue("@contrasena", Contrasena);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    if (int.Parse(lector[0] + "") != 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
            return true;
        }
    }
}
