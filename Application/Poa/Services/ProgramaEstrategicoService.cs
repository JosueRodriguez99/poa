using Application.Poa.MapperExtensionMethods;
using Application.Poa.Requests;
using Application.Poa.Responses;
using Domain.Poa;
using Infrastructure.NHibernate;
using System;
using System.Linq;

namespace Application.Poa.Services
{
    public class ProgramaEstrategicoService : IProgramaEstrategicoService
    {
        private readonly IProgramaEstrategicoRepository _repository;

        public ProgramaEstrategicoService(IProgramaEstrategicoRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            _repository = repository;
        }

        public void CrearProgramaEstrategico(CrearProgramaEstrategicoRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _repository.Insert(request.ProgramaEstrategicoViewModel.ToEntity());
        }

        public void ActualizarProgramaEstrategico(ActualizarProgramaEstrategicoRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");
            
            throw new NotImplementedException();
        }

        public void EliminarProgramaEstrategico(EliminarProgramaEstrategicoRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _repository.Delete(request.ProgramaEstrategicoId);
        }

        public ObtenerProgramaEstrategicoPorIdResponse ObtenerProgramaEstrategicoPorId(int id)
        {
            var response = new ObtenerProgramaEstrategicoPorIdResponse();
            response.ProgramaEstrategico = _repository.Get(id).ToViewModel();
            return response;
        }

        [UnitOfWork]
        public ObtenerProgramasEstrategicosResponse ObtenerProgramasEstrategicos()
        {
            var response = new ObtenerProgramasEstrategicosResponse();
            var programasEstrategicosGuardados = _repository.GetAll().ToList();

            foreach (var programaEstrategico in programasEstrategicosGuardados)
                response.ProgramasEstrategicos.Add(programaEstrategico.ToViewModel());

            return response;
        }

        [UnitOfWork]
        public ObtenerProgramasEstrategicosResponse ObtenerProgramasEstrategicosActivos()
        {
            var response = new ObtenerProgramasEstrategicosResponse();
            var programasEstrategicosActivos = _repository.GetAll().Where(x => x.Activo).ToList();

            foreach (var programaEstrategico in programasEstrategicosActivos)
                response.ProgramasEstrategicos.Add(programaEstrategico.ToViewModel());

            return response;
        }
    }
}