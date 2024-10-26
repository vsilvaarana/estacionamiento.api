using System;

namespace estacionamiento.Repositories;

public interface CRUDRepository<T> where T : class
{
    int Registrar(T obj);
    bool Modificar(T obj);
    bool Eliminar(int id);
    T BuscarPorId(int id);
}
