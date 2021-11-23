using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.App.Persistencia{
    public interface IRepositorioMedico{
        IEnumerable<Medico> GetAll();
        Medico Add(Medico medico);
        Medico Update(Medico medico);
        void Delete(int id_medico);
        Medico Get(int id_medico);
    }
}