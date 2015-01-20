namespace Domain.Poa
{
    public class EjecucionTarea : EjecucionMensual
    {
        public virtual IndicadorTarea Indicador { get; set; }

        public EjecucionTarea()
        {
            Indicador = new IndicadorTarea();
        }
    }
}