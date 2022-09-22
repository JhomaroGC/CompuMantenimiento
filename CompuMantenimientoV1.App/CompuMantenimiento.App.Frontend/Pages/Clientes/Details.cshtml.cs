using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CompuMantenimiento.App.Persistencia.AppRepositorios;
using CompuMantenimiento.App.Dominio.Entidades;

namespace CompuMantenimiento.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioClientes repositorioClientes;
        public Cliente cliente { get; set; }

        public DetailsModel(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
        }

        public IActionResult OnGet(int clienteId)
        {
            cliente = repositorioClientes.GetClientePorId(clienteId);
            if(cliente == null)
            {
                return RedirectToPage(".NotFound");
            }
            else
                return Page();
        }
    }
}