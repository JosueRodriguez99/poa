using System.Collections.Generic;
using System.Linq;
using Application.Institucion.MapperExtensionMethods;
using Application.Institucion.Requests;
using Application.Institucion.Responses;
using Application.Institucion.ViewModel;
using Domain.Institucion;
using System;
using Infrastructure.NHibernate;

namespace Application.Institucion.Services
{
    public class DependenciaService : IDependenciaService
    {
        private readonly IDependenciaRepository _dependenciaRepository;
        private readonly IUsuarioRepository _usuarioRepository;

        public DependenciaService(IDependenciaRepository dependenciaRepository, IUsuarioRepository usuarioRepository)
        {
            if (dependenciaRepository == null) throw new ArgumentNullException("dependenciaRepository");
            if (usuarioRepository == null) throw new ArgumentNullException("usuarioRepository");
            _dependenciaRepository = dependenciaRepository;
            _usuarioRepository = usuarioRepository;
        }

        public void CrearDependencia(CrearDependenciaRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");
            var dependencia = request.ViewModel.ToEntity();
            dependencia.Responsable = _usuarioRepository.Get(request.ResponsableId);
            dependencia.Analista = _usuarioRepository.Get(request.AnalistaId);
            if (request.ReportaId != 0) dependencia.Reporta = _dependenciaRepository.Get(request.ReportaId);
            _dependenciaRepository.Insert(dependencia);
        }

        public void ActualizarDependencia(ActualizarDependenciaRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _dependenciaRepository.Update(request.ViewModel.ToEntity());
        }

        public void EliminarDependencia(EliminarDependenciaRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");
            _dependenciaRepository.Delete(request.Id);
        }

        [UnitOfWork]
        public ObtenerDependenciasResponse ObtenerDependencias()
        {
            var dependenciaViewModels = new List<DependenciaViewModel>();
            var dependencias = _dependenciaRepository.GetAll().ToList();

            foreach (var dependencia in dependencias)
                dependenciaViewModels.Add(dependencia.ToViewModel());

            return new ObtenerDependenciasResponse(dependenciaViewModels);
        }

        [UnitOfWork]
        public ObtenerDependenciasResponse ObtenerDependenciasActivas()
        {
            var dependenciaViewModels = new List<DependenciaViewModel>();
            var dependencias = _dependenciaRepository.GetAll().Where(x => x.Activo).ToList();

            foreach (var dependencia in dependencias)
                dependenciaViewModels.Add(dependencia.ToViewModel());

            return new ObtenerDependenciasResponse(dependenciaViewModels);
        }
    }
}