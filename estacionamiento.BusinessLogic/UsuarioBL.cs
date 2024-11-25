using estacionamiento.DataAccess;
using estacionamiento.Entities;
using estacionamiento.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento.BusinessLogic
{
    public class UsuarioBL
    {
        private readonly UsuarioDA usuarioDA;

        public UsuarioBL(IConfiguration configuration)
        {
            usuarioDA = new UsuarioDA(configuration.GetConnectionString("dbEstacionamiento"));
        }

        public int Registrar(UsuarioEntity metaEntity)
        {
            try
            {
                return usuarioDA.Registrar(metaEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(UsuarioEntity usuarioEntity)
        {
            try
            {
                return usuarioDA.Modificar(usuarioEntity);
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
                return usuarioDA.Eliminar(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UsuarioEntity BuscarPorId(int id)
        {
            try
            {
                return usuarioDA.BuscarPorId(id);
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
                return usuarioDA.ListarPorNombre(nombre);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public UsuarioEntity ValidarCredenciales(string email, string password)
        {
            try
            {
                return usuarioDA.ValidarCredenciales(email, password);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
