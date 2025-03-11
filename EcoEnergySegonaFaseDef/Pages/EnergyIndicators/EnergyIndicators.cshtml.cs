using CsvHelper;
using EcoEnergySegonaFaseDef.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace EcoEnergySegonaFaseDef.Pages.EnergyIndicators
{
    public class EnergyIndicatorsModel : PageModel
    {
        public List<IndicadorsEnergetics> indicators = new List<IndicadorsEnergetics>();
        public List<IndicadorsEnergetics> produccioNetaSupTres = new List<IndicadorsEnergetics>();
        public List<IndicadorsEnergetics> consumGasolinaSupCen = new List<IndicadorsEnergetics>();
        public Dictionary<int, double> mitjanaProduccNeta = new Dictionary<int, double>();
        public List<IndicadorsEnergetics> demandaEleSupCuatr = new List<IndicadorsEnergetics>();

        private double ConvertDouble(string value)
        {
            if (double.TryParse(value, out double result))
            {
                return result;
            }
            return 0; // Default value if parsing fails
        }
        public void OnGet()
        {
            string filePath = "./wwwroot/BaseFiles/indicadors_energetics_cat.csv";
            if (System.IO.File.Exists(filePath))
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                var header = lines[0].Split(','); // Get the header row
                indicators = lines.Skip(1) // Skip the header
                .Select(line => line.Split(','))
                .Select(parts => new IndicadorsEnergetics
                {
                    Data = DateTime.Parse(parts[0]),
                    CDEEBC_ProdNeta = ConvertDouble(parts[1]),
                    CDEEBC_ProdDisp = ConvertDouble(parts[2]),
                    CDEEBC_DemandaElectr = ConvertDouble(parts[3]),
                    CCAC_GasolinaAuto = ConvertDouble(parts[4]),
                    PBEE_Carbo = ConvertDouble(parts[5]),
                    PBEE_Fuel_Oil = ConvertDouble(parts[6]),
                    PBEE_CiclComb = ConvertDouble(parts[7]),
                    PBEE_Nuclear = ConvertDouble(parts[8]),
                    CDEEBC_ProdBruta = ConvertDouble(parts[9]),
                    CDEEBC_ConsumAux = ConvertDouble(parts[10]),
                    CDEEBC_ConsumBomb = ConvertDouble(parts[11]),
                    CDEEBC_TotVendesXarxaCentral = ConvertDouble(parts[12]),
                    CDEEBC_SaldoIntercanviElectr = ConvertDouble(parts[13]),
                    CDEEBC_TotalEBCMercatRegulat = parts[14],
                    CDEEBC_TotalEBCMercatLliure = parts[15],
                    FEE_Industria = ConvertDouble(parts[16]),
                    FEE_Terciari = ConvertDouble(parts[17]),
                    FEE_Domestic = ConvertDouble(parts[18]),
                    FEE_Primari = ConvertDouble(parts[19]),
                    FEE_Energetic = ConvertDouble(parts[20]),
                    FEEI_ConsObrPub = ConvertDouble(parts[21]),
                    FEEI_SiderFoneria = ConvertDouble(parts[22]),
                    FEEI_Metalurgia = ConvertDouble(parts[23]),
                    FEEI_IndusVidre = ConvertDouble(parts[24]),
                    FEEI_CimentsCalGuix = ConvertDouble(parts[25]),
                    FEEI_AltresMatConstr = ConvertDouble(parts[26]),
                    FEEI_QuimPetroquim = ConvertDouble(parts[27]),
                    FEEI_ConstrMedTrans = ConvertDouble(parts[28]),
                    FEEI_RestaTransforMetal = ConvertDouble(parts[29]),
                    FEEI_AlimBegudaTabac = ConvertDouble(parts[30]),
                    FEEI_TextilConfecCuirCalcat = ConvertDouble(parts[31]),
                    FEEI_PastaPaperCartro = ConvertDouble(parts[32]),
                    FEEI_AltresIndus = ConvertDouble(parts[33]),
                    DGGN_PuntFrontEnagas = ConvertDouble(parts[34]),
                    DGGN_DistrAlimGNL = ConvertDouble(parts[35]),
                    DGGN_ConsumGNCentrTerm = ConvertDouble(parts[36]),
                    CCAC_GasoilA = ConvertDouble(parts[37])
                })
                .ToList();
            }

            

            filePath = "./Pages/Files/indicadors_energetics_cat.json";
            if (System.IO.File.Exists(filePath))
            {
                var json = System.IO.File.ReadAllText(filePath);
                indicators.AddRange(JsonSerializer.Deserialize<List<IndicadorsEnergetics>>(json));
                
            }
            //produccio neta major a 3000
            produccioNetaSupTres = indicators.Where(n => n.CDEEBC_ProdNeta > 3000).OrderBy(o=> o.CDEEBC_ProdNeta).ToList();

            //consum gasolina major a 100
            consumGasolinaSupCen = indicators.Where(n => n.CCAC_GasolinaAuto > 100).OrderByDescending(o => o.CCAC_GasolinaAuto).ToList();

            //mitjana de produccio neta per any
            mitjanaProduccNeta = indicators
                .GroupBy(r => r.Data.Year)
                .ToDictionary(g => g.Key, g => g.Average(r => r.CDEEBC_ProdNeta))
                .OrderBy(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            //demanda electrica major a 4000 i produccio disponible menor a 300
            demandaEleSupCuatr = indicators.Where(n => n.CDEEBC_DemandaElectr > 4000 && n.CDEEBC_ProdDisp < 300).ToList();
        }
    }
    
        
}
