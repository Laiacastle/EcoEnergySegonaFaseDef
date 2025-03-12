using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using System.Drawing;
using static EcoEnergySegonaFaseDef.Pages.WaterConsumption.WaterConsumesModel;
using System.Xml.Serialization;
using System.Xml;

namespace EcoEnergySegonaFaseDef.Pages.WaterConsumption
{
    public class AddConsumeModel : PageModel
    {
        [BindProperty]
        public ConsumAigua consum { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string filePath = "./Pages/Files/consum_aigua_cat_per_comarques.xml";
            XDocument doc;
            if (System.IO.File.Exists(filePath))
            {
                doc = XDocument.Load(filePath); // Cargar XML existente
            }
            else
            {
                doc = new XDocument(new XElement("Consums")); // Crear XML si no existe
            }
            XElement newDoc =
               new XElement("consum", // Elemento raíz
                   new XElement("Any", consum.Year),
                   new XElement("Codi_de_distrit", consum.Poblation),
                   new XElement("Distrit", consum.District),
                   new XElement("Població", consum.Poblation),
                   new XElement("Domini_de_xarxa", consum.Network),
                   new XElement("Fonts_propies", consum.FontsAndEcoActivities),
                   new XElement("Total", consum.Total),
                   new XElement("Consum_domestic_per_capità", consum.Consumption)

            );
            doc.Root.Add(newDoc);
            // Guardamos el archivo XML en la ruta especificada
            doc.Save(filePath);

            return RedirectToPage("WaterConsumes");
        }
    }
}
