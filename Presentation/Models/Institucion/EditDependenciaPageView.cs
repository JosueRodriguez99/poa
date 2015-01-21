using System.Collections.Generic;
using Application.Institucion.ViewModels;

namespace Presentation.Models.Institucion
{
    public class EditDependenciaPageView : CreateDependenciaPageView
    {
        public DependenciaViewModel Dependencia { get; private set; }

        public EditDependenciaPageView(List<UsuarioViewModel> jefes, List<UsuarioViewModel> analistas,
            List<DependenciaViewModel> dependencias, DependenciaViewModel dependencia)
            : base(jefes, analistas, dependencias)
        {
            Dependencia = dependencia;
        }
    }
}