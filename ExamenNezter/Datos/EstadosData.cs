using ExamenNezter.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNezter.Datos
{
    public class EstadosData : Conexion
    {
        public IEnumerable<EstadosModel> Consultar()
        {
            Conectar();
            List<EstadosModel> lista = new List<EstadosModel>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_estados_consultar", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    EstadosModel modelo = new EstadosModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Estado = lector[1] + ""
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

        public EstadosModel ConsultarID(int id)
        {
            EstadosModel modelo = new EstadosModel();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("sp_estados_consultar_id", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    modelo = new EstadosModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Estado = lector[1] + ""
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

        public void Guardar(EstadosModel modelo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("sp_estados_guardar", cnn);
            try
            {
                if (modelo.Id != 0)
                {
                    comando = new SqlCommand("sp_estados_modificar", cnn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", modelo.Id);
                    comando.Parameters.AddWithValue("@estado", modelo.Estado);
                }
                else
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@estado", modelo.Estado);
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

        public void Eliminar(EstadosModel modelo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("sp_estados_eliminar", cnn);
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
