using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
namespace EcoEnergySegonaFaseDef.Pages.EnergyIndicators
{
    public class AddIndicatorModel : PageModel
    {
        [BindProperty]
        public IndicadorsEnergetics indicator {get;set;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string filePath = "./Pages/Files/indicadors_energetics_cat.json";
            var options = new JsonSerializerOptions { WriteIndented = true }; 
            string jsonString = JsonSerializer.Serialize(indicator, options);
            System.IO.File.AppendAllText(filePath, jsonString);
            return RedirectToPage("EnergyIndicators");
        }
    }
}
