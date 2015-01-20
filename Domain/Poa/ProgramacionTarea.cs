namespace Domain.Poa
{
    public class ProgramacionTarea : ProgramacionMensual
    {
        public virtual IndicadorTarea Indicador { get; set; }

        public ProgramacionTarea()
        {
            Indicador = new IndicadorTarea();
        }
    }
}