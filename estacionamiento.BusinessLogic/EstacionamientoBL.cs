﻿using estacionamiento.DataAccess;
using estacionamiento.Entities;
using estacionamiento.Models;
using Microsoft.Extensions.Configuration;

namespace estacionamiento.BusinessLogic
{
    public class EstacionamientoBL
    {
        private readonly EstacionamientoDA estacionamientoDA;

        public EstacionamientoBL(IConfiguration configuration)
        {
            estacionamientoDA = new EstacionamientoDA(configuration.GetConnectionString("dbEstacionamiento"));
        }
        public EstacionamientoEntity BuscarPorId(int estacionamientoId)
        {
            try
            {
                return estacionamientoDA.BuscarPorId(estacionamientoId);
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
                return estacionamientoDA.ListarPorPiso(piso);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public int Registrar(EstacionamientoEntity metaEntity)
        {
            try
            {
                return estacionamientoDA.Registrar(metaEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(EstacionamientoEntity metaEntity)
        {
            try
            {
                return estacionamientoDA.Modificar(metaEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(int id_meta)
        {
            try
            {
                return estacionamientoDA.Eliminar(id_meta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EstacionamientoEntity BuscarEstacionamientoLibre()
        {
            try
            {
                return estacionamientoDA.BuscarEstacionamientoLibre();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
