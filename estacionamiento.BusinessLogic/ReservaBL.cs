﻿using estacionamiento.DataAccess;
using estacionamiento.Entities;
using estacionamiento.Models;
using Microsoft.Extensions.Configuration;

namespace estacionamiento.BusinessLogic
{
    public class ReservaBL
    {
        private readonly ReservaDA reservaDA;

        public ReservaBL(IConfiguration configuration)
        {
            reservaDA = new ReservaDA(configuration.GetConnectionString("dbEstacionamiento"));
        }

        public int Registrar(ReservaEntity metaEntity)
        {
            try
            {
                return reservaDA.Registrar(metaEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(ReservaEntity usuarioEntity)
        {
            try
            {
                return reservaDA.Modificar(usuarioEntity);
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
                return reservaDA.Eliminar(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ReservaEntity BuscarPorId(int id)
        {
            try
            {
                return reservaDA.BuscarPorId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ReservaModel> ListarPorEmpleado(int empleadoId) {
            try
            {
                return reservaDA.ListarPorEmpleado(empleadoId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
