using System;

namespace HospiEnCasa.App.Dominio
{
    public class Medico : Persona
    {
        public string Especialidad {get; set;}
        public string Codigo {get; set;}
        ///Registro Único del Talento Humano
        public string RegistroRethus {get; set;}
    }
}

