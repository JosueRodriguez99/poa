using System;

namespace Application.Poa.ViewModels
{
    public class PoaViewModel
    {
        public int Id { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int Version { get; set; }
        public string Dependencia { get; set; }
        public string EstadoPoa { get; set; }
    }
}