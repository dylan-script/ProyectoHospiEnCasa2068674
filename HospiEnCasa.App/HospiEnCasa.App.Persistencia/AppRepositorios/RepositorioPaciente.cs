using System.Net.Mime;
using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.App.Persistencia{
    public class RepositorioPaciente : IRepositorioPaciente{
        private readonly AppContext _appContext;
        public RepositorioPaciente(AppContext appContext){
            _appContext = appContext;
        }
        public IEnumerable<Paciente> GetAll(){
            return _appContext.Pacientes;
        }
        public Paciente Add(Paciente paciente){
            var addPaciente = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return addPaciente.Entity;
        }
        public Paciente Update(Paciente paciente){
                throw new NotImplementedException();
        }
        public void Delete(int id_paciente){
                throw new NotImplementedException();
        }
        public Paciente Get(int id_paciente){
                throw new NotImplementedException();
        }
}
}
