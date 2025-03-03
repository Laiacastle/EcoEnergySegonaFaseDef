using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySegonaFaseDef.Pages.WaterConsumption
{
    public class WaterConsumesModel : PageModel
    {
        public List<ConsumAigua> consums = new List<ConsumAigua>();
        public void OnGet()
        {
            string filePath = "./wwwroot/BaseFiles/consum_aigua_cat_per_comarques.csv";
            if (System.IO.File.Exists(filePath))
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    using (var reader = new StreamReader(filePath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        consums = csv.GetRecords<ConsumAigua>().ToList();
                    }
                }
            }
        }
    }
}
