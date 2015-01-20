using System.Collections.Generic;
using Application.Poa.ViewModels;

namespace Presentation.Models.Poa
{
    public class EditProductoPageView
    {
        public List<ProgramaEstrategicoViewModel> ProgramaEstrategicoViewModels { get; set; }
        public ProductoViewModel ProductoViewModel { get; set; }
    }
}