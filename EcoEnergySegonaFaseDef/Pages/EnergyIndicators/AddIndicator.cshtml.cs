using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
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

            var json = System.IO.File.ReadAllText(filePath);
            List<IndicadorsEnergetics> indi = System.Text.Json.JsonSerializer.Deserialize<List<IndicadorsEnergetics>>(json);
            indi.Add(indicator);
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonActualizado = JsonConvert.SerializeObject(indi, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(filePath, jsonActualizado);
            return RedirectToPage("EnergyIndicators");
        }
    }
}
