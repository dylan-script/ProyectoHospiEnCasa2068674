using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Transactions;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace HospiEnCasa.App.Presentacion.Pages_Medicos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMedico RepositorioMedico;

        public IEnumerable<Medico> Medicos { get; set; }

        public IndexModel(IRepositorioMedico RepositorioMedico)
        {
            this.RepositorioMedico = RepositorioMedico;
        }

        public void OnGet()
        {
            Medicos = RepositorioMedico.GetAll();
        }
    }
}
