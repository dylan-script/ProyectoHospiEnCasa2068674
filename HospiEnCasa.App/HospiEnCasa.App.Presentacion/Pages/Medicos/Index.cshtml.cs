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
namespace HospiEnCasa.App.Presentacion.Pages_Medicos
{    
    public class IndexModel : PageModel{
        private readonly IRepositorioMedico RepositorioMedico;
        public IEnumerable<Medico> Medicos {get; set;}
        public IndexModel (IRepositorioMedico RepositorioMedico){
            this.RepositorioMedico = RepositorioMedico;
        }
        public void OnGet()
        {
            Medicos = RepositorioMedico.GetAll();
        }
    }
}
