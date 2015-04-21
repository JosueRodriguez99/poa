using System;
using System.Collections.Generic;
using System.Linq;
using Application.Poa.Dto;
using Application.Poa.Mappers;
using Application.Poa.ViewModels;
using Domain.Poa;
using Infrastructure.NHibernate;

namespace Application.Poa.Services
{
    public class TareaService : ITareaService
    {
        protected readonly ITareaRepository TareaRepository;
        protected readonly IActividadRepository ActividadRepository;

        public TareaService(ITareaRepository tareaRepository, IActividadRepository actividadRepository)
        {
            if (actividadRepository == null) throw new ArgumentNullException("actividadRepository");
            if (tareaRepository == null) throw new ArgumentNullException("tareaRepository");

            TareaRepository = tareaRepository;
            ActividadRepository = actividadRepository;
        }

        [UnitOfWork]
        public void CrearTarea(TareaDto request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var actividad = ActividadRepository.Get(request.ActividadId);
            actividad.AgregarTarea(request.ToEntity());
            ActividadRepository.Update(actividad);
        }

        [UnitOfWork]
        public void ActualizarTarea(TareaDto request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var tarea = request.ToEntity();
            tarea.Actividad = ActividadRepository.Get(request.ActividadId);
            TareaRepository.Update(tarea);
        }

        public void EliminarTarea(int id)
        {
            TareaRepository.Delete(id);
        }

        public TareaViewModel ObtenerTareaPorId(int id)
        {
            return TareaRepository.Get(id).ToViewModel();
        }

        [UnitOfWork]
        public List<TareaViewModel> ObtenerTareas()
        {
            var tareaViewModels = new List<TareaViewModel>();
            var tareasGuardadas = TareaRepository.GetAll().ToList();

            foreach (var tareaGuardada in tareasGuardadas)
                tareaViewModels.Add(tareaGuardada.ToViewModel());

            return tareaViewModels;
        }

        [UnitOfWork]
        public List<TareaViewModel> ObtenerTareasActivos()
        {
            throw new NotImplementedException();
        }
    }
}
