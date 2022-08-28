using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    
    class Calculation
    {   private decimal tarif;
        private decimal count;
        private decimal norma;
        private decimal people;
        public decimal Calculate(decimal tarif, decimal count)
        {
            this.tarif = tarif;
            this.count = count;
            return this.tarif * this.count;
        }

        public decimal Calculate(decimal tarif, decimal norma, decimal people)
        {
            this.tarif = tarif;
            this.norma = norma;
            this.people = people;
            return this.tarif * this.norma * this.people;
        }
    }
    public class values
    {
        public values(decimal hvs, decimal gvs, decimal ed, decimal en, decimal ppl)
        {
            this.hvs = hvs;
            this.gvs = gvs;
            this.ed = ed;
            this.en = en;
            this.ppl = ppl;
        }

        private decimal hvs { get; set; }    
        private decimal gvs { get; set; }
        private decimal ed { get; set; }
        private decimal en { get; set; }
        private decimal ppl { get; set; }
    }

    internal class Programm
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Indication());
        }
    }
    public class program : values
    {
        public static decimal tarifHVS = 35.78M;
        public static decimal tarifGVS = 159.98M;
        public static decimal tarifEE = 4.28M;
        public static decimal tarifED = 4.9M;
        public static decimal tarifEN = 2.31M;
        public static decimal tarifHeat = 35.78M;
        public static decimal tarifThermal = 998.69M;
        public static decimal normaHVS = 4.85M;
        public static decimal normaGVS = 4.01M;
        public static decimal normaEE = 164M;
        public static decimal normaHeat = 4.01M;
        public static decimal normaThermal = 0.05349M;
        public decimal resHVS;
        public decimal resGVS;
        public decimal resED;
        public decimal resEN;
        public decimal summ;
        public program(decimal hvs, decimal gvs, decimal ed, decimal en, decimal ppl, bool HaveHVS, bool HaveGVS, bool HaveEnergy) : base(hvs, gvs, ed, en, ppl)
        {
            Calculation HeatCarrier = new Calculation();
            Calculation ThermalEnergy = new Calculation();
            Calculation ColdWater = new Calculation();
            Calculation ElectricEnergy = new Calculation();
            Calculation ElectricDay = new Calculation();
            Calculation ElectricNight = new Calculation();
            // Проверка на счетчики холодной воды
            if (HaveHVS == true)
                resHVS = ColdWater.Calculate(tarifHVS, hvs);
            else
                resHVS = ColdWater.Calculate(tarifHVS, normaHVS, ppl);
            // Проверка ка счетчики горячей воды
            if (HaveGVS == true)
                resGVS = ThermalEnergy.Calculate((tarifThermal * normaThermal), gvs) + HeatCarrier.Calculate(tarifHeat, gvs);
            else
                resGVS = ThermalEnergy.Calculate((tarifThermal * normaThermal), normaHeat, ppl) + HeatCarrier.Calculate(tarifHeat, normaHeat, ppl);
            // Проверка на электросчётчики
            if (HaveEnergy == true)
            {
                resED = ElectricDay.Calculate(tarifED, ed);
                resEN = ElectricNight.Calculate(tarifEN, en);
            }
            else
            {
                resED = ElectricEnergy.Calculate(tarifEE, normaEE, ppl);
                resEN = 0;
            }
            summ = resED + resEN + resGVS + resHVS;
        }
        long sw = Stopwatch.GetTimestamp();
    }
}
