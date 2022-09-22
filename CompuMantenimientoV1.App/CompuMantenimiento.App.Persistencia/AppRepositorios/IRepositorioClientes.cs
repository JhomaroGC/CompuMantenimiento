using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompuMantenimiento.App.Dominio.Entidades;


namespace CompuMantenimiento.App.Persistencia.AppRepositorios
{
    public interface IRepositorioClientes
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetClientePorId(int clienteId);
        Cliente UpdateCliente(Cliente clienteActualizado);
        Cliente AddCliente(Cliente nuevoCliente);
        
    }
}