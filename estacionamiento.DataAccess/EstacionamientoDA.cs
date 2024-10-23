using estacionamiento.Repositories;
using estacionamiento.Entities;
using estacionamiento.Models;
using System.Data.SqlClient;
using Dapper;

namespace estacionamiento.DataAccess
{
    public class EstacionamientoDA : CRUDRepository<EstacionamientoEntity>, EstacionamientoRepository
    {
        private readonly SqlConnection conn;
        public EstacionamientoDA(string? sqlConnection)
        {
            conn = new SqlConnection(sqlConnection);
        }

        public EstacionamientoEntity BuscarPorId(int id_obj)
        {

            try
            {
                using (conn)
                {
                    var query = $"SELECT * " +
                                $"FROM Meta WHERE id_meta = {id_obj}";

                    return conn.Query<EstacionamientoEntity>(query).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(int id_obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"DELETE " +
                                $"FROM Meta WHERE id_meta = {id_obj}";

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
                    var query = string.Empty;
                        //$"UPDATE Meta SET " +
                        //        $"nombre = '{obj.nombre}', " +
                        //        $"monto = {obj.monto}, " +
                        //        $"fecha_inicio = '{obj.fecha_inicio}', " +
                        //        $"fecha_final = '{obj.fecha_final}', " +
                        //        $"url_image = '{obj.url_image}' " +
                        //        $"FROM Meta " +
                        //        $"WHERE id_meta = {obj.id_meta}";
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
                    var query = string.Empty;
                        
                        //$"INSERT Meta VALUES ( " +
                        //        $"'{obj.nombre}', " +
                        //        $"'{obj.id_usuario}', " +
                        //        $"{obj.monto}, " +
                        //        $"'{obj.fecha_inicio}', " +
                        //        $"'{obj.fecha_final}', " +
                        //        $"'{obj.url_image}') " +
                        //        $"SELECT SCOPE_IDENTITY()";

                    return conn.Query<int>(query).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<EstacionamientoModel> ListarPorId(string id_usuario)
        {
            try
            {
                using (conn)
                {
                    var query = $"SELECT MET.id_meta, MET.nombre, MET.monto, DET.porcentaje_avance, MET.url_image " +
                                $"FROM meta MET " +
                                $"LEFT JOIN meta_detalle DET ON MET.id_meta = DET.id_meta AND DET.activo = 1 " +
                                $"WHERE MET.id_usuario = '{id_usuario}'";

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
