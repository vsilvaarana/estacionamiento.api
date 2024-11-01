﻿using Dapper;
using estacionamiento.Entities;
using estacionamiento.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento.DataAccess
{
    public class ReservaDA : CRUDRepository<ReservaEntity>
    {
        private readonly SqlConnection conn;
        public ReservaDA(string? sqlConnection)
        {
            conn = new SqlConnection(sqlConnection);
        }

        public ReservaEntity BuscarPorId(int id)
        {
            try
            {
                using (conn)
                {
                    var query = $"SELECT * FROM reserva WHERE reservaid = {id}";

                    return conn.Query<ReservaEntity>(query).Single();
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
                    var query = $"delete reserva where reservaid= {id} ";

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

        public bool Modificar(ReservaEntity obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"update reserva set fecha='{obj.fecha.ToString("yyyy-MM-dd")}', tipo={obj.tipo}, estado={obj.estado}, " +
                        $"vehiculoid={obj.vehiculoId} " +
                        $"where reservaid= {obj.reservaId} ";

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

        public int Registrar(ReservaEntity obj)
        {
            try
            {
                using (conn)
                {
                    var query = $"insert reserva (usuarioid, estacionamientoid, vehiculoid, fecha, tipo, estado) " +
                        $"values ({obj.usuarioId}, {obj.estacionamientoId}, {obj.vehiculoId}, '{obj.fecha.ToString("yyyy-MM-dd")}', {obj.tipo}, {obj.estado} ) " +
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
