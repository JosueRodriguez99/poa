namespace Application.Institucion.Dto
{
    public class DependenciaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ResponsableId { get; set; }
        public int AnalistaId { get; set; }
        public int ReportaId { get; set; }
        public bool Activo { get; set; }
    }
}