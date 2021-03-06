﻿using System;
using System.Collections.Generic;
using Application.Poa.ViewModels;
using Application.Institucion.ViewModels;

namespace Presentation.Models.Poa
{
    public class ActividadPageView
    {
        public List<ProductoViewModel> Productos { get; private set; }
        public List<DependenciaViewModel> Dependencias { get; private set; }

        public ActividadPageView(List<ProductoViewModel> productos, List<DependenciaViewModel> dependencias)
        {
            if (productos == null) throw new ArgumentNullException("productos");
            if (dependencias == null) throw new ArgumentNullException("dependencias");

            Productos = productos;
            Dependencias = dependencias;
        }
    }
}