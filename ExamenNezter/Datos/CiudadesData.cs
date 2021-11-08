using ExamenNezter.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNezter.Datos
{
    public class CiudadesData : Conexion
    {
        public IEnumerable<CiudadesModel> Consultar()
        {
            Conectar();
            List<CiudadesModel> lista = new List<CiudadesModel>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_ciudades_consultar",cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CiudadesModel modelo = new CiudadesModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Ciudad = lector[1] + "",
                        Id_estado = int.Parse(lector[2] + "")
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

        public CiudadesModel ConsultarID(int id)
        {
            CiudadesModel modelo = new CiudadesModel();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("sp_ciudades_consultar_id", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    modelo = new CiudadesModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Ciudad = lector[1] + "",
                        Id_estado = int.Parse(lector[2] + "")
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

        public void Guardar(CiudadesModel modelo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("sp_ciudades_guardar", cnn);
            try
            {
                if (modelo.Id != 0)
                {
                    comando = new SqlCommand("sp_ciudades_modificar", cnn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", modelo.Id);
                    comando.Parameters.AddWithValue("@ciudad", modelo.Ciudad);
                    comando.Parameters.AddWithValue("@id_estado", modelo.Id_estado);
                }
                else
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@ciudad", modelo.Ciudad);
                    comando.Parameters.AddWithValue("@id_estado", modelo.Id_estado);
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

        public void Eliminar(CiudadesModel modelo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("sp_ciudades_eliminar", cnn);
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
