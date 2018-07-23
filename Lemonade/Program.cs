using System;
using System.Collections.Generic;

namespace Lemonade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stand ownerStand = new Stand();
            Lawyer bestLawyer = new Lawyer();
            LemonadeCorporation p_n_f = new LemonadeCorporation();

            p_n_f.AddTogether(p_n_f.corpStands);
            Console.WriteLine("Total Revenue for Coorporation: " + p_n_f.TotalRevenue);
            Console.WriteLine("Total Expenses for Coorporation: " + p_n_f.TotalExpenses);
            Console.WriteLine("Total Profit for Coorporation: " + p_n_f.TotalProfit);

            
            bool fact = bestLawyer.GetYesNo("Do you want to get the individual information for each stand");
            if (fact)
            {
                p_n_f.PrintIndivInfo();

            }
            else
            {
                Console.WriteLine("Alright have a wonderful day then.");
            }
            
            Console.ReadLine();
            
        }       

    }
}
