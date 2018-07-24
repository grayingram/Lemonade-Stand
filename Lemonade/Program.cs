using System;
using System.Collections.Generic;

namespace LemonadeStands
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stand ownerStand = new Stand();
            Lawyer bestLawyer = new Lawyer();
            LemonadeCorporation p_n_f = new LemonadeCorporation();

            int numlemonStands  = p_n_f.LemonStands.Count;
            int numpopsicleStands = p_n_f.PopsiclesStands.Count;
            int numhotDogStands = p_n_f.HotdogStands.Count;
            if(numlemonStands > 0)
            {
                p_n_f.AddTogether(p_n_f.LemonStands);
            }
            if(numpopsicleStands > 0)
            {
                p_n_f.AddTogether(p_n_f.PopsiclesStands);
            }
            if(numhotDogStands > 0)
            {
                p_n_f.AddTogether(p_n_f.HotdogStands);
            }
            Console.WriteLine("Total Revenue for Coorporation: " + p_n_f.TotalRevenue);
            Console.WriteLine("Total Expenses for Coorporation: " + p_n_f.TotalExpenses);
            Console.WriteLine("Total Profit for Coorporation: " + p_n_f.TotalProfit);           
            bool fact = bestLawyer.GetYesNo("Do you want to get the individual information for each type stand");
            if (fact)
            {
                p_n_f.lemonStand.PrintIndivInfoLemonStands(p_n_f.LemonStands);
                p_n_f.popsicleStand.PrintIndivInfoPopsicleStands(p_n_f.PopsiclesStands);
                p_n_f.hotdogStand.PrintIndivInfoHotdogStands(p_n_f.HotdogStands);

            }
            else
            {
                Console.WriteLine("Alright have a wonderful day then.");
            }
            
            Console.ReadLine();
            
        }       

    }
}
