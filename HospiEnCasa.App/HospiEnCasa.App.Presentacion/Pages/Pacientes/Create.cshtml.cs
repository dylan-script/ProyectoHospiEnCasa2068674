using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.Presentacion.Pages_Pacientes
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;

        public CreateModel(IRepositorioPaciente RepositorioPaciente)
        {
            this.RepositorioPaciente = RepositorioPaciente;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public Paciente Paciente { get; set; }

        public IActionResult OnPostSave()
        {
            if (ModelState.IsValid)
            {
                RepositorioPaciente.Add (Paciente);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
