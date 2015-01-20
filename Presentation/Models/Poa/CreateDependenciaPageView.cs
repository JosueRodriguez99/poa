using System.Collections.Generic;
using Application.Institucion.ViewModel;

namespace Presentation.Models.Poa
{
    public class CreateDependenciaPageView
    {
        public List<UsuarioViewModel> JefeViewModels { get; set; }
        public List<UsuarioViewModel> AnalistaViewModels { get; set; }
        public List<DependenciaViewModel> DependenciaViewModels { get; set; }
    }
}