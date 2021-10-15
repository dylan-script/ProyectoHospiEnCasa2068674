using System;
namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        
        public int Id {get; set;}
        public String Nombre   {get; set;}
        public String Apellido {get; set;}
        public String NumeroDocumento   {get; set;}     
        public String NumeroTelefonico   {get; set;}
        public Genero Genero  {get; set;}
    }        
}

