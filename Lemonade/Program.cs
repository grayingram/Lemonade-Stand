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


            
            Console.ReadLine();
            
        }       

    }
}
