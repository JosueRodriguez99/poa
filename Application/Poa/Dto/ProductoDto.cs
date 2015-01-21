namespace Application.Poa.Dto
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int ProgramaEstrategicoId { get; set; }
        public bool Activo { get; set; }
    }
}