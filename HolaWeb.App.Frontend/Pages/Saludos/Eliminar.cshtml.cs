using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolaWeb.App.Persistencia.AppRepositorios;
using HolaWeb.App.Dominio;
namespace HolaWeb.App.Frontend.Pages
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioSaludos repositorioSaludos;
        [BindProperty]
        public Saludo Saludo{get;set;}

        public EliminarModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos=repositorioSaludos;
        }
        public IActionResult OnGet(int SaludoId)
        {
            Saludo = repositorioSaludos.GetSaludoPorId(SaludoId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositorioSaludos.Delete(Saludo);
            return RedirectToPage("./List");
        }
    }
}
