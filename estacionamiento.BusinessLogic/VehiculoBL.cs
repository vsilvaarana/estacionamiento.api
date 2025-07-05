using estacionamiento.DataAccess;
using estacionamiento.Entities;
using estacionamiento.Models;
using Microsoft.Extensions.Configuration;

namespace estacionamiento.BusinessLogic
{
    public class VehiculoBL
    {
        private readonly VehiculoDA vehiculoDA;

        public VehiculoBL(IConfiguration configuration)
        {
            vehiculoDA = new VehiculoDA(configuration.GetConnectionString("dbEstacionamiento"));
        }

        public int Registrar(VehiculoEntity metaEntity)
        {
            try
            {
                return vehiculoDA.Registrar(metaEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(VehiculoEntity usuarioEntity)
        {
            try
            {
                return vehiculoDA.Modificar(usuarioEntity);
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
                return vehiculoDA.Eliminar(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public VehiculoEntity BuscarPorId(int id)
        {
            try
            {
                return vehiculoDA.BuscarPorId(id);
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
                return vehiculoDA.ListarPorNombre(nombre, usuarioId);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
