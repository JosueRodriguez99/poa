using System.Collections.Generic;

namespace Application.Poa.Dto
{
    class EjecucionMensualDto
    {
        public int Mes { get; set; }
        public int Ejecucion { get; set; }
        public string Observaciones { get; set; }
        public List<string> ArchivosAdjuntos { get; set; }
    }
}
