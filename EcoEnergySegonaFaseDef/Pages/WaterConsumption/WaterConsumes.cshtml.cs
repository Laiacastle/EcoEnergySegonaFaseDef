using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Serialization;
using static EcoEnergySegonaFaseDef.Pages.WaterConsumption.WaterConsumesModel;
using System.Reflection.PortableExecutable;
using System.Xml;

namespace EcoEnergySegonaFaseDef.Pages.WaterConsumption
{
    public class WaterConsumesModel : PageModel
    {
        [XmlRoot("Consums")]
        public class Consums
        {
            [XmlElement("consum")]
            public List<ConsumAigua> ConsumList { get; set; } = new List<ConsumAigua>();
        }
        public List<ConsumAigua> consums { get; set; } = new List<ConsumAigua>();
        public List<ConsumAigua> deuMunicipis = new List<ConsumAigua>();
        public Dictionary<string?, double> consumMitja { get; set; } = new Dictionary<string?, double>();
        public List<ConsumAigua> consumsSuspitosos { get; set; } = new List<ConsumAigua>();
        public List<string> consumsCreixents { get; set; } = new List<string>();
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

            
                //Deu municipis amb mes consum
                List<ConsumAigua> ordenat = consums.OrderByDescending(n => n.Consumption).Take(10).ToList();
                ordenat.ForEach(deuMunicipis.Add);

                //Avg per municipis
                consumMitja = consums.
                     GroupBy(r => r.District)
                    .ToDictionary(g => g.Key, g => g.Average(r => r.Total))
                    .OrderByDescending(kvp => kvp.Value)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                //consusms sospitosos exessivament grans
                foreach (var i in consums)
                {
                    if (i.Total.ToString().Length > 6)
                    {
                        consumsSuspitosos.Add(i);
                    }
                }

                //Consums creixents en el ultims 5 anys

                consumsCreixents = consums
                .GroupBy(r => r.District)
                .Where(g => g.Count() >= 5)
                .Select(g => new
                {
                    District = g.Key,
                    Trend = g.OrderBy(r => r.Year).Select(r => r.Total).ToList()
                })
                .Where(g => g.Trend.Zip(g.Trend.Skip(1), (a, b) => b > a).All(x => x))
                .Select(g => g.District)
                .ToList();
            }
        }
    }

