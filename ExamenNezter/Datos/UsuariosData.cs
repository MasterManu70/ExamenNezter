using ExamenNezter.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNezter.Datos
{
    public class UsuariosData : Conexion
    {
        public IEnumerable<UsuariosModel> Consultar()
        {
            Conectar();
            List<UsuariosModel> lista = new List<UsuariosModel>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_usuarios_consultar", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    UsuariosModel modelo = new UsuariosModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Usuario = lector[1] + "",
                        Nombre = lector[2] + "",
                        Direccion = lector[3] + "",
                        Telefono = lector[4] + "",
                        Cp = lector[5] + "",
                        Id_ciudad = int.Parse(lector[6] + ""),
                        Id_tipo_usuario = int.Parse(lector[7] + ""),
                        Contrasena = lector[8] + ""
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

        public UsuariosModel ConsultarID(int id)
        {
            UsuariosModel modelo = new UsuariosModel();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("sp_usuarios_consultar_id", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    modelo = new UsuariosModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Usuario = lector[1] + "",
                        Nombre = lector[2] + "",
                        Direccion = lector[3] + "",
                        Telefono = lector[4] + "",
                        Cp = lector[5] + "",
                        Id_ciudad = int.Parse(lector[6] + ""),
                        Id_tipo_usuario = int.Parse(lector[7] + ""),
                        Contrasena = lector[8] + ""
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

        public void Guardar(UsuariosModel modelo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("sp_usuarios_guardar", cnn);
            try
            {
                if (modelo.Id != 0)
                {
                    comando = new SqlCommand("sp_usuarios_modificar", cnn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", modelo.Id);
                    comando.Parameters.AddWithValue("@usuario", modelo.Usuario);
                    comando.Parameters.AddWithValue("@nombre", modelo.Nombre);
                    comando.Parameters.AddWithValue("@direccion", modelo.Direccion);
                    comando.Parameters.AddWithValue("@telefono", modelo.Telefono);
                    comando.Parameters.AddWithValue("@cp", modelo.Cp);
                    comando.Parameters.AddWithValue("@id_ciudad", modelo.Id_ciudad);
                    comando.Parameters.AddWithValue("@id_tipo_usuario", modelo.Id_tipo_usuario);
                    comando.Parameters.AddWithValue("@contrasena", modelo.Contrasena);
                }
                else
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@usuario", modelo.Usuario);
                    comando.Parameters.AddWithValue("@nombre", modelo.Nombre);
                    comando.Parameters.AddWithValue("@direccion", modelo.Direccion);
                    comando.Parameters.AddWithValue("@telefono", modelo.Telefono);
                    comando.Parameters.AddWithValue("@cp", modelo.Cp);
                    comando.Parameters.AddWithValue("@id_ciudad", modelo.Id_ciudad);
                    comando.Parameters.AddWithValue("@id_tipo_usuario", modelo.Id_tipo_usuario);
                    comando.Parameters.AddWithValue("@contrasena", modelo.Contrasena);
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

        public void Eliminar(UsuariosModel modelo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("sp_usuarios_eliminar", cnn);
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
