using estacionamiento.Repositories;
using estacionamiento.Entities;
using estacionamiento.Models;
using System.Data.SqlClient;
using Dapper;

namespace estacionamiento.DataAccess
{
    public class VehiculoDA : CRUDRepository<VehiculoEntity>, VehiculoRepository
    {
        private readonly SqlConnection conn;
        public VehiculoDA(string? sqlConnection)
        {
            conn = new SqlConnection(sqlConnection);
        }

        public VehiculoEntity BuscarPorId(int id)
        {
            try
            {
                using (conn)
                {
                    var query = $"SELECT * FROM vehiculo WHERE vehiculoid = {id}";

                    return conn.Query<VehiculoEntity>(query).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (conn)
                {
                    var query = $"delete vehiculo where vehiculoid= {id} ";

                    conn.Execute(query);

                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<VehiculoModel> ListarPorNombre(string nombre, int usuarioId)
        {
            try
            {
                using (conn)
                {
                    var query = $"SELECT * FROM vehiculo " +
                                $"WHERE usuarioid = {usuarioId} and" +
                                $" ('{nombre}' = '0' or  placa like '%{nombre}%')";

                    return conn.Query<VehiculoModel>(query);
                }
            }
            catch (Exception)
            {
                throw;

            }
        }

        public bool Modificar(VehiculoEntity obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"update vehiculo set marca='{obj.marca}', modelo='{obj.modelo}', placa='{obj.placa}' " +
                        $"where vehiculoid= {obj.vehiculoId} ";

                    conn.Execute(query);

                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Registrar(VehiculoEntity obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"insert vehiculo (marca, modelo, placa, usuarioid) " +
                        $"values ('{obj.marca}', '{obj.modelo}', '{obj.placa}', {obj.usuarioId}) " +
                        $"SELECT SCOPE_IDENTITY()";

                    return conn.Query<int>(query).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
