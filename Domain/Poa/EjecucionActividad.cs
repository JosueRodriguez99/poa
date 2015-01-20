namespace Domain.Poa
{
    public class EjecucionActividad : EjecucionMensual
    {
        public virtual IndicadorActividad Indicador { get; set; }

        public EjecucionActividad()
        {
            Indicador = new IndicadorActividad();
        }
    }
}