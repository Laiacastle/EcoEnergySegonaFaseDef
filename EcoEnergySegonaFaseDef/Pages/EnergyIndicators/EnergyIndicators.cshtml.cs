using CsvHelper;
using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace EcoEnergySegonaFaseDef.Pages.EnergyIndicators
{
    public class EnergyIndicatorsModel : PageModel
    {
        public List<IndicadorsEnergetics> indicators = new List<IndicadorsEnergetics>();
        public void OnGet()
        {
            string filePath = "./wwwroot/BaseFiles/indicadors_energetics_cat.csv";
            if (System.IO.File.Exists(filePath))
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                   
                    using (var reader = new StreamReader(filePath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        indicators = csv.GetRecords<IndicadorsEnergetics>().ToList();
                    }

                }
            }
            filePath = "./Files/indicadors_energetics_cat.json";
            if (System.IO.File.Exists(filePath))
            {
                string jsonString = System.IO.File.ReadAllText(filePath);
                List<IndicadorsEnergetics> indi = JsonSerializer.Deserialize<List<IndicadorsEnergetics>>(jsonString);
                indi.ForEach(n => indicators.Add(n));

            }
        }
    }
}
