using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySegonaFaseDef.Classes
{
    public class SistemaHidroelectrica : SistemaEnergia
    {
        private static int _contador = 0;
        public double CabalAigua { get; set; }
        public override double CalcEnergia() => Math.Round(CabalAigua * 9.8 * Rati);
        public override void MostraInforme()
        {
            Console.WriteLine($"\t\t-------------------------------------------------------------------------");
            Console.WriteLine($"\t\t|        Data         |      Tipus      |   Cabal d'aigua   | Instancia |");
            Console.WriteLine(ToString());
        }
        public override string? ToString() => $"\t\t----------------------------------------------------------------------------\n\t\t| {Date.ToString()} | {Type}  |       {CabalAigua}          |     {CalcEnergia()}     |\n\t\t----------------------------------------------------------------------------";
        public override bool ConfParametre() => CabalAigua >= 20.0;
        public SistemaHidroelectrica(double cabalAigua, double rati, double preu, double cost)
        {
            Preu = preu;
            Cost = cost;
            Date = DateTime.Now;
            Type = Sistemes.Hidroelectrica;
            CabalAigua = cabalAigua;
            Rati = rati;
            _contador++;
        }
        public SistemaHidroelectrica(double cabalAigua, double rati, DateTime data)
        {
            Date = data;
            Type = Sistemes.Hidroelectrica;
            Rati = rati;
            CabalAigua = cabalAigua;
            _contador++;
        }
        public SistemaHidroelectrica() {
            Date = DateTime.Now;
            Type = Sistemes.Hidroelectrica;
            _contador++;
        }

        public SistemaHidroelectrica(double cabalAigua)
        {
            CabalAigua = cabalAigua;
        }
        public DateTime GetDate => this.Date;

        public override List<string> ToList()
        {

            List<string> list = base.ToList();
            list.Add(this.CabalAigua.ToString());
            return list;
        }
    }
}
