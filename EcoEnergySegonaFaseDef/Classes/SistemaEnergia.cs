namespace EcoEnergySegonaFaseDef
{
    public abstract class SistemaEnergia : ICalculEnergia
    {
        protected DateTime Date { get; set; }
        protected string? Type { get; set; }


        public virtual bool ConfParametre() { return true; }
        public virtual double CalcEnergia() { return 0.0; }
        public virtual void MostraInforme() { }

    }
}