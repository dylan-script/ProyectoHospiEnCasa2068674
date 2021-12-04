using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.Presentacion.Pages_Medicos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioMedico RepositorioMedico;

        public CreateModel(IRepositorioMedico RepositorioMedico)
        {
            this.RepositorioMedico = RepositorioMedico;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public Medico Medico { get; set; }

        public IActionResult OnPostSave()
        {
            if (ModelState.IsValid)
            {
                RepositorioMedico.Add (Medico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
