using Domain.Poa;

namespace Application.Poa.Dto
{
    public class PresupuestoDto
    {
        public int Id { get; set; }
        public int ConceptoPresupuestoId { get; set; }
        public double Monto { get; set; }
        public int ProgramaEstrategicoId { get; set; }
        public int PoaId { get; set; }
    }
}
