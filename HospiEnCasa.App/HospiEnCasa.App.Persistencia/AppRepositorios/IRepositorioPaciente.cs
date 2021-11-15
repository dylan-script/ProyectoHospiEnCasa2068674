using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.App.Persistencia{
    public interface IRepositorioPaciente{
        IEnumerable<Paciente> GetAll();
        Paciente Add(Paciente paciente);
        Paciente Update(Paciente paciente);
        void Delete(int id_paciente);
        Paciente Get(int id_paciente);
}
}
