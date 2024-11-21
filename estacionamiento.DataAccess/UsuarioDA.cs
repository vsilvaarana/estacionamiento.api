using estacionamiento.Repositories;
using estacionamiento.Entities;
using estacionamiento.Models;
using System.Data.SqlClient;
using Dapper;

namespace estacionamiento.DataAccess
{
    public class UsuarioDA : CRUDRepository<UsuarioEntity>, UsuarioRepository
    {
        private readonly SqlConnection conn;
        public UsuarioDA(string? sqlConnection)
        {
            conn = new SqlConnection(sqlConnection);
        }

        public UsuarioEntity BuscarPorId(int id)
        {
            try
            {
                using (conn)
                {
                    var query = $"SELECT * FROM usuario WHERE usuarioid = {id}";

                    return conn.Query<UsuarioEntity>(query).Single();
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
                    var query = $"delete usuario where usuarioid= {id} ";

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

        public bool Modificar(UsuarioEntity obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"update usuario set nombre='{obj.nombre}', apellido='{obj.apellido}', tipodocumento={obj.tipodocumento}, " +
                        $"documento='{obj.dni}', correo='{obj.email}', contrasena='{obj.password}', marca='{obj.marca}', placa='{obj.placa}' " +
                        $"where usuarioid= {obj.usuarioId} ";

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

        public int Registrar(UsuarioEntity obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"insert usuario (nombre, apellido, tipodocumento, documento, correo, contrasena, marca, placa) " +
                        $"values ('{obj.nombre}', '{obj.apellido}', {obj.tipodocumento}, '{obj.dni}', '{obj.email}', '{obj.password}', '{obj.marca}', '{obj.placa}' ) " +
                        $"SELECT SCOPE_IDENTITY()";

                    return conn.Query<int>(query).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<UsuarioModel> ListarPorNombre(string nombre)
        {
            try
            {
                using (conn)
                {
                    var query = $"SELECT * FROM usuario " +
                                $"WHERE nombre like '%{nombre}%'";

                    return conn.Query<UsuarioModel>(query);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
