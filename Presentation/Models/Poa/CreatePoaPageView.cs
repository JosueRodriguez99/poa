using System;
using System.Collections.Generic;
using Application.Poa.ViewModels;

namespace Presentation.Models.Poa
{
    public class CreatePoaPageView
    {
        public PoaViewModel Poas { get; private set; }
        public List<ProgramaEstrategicoViewModel> ProgramasEstrategicos { get; private set; }

        public CreatePoaPageView(PoaViewModel poas, List<ProgramaEstrategicoViewModel> programasEstrategicos)
        {
            if (poas == null) throw new ArgumentNullException("poas");
            if (programasEstrategicos == null) throw new ArgumentNullException("programasEstrategicos");

            Poas = poas;
            ProgramasEstrategicos = programasEstrategicos;
        }
    }
}