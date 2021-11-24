using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.Presentacion.Pages_Medicos
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
