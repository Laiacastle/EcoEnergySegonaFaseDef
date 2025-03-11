using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySegonaFaseDef.Classes
{
    public class IndicadorsEnergetics
    {
        public DateTime Data { get; set;}
        public double CDEEBC_ProdNeta { get; set; }
        public double CDEEBC_ProdDisp { get; set; }
        public double CDEEBC_DemandaElectr { get; set; }
        public double CCAC_GasolinaAuto { get; set; }



        public double PBEE_Carbo { get; set;}
        public double PBEE_Fuel_Oil { get; set; }
        public double PBEE_CiclComb { get; set; }
        public double PBEE_Nuclear { get; set; }
        public double CDEEBC_ProdBruta { get; set; }
        public double CDEEBC_ConsumAux { get; set; }
        public double CDEEBC_ConsumBomb { get; set; }
        public double CDEEBC_TotVendesXarxaCentral { get; set; }
        public double CDEEBC_SaldoIntercanviElectr { get; set; }
        public string? CDEEBC_TotalEBCMercatRegulat { get; set; }
        public string? CDEEBC_TotalEBCMercatLliure  { get; set; }
        public double FEE_Industria { get; set; }
        public double FEE_Terciari { get; set; }
        public double FEE_Domestic { get; set; }
        public double FEE_Primari { get; set; }
        public double FEE_Energetic { get; set; }
        public double FEEI_ConsObrPub { get; set; }
        public double FEEI_SiderFoneria { get; set; }
        public double FEEI_Metalurgia { get; set; }
        public double FEEI_IndusVidre { get; set; }
        public double FEEI_CimentsCalGuix { get; set; }
        public double FEEI_AltresMatConstr { get; set; }
        public double FEEI_QuimPetroquim { get; set; }
        public double FEEI_ConstrMedTrans { get; set; }
        public double FEEI_RestaTransforMetal { get; set; }
        public double FEEI_AlimBegudaTabac { get; set; }
        public double FEEI_TextilConfecCuirCalcat { get; set; }
        public double FEEI_PastaPaperCartro { get; set; }
        public double FEEI_AltresIndus { get; set; }
        public double DGGN_PuntFrontEnagas { get; set; }
        public double DGGN_DistrAlimGNL { get; set; }
        public double DGGN_ConsumGNCentrTerm { get; set; }
        public double CCAC_GasoilA { get; set; }
        
        public IndicadorsEnergetics(DateTime data, double cDEEBC_ProdNeta, double cDEEBC_ProdDisp, double cDEEBC_DemandaElectr, double cCAC_GasolinaAuto)
        {
            Data = data;
            CDEEBC_ProdNeta = cDEEBC_ProdNeta; 
            CDEEBC_ProdDisp = cDEEBC_ProdDisp; 
            CDEEBC_DemandaElectr = cDEEBC_DemandaElectr; 
            CCAC_GasolinaAuto = cCAC_GasolinaAuto; 

            PBEE_Carbo = 2;
            PBEE_Fuel_Oil = 2;
            PBEE_CiclComb = 2;
            PBEE_Nuclear = 2;
            CDEEBC_ProdBruta = 2;
            CDEEBC_ConsumAux = 2;
            CDEEBC_ConsumBomb = 2;
            CDEEBC_TotVendesXarxaCentral = 2;
            CDEEBC_SaldoIntercanviElectr = 2;
            CDEEBC_TotalEBCMercatRegulat = "2%";
            CDEEBC_TotalEBCMercatLliure = "2%";
            FEE_Industria = 2;
            FEE_Terciari = 2;
            FEE_Domestic = 2;
            FEE_Primari = 2;
            FEE_Energetic = 2;
            FEEI_ConsObrPub = 2;
            FEEI_SiderFoneria = 2;
            FEEI_Metalurgia = 2;
            FEEI_IndusVidre = 2;
            FEEI_CimentsCalGuix = 2;
            FEEI_AltresMatConstr = 2;
            FEEI_QuimPetroquim = 2;
            FEEI_ConstrMedTrans = 2;
            FEEI_RestaTransforMetal = 2;
            FEEI_AlimBegudaTabac = 2;
            FEEI_TextilConfecCuirCalcat = 2;
            FEEI_PastaPaperCartro = 2;
            FEEI_AltresIndus = 2;
            DGGN_PuntFrontEnagas = 2;
            DGGN_DistrAlimGNL = 2;
            DGGN_ConsumGNCentrTerm = 2;
            CCAC_GasoilA = 2;
        }

        public IndicadorsEnergetics() { }

        
    }
}
