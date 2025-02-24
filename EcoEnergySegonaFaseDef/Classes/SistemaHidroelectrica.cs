using EcoEnergySegonaFaseDef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySegonaFaseDef
{
    public class SistemaHidroelectrica : SistemaEnergia
    {
        private static int _contador = 0;
        public double CabalAigua { get; set; }
        public override double CalcEnergia() => Math.Round(this.CabalAigua * 9.8 * 0.8);
        public override void MostraInforme()
        {
            Console.WriteLine($"\t\t-------------------------------------------------------------------------");
            Console.WriteLine($"\t\t|        Data         |      Tipus      |   Cabal d'aigua   | Instancia |");
            Console.WriteLine(ToString());
        }
        public override string? ToString() => $"\t\t----------------------------------------------------------------------------\n\t\t| {this.Date.ToString()} | {this.Type}  |       {this.CabalAigua}          |     {CalcEnergia()}     |\n\t\t----------------------------------------------------------------------------";
        public override bool ConfParametre() => this.CabalAigua >= 20.0;
        public SistemaHidroelectrica(double cabalAigua)
        {
            Date = DateTime.Now;
            Type = "Hidroelectrica";
            CabalAigua = cabalAigua;
            _contador++;
        }
        public SistemaHidroelectrica(double cabalAigua, DateTime data)
        {
            Date = data;
            Type = "Hidoelectrica";
            CabalAigua = cabalAigua;
            _contador++;
        }
    }
}
