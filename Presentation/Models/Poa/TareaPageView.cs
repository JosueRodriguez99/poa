using System;
using System.Collections.Generic;
using Application.Poa.ViewModels;
using Application.Institucion.ViewModels;

namespace Presentation.Models.Poa
{
    public class TareaPageView
    {
        public List<DependenciaViewModel> Dependencias { get; private set; }
        public List<ActividadViewModel> Actividades { get; private set; }

        public TareaPageView(List<DependenciaViewModel> dependencias, List<ActividadViewModel> actividades)
        {
            if (dependencias == null) throw new ArgumentNullException("dependencias");
            if (actividades == null) throw new ArgumentNullException("actividades");

            Dependencias = dependencias;
            Actividades = actividades;
        }
    }
}