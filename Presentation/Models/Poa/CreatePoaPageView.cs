using System;
using System.Collections.Generic;
using Application.Institucion.ViewModels;
using Application.Poa.ViewModels;

namespace Presentation.Models.Poa
{
    public class CreatePoaPageView
    {
        public List<DependenciaViewModel> Dependencias { get; private set; }
        public List<ProgramaEstrategicoViewModel> ProgramasEstrategicos { get; private set; }

        public CreatePoaPageView(List<DependenciaViewModel> dependencias, List<ProgramaEstrategicoViewModel> programasEstrategicos)
        {
            if (dependencias == null) throw new ArgumentNullException("dependencias");
            if (programasEstrategicos == null) throw new ArgumentNullException("programasEstrategicos");

            Dependencias = dependencias;
            ProgramasEstrategicos = programasEstrategicos;
        }
    }
}