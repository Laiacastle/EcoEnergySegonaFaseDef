using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySegonaFaseDef.Pages.Simulations
{
    public class SimulationsModel : PageModel
    {
        public List<SistemaEnergia> sistems { get; set; } = new List<SistemaEnergia>();
        public List<SistemaSolar> solaris { get; set; } = new List<SistemaSolar>();
        public List<SistemaEolica> eolics { get; set; } = new List<SistemaEolica>();
        public List<SistemaHidroelectrica> hidros { get; set; } = new List<SistemaHidroelectrica>();

        public void OnGet()
        {
            string filePath = "./Pages/Files/simulations.csv";
            if (System.IO.File.Exists(filePath))
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {

                        switch (parts[2])
                        {
                            case "Solar":
                                var solar = new SistemaSolar
                                {
                                    HoresSol = double.Parse(parts[0]),
                                    Rati = double.Parse(parts[1])
                                };
                                sistems.Add(solar);
                                solaris.Add(solar);
                                break;

                            case "Eolica":
                                var eolica = new SistemaEolica
                                {
                                    VelocitatVent = double.Parse(parts[0]),
                                    Rati = double.Parse(parts[1])
                                };
                                sistems.Add(eolica);
                                eolics.Add(eolica);
                                break;

                            default:
                                var hidro = new SistemaHidroelectrica
                                {
                                    CabalAigua = double.Parse(parts[0]),
                                    Rati = double.Parse(parts[1])
                                };
                                sistems.Add(hidro);
                                hidros.Add(hidro);
                                break;

                        }



                    }
                }
            }
        }
    }
}