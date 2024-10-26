using estacionamiento.Repositories;
using estacionamiento.Entities;
using estacionamiento.Models;
using System.Data.SqlClient;
using Dapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace estacionamiento.DataAccess
{
    public class EstacionamientoDA : CRUDRepository<EstacionamientoEntity>, EstacionamientoRepository
    {
        private readonly SqlConnection conn;
        public EstacionamientoDA(string? sqlConnection)
        {
            conn = new SqlConnection(sqlConnection);
        }

        public EstacionamientoEntity BuscarPorId(int id)
        {

            try
            {
                using (conn)
                {
                    var query = $"SELECT * " +
                                $"FROM estacionamiento WHERE estacionamientoid = {id}";

                    return conn.Query<EstacionamientoEntity>(query).Single();
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
                    var query = $"DELETE " +
                                $"FROM estacionamiento WHERE estacionamientoid = {id}";

                    conn.Query(query);
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

       
        public bool Modificar(EstacionamientoEntity obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"update estacionamiento set piso='{obj.piso}', espacio='{obj.espacio}', tipo={obj.tipo}, " +
                       $"estado={obj.estado} " +
                       $"where estacionamientoid= {obj.estacionamientoId} ";

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

        public int Registrar(EstacionamientoEntity obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"insert estacionamiento (piso, espacio, tipo, estado) " +
                        $"values ('{obj.piso}', '{obj.espacio}', {obj.tipo}, {obj.estado} ) " +
                        $"SELECT SCOPE_IDENTITY()";


                    return conn.Query<int>(query).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<EstacionamientoModel> ListarPorPiso(string piso)
        {
            try
            {
                using (conn)
                {
                    var query = $"SELECT * FROM estacionamiento " +
                                $"WHERE piso = '{piso}'";

                    return conn.Query<EstacionamientoModel>(query);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
