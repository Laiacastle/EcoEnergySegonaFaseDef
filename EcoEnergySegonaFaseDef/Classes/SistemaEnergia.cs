namespace EcoEnergySegonaFaseDef.Classes
{
    public enum Sistemes
    {
        Solar,
        Eolica,
        Hidroelectrica
    }
    public class SistemaEnergia : ICalculEnergia
    {
        
        public DateTime Date { get; set; }
        public Sistemes Type { get; set; }
        public double Rati { get; set; }
        public double Preu { get; set; }
        public double Cost { get; set; }

        public virtual bool ConfParametre() { return true; }
        public virtual double CalcEnergia() { return 0.0; }
        public virtual void MostraInforme() { }

        public virtual DateTime GetDate => this.Date;
        public virtual double GetRati() => Rati;
        public virtual string GetType() => Type.ToString();
        public virtual List<string> ToList()
        {
            return new List<string> { this.Date.ToString(), this.Type.ToString(), this.Rati.ToString() }; 
        }

    }
}