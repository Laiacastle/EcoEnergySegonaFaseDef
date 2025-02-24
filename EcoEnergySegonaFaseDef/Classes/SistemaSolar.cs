using EcoEnergySegonaFaseDef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySegonaFaseDef
{
    public class SistemaSolar : SistemaEnergia
    {
        private static int _contador = 0;
        public double HoresSol { get; set; }
        public override double CalcEnergia() => Math.Round(this.HoresSol * 1.5);
        public override void MostraInforme()
        {
            Console.WriteLine($"\t\t-------------------------------------------------------------------------");
            Console.WriteLine($"\t\t|        Data         |      Tipus      |    Hores de sol   | Instancia | ");
            Console.WriteLine(ToString());
        }
        public override string? ToString() => $"\t\t----------------------------------------------------------------------------\n\t\t| {this.Date.ToString()} |      {this.Type}      |       {this.HoresSol}          |     {CalcEnergia()}     |\n\t\t----------------------------------------------------------------------------";
        public override bool ConfParametre() => this.HoresSol >= 1;
        public SistemaSolar(double horesSol)
        {
            Date = DateTime.Now;
            Type = "Solar";
            HoresSol = horesSol;
            _contador++;
        }
        public SistemaSolar(double horesSol, DateTime data)
        {
            Date = data;
            Type = "Solar";
            HoresSol = horesSol;
            _contador++;
        }
    }
}
