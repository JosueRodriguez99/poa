using System;
using System.Collections.Generic;
using Application.Poa.ViewModels;

namespace Presentation.Models.Poa
{
    public class ActividadPageView
    {
        public List<ProductoViewModel> Productos { get; private set; }
        public List<ProgramaEstrategicoViewModel> ProgramasEstrategicos { get; private set; } 

        public ActividadPageView(List<ProductoViewModel> productos, List<ProgramaEstrategicoViewModel> programasEstrategicos )
        {
            if (productos == null) throw new ArgumentNullException("productos");
            if (programasEstrategicos == null) throw new ArgumentNullException("programasEstrategicos");

            Productos = productos;
            ProgramasEstrategicos = programasEstrategicos;
        }
    }
}