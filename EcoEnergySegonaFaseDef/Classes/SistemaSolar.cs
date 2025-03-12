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
        public override double CalcEnergia() => Math.Round(HoresSol * Rati);
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
            Type = Sistemes.Solar;
            _contador++;
        }
        public SistemaSolar(double horesSol, double rati, double preu, double cost)
        {
            Preu = preu;
            Cost = cost;
            Date = DateTime.Now;
            Type = Sistemes.Solar;
            HoresSol = horesSol;
            Rati = rati;
            _contador++;
        }
        public DateTime GetDate => this.Date;
        public SistemaSolar(double horesSol, double rati, DateTime data)
        {
            Date = data;
            Rati= rati;
            Type = Sistemes.Solar;
            HoresSol = horesSol;
            _contador++;
        }
        public SistemaSolar(double horesSol)
        {
            HoresSol = horesSol;
        }
        public override List<string> ToList()
        {

            List<string> list = base.ToList();
            list.Add(this.HoresSol.ToString());
            return list;
        }
    }
}
