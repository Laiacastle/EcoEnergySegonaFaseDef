using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySegonaFaseDef.Classes
{
    public class SistemaSolar : SistemaEnergia
    {
        private static int _contador = 0;
        public double HoresSol { get; set; }
        public override double CalcEnergia() => Math.Round(HoresSol * 1.5);
        public override void MostraInforme()
        {
            Console.WriteLine($"\t\t-------------------------------------------------------------------------");
            Console.WriteLine($"\t\t|        Data         |      Tipus      |    Hores de sol   | Instancia | ");
            Console.WriteLine(ToString());
        }
        public override string? ToString() => $"\t\t----------------------------------------------------------------------------\n\t\t| {Date.ToString()} |      {Type}      |       {HoresSol}          |     {CalcEnergia()}     |\n\t\t----------------------------------------------------------------------------";
        public override bool ConfParametre() => HoresSol >= 1;
        public SistemaSolar() 
        {
            Date = DateTime.Now;
            Type = "Solar";
        }
        public SistemaSolar(double horesSol)
        {
            Date = DateTime.Now;
            Type = "Solar";
            HoresSol = horesSol;
            _contador++;
        }
        public DateTime GetDate => this.Date;
        public SistemaSolar(double horesSol, DateTime data)
        {
            Date = data;
            Type = "Solar";
            HoresSol = horesSol;
            _contador++;
        }
    }
}
