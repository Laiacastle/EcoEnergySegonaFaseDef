using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySegonaFaseDef.Classes
{
    public class SistemaEolica : SistemaEnergia
    {
        private static int _contador = 0;
        public double VelocitatVent { get; set; }
        public override double CalcEnergia() => Math.Round(Math.Pow(VelocitatVent, 3) * Rati);
        public override void MostraInforme()
        {
            Console.WriteLine($"\t\t-------------------------------------------------------------------------");
            Console.WriteLine($"\t\t|        Data         |      Tipus      | Velocitat de vent | Instancia | ");
            Console.WriteLine(ToString());
        }
        public override string? ToString() => $"\t\t----------------------------------------------------------------------------\n\t\t| {Date.ToString()} |      {Type}     |       {VelocitatVent}          |     {CalcEnergia()}     |\n\t\t----------------------------------------------------------------------------";
        public override bool ConfParametre() => VelocitatVent >= 5.0;

        public SistemaEolica(double velocitatVent, double rati, double preu, double cost)
        {
            Preu = preu;
            Cost = cost;
            Date = DateTime.Now;
            Type = Sistemes.Eolica;
            VelocitatVent = velocitatVent;
            Rati = rati;
            _contador++;
        }
        public SistemaEolica() {
            Date = DateTime.Now;
            Type = Sistemes.Eolica;
            _contador++;
        }
        public SistemaEolica(double velocitatVent, double rati, DateTime data)
        {
            Date = data;
            Type = Sistemes.Eolica;
            VelocitatVent = velocitatVent;
            Rati= rati;
            _contador++;
        }

        public SistemaEolica(double velocitatVent)
        {
            VelocitatVent = velocitatVent;
        }

        public DateTime GetDate => this.Date;

        public override List<string> ToList()
        {

            List<string> list = base.ToList();
            list.Add(this.VelocitatVent.ToString());
            return list;
        }

    }
}
