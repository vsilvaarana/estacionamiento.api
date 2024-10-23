using estacionamiento.DataAccess;
using estacionamiento.Entities;
using estacionamiento.Models;
using Microsoft.Extensions.Configuration;

namespace estacionamiento.BusinessLogic
{
    public class EstacionamientoBL
    {
        private readonly EstacionamientoDA estacionamientoDA;


        public EstacionamientoEntity BuscarPorId(int id_meta)
        {
            try
            {
                return estacionamientoDA.BuscarPorId(id_meta);
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
                return estacionamientoDA.ListarPorId(id_usuario);
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
    }
}
