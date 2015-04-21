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
    public class ActividadService : IActividadService
    {
        private readonly IActividadRepository _actividadRepository;

        public ActividadService(IActividadRepository actividadRepository)
        {
            if (actividadRepository == null) throw new ArgumentNullException("actividadRepository");
            _actividadRepository = actividadRepository;
        }

        [UnitOfWork]
        public void AgregarTarea(TareaDto dto)
        {
            var actividad = _actividadRepository.Get(dto.ActividadId);
            actividad.AgregarTarea(dto.ToEntity());
            _actividadRepository.Update(actividad);
        }

        [UnitOfWork]
        public void AgregarIndicador(int actividadId, IndicadorActividadDto dto)
        {
            var actividad = _actividadRepository.Get(actividadId);
            actividad.AgregarIndicador(dto.ToEntity());
            _actividadRepository.Update(actividad);
        }

        [UnitOfWork]
        public List<ActividadViewModel> ObtenerActividades(int poaId)
        {
            var actividadesViewModel = new List<ActividadViewModel>();
            var actividades = _actividadRepository.GetAll().Where(x => x.Poa.Id == poaId).ToList();
            foreach (var actividad in actividades)
             actividadesViewModel.Add(actividad.ToViewModel());   

            return actividadesViewModel;
        }
    }
}
