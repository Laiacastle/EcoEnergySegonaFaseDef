namespace EcoEnergySegonaFaseDef.Classes
{
    public abstract class SistemaEnergia : ICalculEnergia
    {
        protected DateTime Date { get; set; }
        protected string? Type { get; set; }
        public double Rati { get; set; }

        public virtual bool ConfParametre() { return true; }
        public virtual double CalcEnergia() { return 0.0; }
        public virtual void MostraInforme() { }

        public virtual DateTime GetDate => this.Date;
        public virtual double GetRati() => Rati;
        public virtual string GetType() => Type;
        public virtual List<string> ToList()
        {
            return new List<string> { this.Date.ToString(), this.Type, this.Rati.ToString() }; 
        }

    }
}