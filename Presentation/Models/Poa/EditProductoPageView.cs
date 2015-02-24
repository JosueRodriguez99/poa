using System;
using System.Collections.Generic;
using Application.Poa.ViewModels;

namespace Presentation.Models.Poa
{
    public class EditProductoPageView
    {
        public EditProductoPageView(List<ProgramaEstrategicoViewModel> programasEstrategico, ProductoViewModel producto)
        {
            if (programasEstrategico == null) throw new ArgumentNullException("programasEstrategico");
            if (producto == null) throw new ArgumentNullException("producto");

            Producto = producto;
            ProgramasEstrategico = programasEstrategico;
        }

        public List<ProgramaEstrategicoViewModel> ProgramasEstrategico { get; private set; }
        public ProductoViewModel Producto { get; private set; }
    }
}