using System.Collections.Generic;
using System.Linq;
using Application.Institucion.Dto;
using Application.Institucion.Mappers;
using Application.Institucion.ViewModels;
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

        public void CrearDependencia(DependenciaDto request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var dependencia = new Dependencia();
            dependencia.Nombre = request.Nombre;
            dependencia.Responsable = _usuarioRepository.Get(request.ResponsableId);
            dependencia.Analista = _usuarioRepository.Get(request.AnalistaId);
            dependencia.Reporta = _dependenciaRepository.Get(request.DependenciaReportaId);
            dependencia.Activo = request.Activo;
            _dependenciaRepository.Insert(dependencia);
        }

        public void ActualizarDependencia(DependenciaDto request)
        {
            if (request == null) throw new ArgumentNullException("request");
            
            var dependencia = new Dependencia();
            dependencia.Id = request.Id;
            dependencia.Nombre = request.Nombre;
            dependencia.Responsable = _usuarioRepository.Get(request.ResponsableId);
            dependencia.Analista = _usuarioRepository.Get(request.AnalistaId);
            dependencia.Reporta = _dependenciaRepository.Get(request.DependenciaReportaId);
            dependencia.Activo = request.Activo;
            _dependenciaRepository.Update(dependencia);
        }

        public void EliminarDependencia(int id)
        {
            _dependenciaRepository.Delete(id);
        }

        [UnitOfWork]
        public List<DependenciaViewModel> ObtenerDependencias()
        {
            var dependenciaViewModels = new List<DependenciaViewModel>();
            var dependencias = _dependenciaRepository.GetAll().ToList();

            foreach (var dependencia in dependencias)
                dependenciaViewModels.Add(dependencia.ToViewModel());

            return dependenciaViewModels;
        }

        [UnitOfWork]
        public List<DependenciaViewModel> ObtenerDependenciasActivas()
        {
            var dependenciaViewModels = new List<DependenciaViewModel>();
            var dependencias = _dependenciaRepository.GetAll().Where(x => x.Activo).ToList();

            foreach (var dependencia in dependencias)
                dependenciaViewModels.Add(dependencia.ToViewModel());

            return dependenciaViewModels;
        }
    }
}