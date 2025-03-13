using System.Runtime.ConstrainedExecution;

namespace EcoEnergySegonaFaseDef.Classes
{
    public class ConsumAigua
    {
        
        public int Year {get;set ;}
        public int CodeDistrict { get;set; }
        public string? District { get; set; }
        public int Poblation { get; set; }
        public int Network { get; set; }
        public int FontsAndEcoActivities { get; set; }
        public int Total { get; set; }
        public double Consumption { get; set; }

        public ConsumAigua(int year, int code,  string district, int poblation, int network, int fontsAndEcoActivities,  int total, double consumption)
        {
            Year = year;
            CodeDistrict = code;
            District = district;
            Poblation = poblation;
            Network = network;
            FontsAndEcoActivities = fontsAndEcoActivities;
            Total = total;
            Consumption = consumption;
          
        }
        public ConsumAigua() {  }
       
    }
}
