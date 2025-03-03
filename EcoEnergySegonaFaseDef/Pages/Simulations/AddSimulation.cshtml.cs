using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySegonaFaseDef.Pages.Simulations
{
    public class AddSimulationModel : PageModel
    {

        [BindProperty]
        public SistemaEnergia sistema { get; set; }
        [BindProperty]
        public SistemaSolar solar { get; set; }
        [BindProperty]
        public SistemaEolica eolica { get; set; }
        [BindProperty]
        public SistemaHidroelectrica hidro { get; set; }

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
            if (!hidro.ConfParametre())
            {
                ModelState.AddModelError("SistemaHidroelectrica.CabalAigua", "El cabal d'aigua ha de ser major a 19");
                return Page();
            }
            if (!eolica.ConfParametre())
            {
                ModelState.AddModelError("SistemaEolica.VelocitatVent", "La velocitat del vent ha de ser major a 5");
                return Page();
            }
            if (!solar.ConfParametre())
            {
                ModelState.AddModelError("SistemaSolar.HoresSol", "Les hodes de sal han de ser major a 0");
                return Page();
            }
            switch (sistema.GetType())
            {
                case "Solar": sistemLine = $"{solar.HoresSol},{sistema.Rati},{sistema.Preu},{sistema.Cost},{sistema.GetDate},{sistema.GetType()}\n";break;
                case "Eolica": sistemLine = $"{eolica.VelocitatVent},{sistema.Rati},{sistema.Preu},{sistema.Cost},{sistema.GetDate},{sistema.GetType()}\n"; break;
                case "Hidroelectrica": sistemLine = $"{hidro.CabalAigua},{sistema.Rati},{sistema.Preu},{sistema.Cost},{sistema.GetDate},{sistema.GetType()}\n"; break;
                default: sistemLine = $"{solar.HoresSol},{sistema.Rati},{sistema.Preu},{sistema.Cost},{sistema.GetDate},{sistema.GetType()}\n"; break;
            }
            
            System.IO.File.AppendAllText(filePath, sistemLine);
                  
            return RedirectToPage("Simulations");
        }
    }
}

