namespace Domain.Poa
{
    public class ProgramacionActividad : ProgramacionMensual
    {
        public virtual IndicadorActividad Indicador { get; set; }

        public ProgramacionActividad()
        {
            Indicador = new IndicadorActividad();
        }
    }
}