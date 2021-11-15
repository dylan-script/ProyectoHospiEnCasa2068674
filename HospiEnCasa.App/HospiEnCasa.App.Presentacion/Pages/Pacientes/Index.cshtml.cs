using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Presentacion.Pages_Pacientes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        public IEnumerable<Paciente> Pacientes {get; set;}
        public IndexModel (IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente = RepositorioPaciente;
        }
        public void OnGet()
        {
            Pacientes = RepositorioPaciente.GetAll();
        }
    }
}
