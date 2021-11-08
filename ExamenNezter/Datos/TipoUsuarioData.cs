using ExamenNezter.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNezter.Datos
{
    public class TipoUsuarioData : Conexion
    {
        public IEnumerable<TipoUsuarioModel> Consultar()
        {
            Conectar();
            List<TipoUsuarioModel> lista = new List<TipoUsuarioModel>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_tipo_usuario_consultar", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    TipoUsuarioModel modelo = new TipoUsuarioModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Tipo_usuario = lector[1] + ""
                    };
                    lista.Add(modelo);
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
            return lista;
        }

        public TipoUsuarioModel ConsultarID(int id)
        {
            TipoUsuarioModel modelo = new TipoUsuarioModel();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("sp_tipo_usuario_consultar_id", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    modelo = new TipoUsuarioModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Tipo_usuario = lector[1] + ""
                    };
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

            return modelo;
        }

        public void Guardar(TipoUsuarioModel modelo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("sp_tipo_usuario_guardar", cnn);
            try
            {
                if (modelo.Id != 0)
                {
                    comando = new SqlCommand("sp_tipo_usuario_modificar", cnn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", modelo.Id);
                    comando.Parameters.AddWithValue("@tipo_usuario", modelo.Tipo_usuario);
                }
                else
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@tipo_usuario", modelo.Tipo_usuario);
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Eliminar(TipoUsuarioModel modelo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("sp_tipo_usuario_eliminar", cnn);
            try
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", modelo.Id);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
