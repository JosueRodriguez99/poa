using System.Collections.Generic;
using Application.Poa.Dto;
using Application.Poa.Mappers;
using Application.Poa.ViewModels;
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

        public void CrearProgramaEstrategico(ProgramaEstrategicoDto request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _repository.Insert(request.ToProgramaEstrategico());
        }

        public void ActualizarProgramaEstrategico(ProgramaEstrategicoDto request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _repository.Update(request.ToProgramaEstrategico());
        }

        public void EliminarProgramaEstrategico(int id)
        {
            _repository.Delete(id);
        }

        public ProgramaEstrategicoViewModel ObtenerProgramaEstrategicoPorId(int id)
        {
            return _repository.Get(id).ToViewModel();
        }

        [UnitOfWork]
        public List<ProgramaEstrategicoViewModel> ObtenerProgramasEstrategicos()
        {
            var programasEstrategicoViewModels = new List<ProgramaEstrategicoViewModel>();
            var programasEstrategicos = _repository.GetAll().ToList();

            foreach (var programaEstrategico in programasEstrategicos)
                programasEstrategicoViewModels.Add(programaEstrategico.ToViewModel());

            return programasEstrategicoViewModels;
        }

        [UnitOfWork]
        public List<ProgramaEstrategicoViewModel> ObtenerProgramasEstrategicosActivos()
        {
            var programasEStrategicoViewModels = new List<ProgramaEstrategicoViewModel>();
            var programasEstrategicos = _repository.GetAll().Where(x => x.Activo).ToList();

            foreach (var programaEstrategico in programasEstrategicos)
                programasEStrategicoViewModels.Add(programaEstrategico.ToViewModel());

            return programasEStrategicoViewModels;
        }
    }
}