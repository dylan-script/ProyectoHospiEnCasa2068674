using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.App.Persistencia{
    public class RepositorioMedico : IRepositorioMedico{
        private readonly AppContext _appContext;
        public RepositorioMedico(AppContext appContext){
            _appContext = appContext;
        }
        public IEnumerable<Medico> GetAll(){
            return _appContext.Medicos;
        }
        public Medico Add(Medico medico){
            var addMedico = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return addMedico.Entity;
        }
        public Medico Update(Medico medico){
            throw new NotImplementedException();
        }
        public void Delete(int id_medico){
            throw new NotImplementedException();
        }
        public Medico Get(int id_medico){
            throw new NotImplementedException();
        }
    }
}