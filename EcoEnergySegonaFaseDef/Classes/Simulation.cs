namespace EcoEnergySegonaFaseDef.Classes
{
    public class Simulation: SistemaEnergia, ICalculEnergia
    {
        public double Value { get; set; }
        public string? Type { get; set; }
        public double CalcEnergia()
        {
            if(this.Value ==0 || this.Rati == 0)
            {
                return 0;
            }
            double result = 0;
            switch (this.Type)
            {
                case "Solar": result = this.Value * this.Rati; break;
                case "Eolica": result = Math.Pow(this.Value, 3) * this.Rati; break;
                case "Hidroelectrica": result = this.Value * 9.8 * this.Rati; break;
                default: result = this.Value * this.Rati; break;
            }
            return result;
        }
        public Simulation(double value, double rati, double preu, double cost,  DateTime date,string type)
        {
            Type = type;
            Preu = preu;
            Cost = cost;
            Value = value;
            Rati = rati;
            Date = date;
            
        }
        public Simulation(double value, double rati, string type)
        {
            Value = value;
            Rati = rati;
            Type = type;

        }
        public Simulation() { }
    }
}
