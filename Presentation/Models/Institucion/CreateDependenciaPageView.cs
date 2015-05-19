using System;
using System.Collections.Generic;
using Application.Institucion.ViewModels;

namespace Presentation.Models.Institucion
{
    public class CreateDependenciaPageView
    {
        public List<UsuarioViewModel> Jefes { get; private set; }
        public List<UsuarioViewModel> Analistas { get; private set; }
        public List<DependenciaViewModel> Dependencias { get; private set; }

        public CreateDependenciaPageView(List<UsuarioViewModel> jefes, List<UsuarioViewModel> analistas, List<DependenciaViewModel> dependencias)
        {
            if (jefes == null) throw new ArgumentNullException("jefes");
            if (analistas == null) throw new ArgumentNullException("analistas");
            if (dependencias == null) throw new ArgumentNullException("dependencias");

            Jefes = jefes;
            Analistas = analistas;
            Dependencias = dependencias;
        }
    }
}