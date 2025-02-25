using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySegonaFaseDef.Pages
{
    public class SimulationsModel : PageModel
    {
        public List<SistemaSolar> sistemaSolars { get; set; } = new List<SistemaSolar>();
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
                        var sistema = new SistemaSolar
                        {
                            HoresSol = Double.Parse(parts[0])
                        };
                        sistemaSolars.Add(sistema);
                    }
                }
            }
        }
    }
}