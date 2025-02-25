using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySegonaFaseDef.Pages
{
    public class AddSimulationModel : PageModel
    {
        [BindProperty]
        public SistemaSolar Sistema { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string filePath = "./Pages/Files/simulations.csv";
            string sistemLine = $"{Sistema.HoresSol}, {Sistema.GetDate}\n";

            System.IO.File.AppendAllText(filePath, sistemLine);

            return RedirectToPage("Simulations");
        }
    }
}

