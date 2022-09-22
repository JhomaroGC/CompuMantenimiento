using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompuMantenimiento.App.Persistencia.AppRepositorios;
using CompuMantenimiento.App.Dominio.Entidades;

namespace CompuMantenimiento.App.Frontend.Pages
{
    public class listModelClientes : PageModel
    {
        
        private readonly IRepositorioClientes repositorioClientes;
        public IEnumerable<Cliente> clientes {get; set; }

        public listModelClientes(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
        }

        public void OnGet()
        {
            clientes = repositorioClientes.GetAll();
        }
    }
}