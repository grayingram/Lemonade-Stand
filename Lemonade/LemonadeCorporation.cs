﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class LemonadeCorporation
    {
        public List<Stand> corpStands = new List<Stand>();
        public decimal TotalRevenue { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalProfit { get; set; }


        public void AddTogether(List<Stand> allStand)
        {
            foreach (Stand stand in allStand)
            {
                stand.SetExpenses();
                stand.SetRevenue();
                stand.SetProfit();
                TotalExpenses += stand.Expenses;
                TotalProfit += stand.Profit;
                TotalRevenue += stand.Revenue;
            }
        }
        public void PrintIndivInfo()
        {
            int count = 0;
            foreach(Stand mystand in corpStands)
            {
                Console.WriteLine("Here are the results for stand #" + count);
                Console.WriteLine("The name of the stand is planned to be: " + mystand.Name);
                Console.WriteLine("The revenue is predicted for the stand is to be: " + mystand.Revenue);
                Console.WriteLine("The expenses is predicted for the stand is to be: " + mystand.Expenses);
                Console.WriteLine("The profit is predicted for the stand is to be: " + mystand.Profit);
                count++;
            }
        }
        public LemonadeCorporation()
        {
            Lawyer myLawyer = new Lawyer();
            int numofStands = myLawyer.GetInt("How many lemonade stands do you want to create?");
            
            for (int i = 0; i < numofStands; i++)
            {
                Stand ownerStand = new Stand();
                Console.WriteLine("For Stand #" + (i + 1));
                ownerStand.Name = myLawyer.GetResponse("What do you want to name this lemonade stand?");

                ownerStand.Predictivesell = myLawyer.GetInt("How many cups do you plan to sell at this stand?");
                ownerStand.Price = myLawyer.GetDecimal("How much do you want to charge for cup of lemonade at this stand?");
                ownerStand.OwnerLoss = myLawyer.GetDecimal("How much will this cost you per cup for this stand?");
                corpStands.Add(ownerStand);
            }
        }
}
}
