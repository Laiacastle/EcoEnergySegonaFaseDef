using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySegonaFaseDef.Pages
{
    public class AddSimulationModel : PageModel
    {
        public static string typeOfSimulation { get; set; } = "Hidroelectrica";

        [BindProperty]
        public SistemaSolar solar { get; set; }

        [BindProperty]
        public SistemaEolica eolica { get; set; }

        [BindProperty]
        public SistemaHidroelectrica hidro { get; set; }
        public string GetTypeSimulation => typeOfSimulation;
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string sistemLine;
            string filePath = "./Pages/Files/simulations.csv";
            if (!ModelState.IsValid)
            {
                return Page();
            }
            switch (typeOfSimulation)
            {
                case "Solar": 
                        sistemLine = $"{solar.HoresSol}, {solar.Rati},{solar.GetDate}, {solar.GetType()}\n";
                        System.IO.File.AppendAllText(filePath, sistemLine);
                        break;

                case "Eolica":  
                        sistemLine = $"{eolica.VelocitatVent}, {eolica.Rati},{eolica.GetDate}, {eolica.GetType()}\n";
                        System.IO.File.AppendAllText(filePath, sistemLine);
                        break;

                default:  
                        sistemLine = $"{hidro.CabalAigua}, {hidro.Rati},{hidro.GetDate}, {hidro.GetType()}\n";
                        System.IO.File.AppendAllText(filePath, sistemLine);
                        break;
                
            }
            
            return RedirectToPage("Simulations");
        }
    }
}

