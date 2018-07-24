﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStands
{
    class Lemonade : Stand
    {
        public List<Lemonade> SetLemonStands(Lawyer myLawyer, List<Lemonade> aStand)
        {
            int numofStands = myLawyer.GetInt("How many lemonade stands do you want to create?");

            for (int i = 0; i < numofStands; i++)
            {
                var ownerStand = new Lemonade();
                Console.WriteLine("For Stand #" + (i + 1));
                ownerStand.Name = myLawyer.GetResponse("What do you want to name this lemonade stand?");

                ownerStand.Predictivesell = myLawyer.GetInt("How many cups do you plan to sell at this stand?");
                ownerStand.Price = myLawyer.GetDecimal("How much do you want to charge for cup of lemonade at this stand?");
                ownerStand.OwnerLoss = myLawyer.GetDecimal("How much will this cost you per cup for this stand?");
                aStand.Add(ownerStand);
            }
            return aStand;
        }
        public void PrintIndivInfoLemonStands(List<Lemonade> LemonStands)
        {
            int count = 1;
            foreach (Lemonade mystand in LemonStands)
            {
                Console.WriteLine("Here are the results for stand #" + count);
                Console.WriteLine("The name of the stand is planned to be: " + mystand.Name);
                Console.WriteLine("The revenue is predicted for the stand is to be: " + mystand.Revenue);
                Console.WriteLine("The expenses is predicted for the stand is to be: " + mystand.Expenses);
                Console.WriteLine("The profit is predicted for the stand is to be: " + mystand.Profit);
                Console.ReadLine();
                count++;
            }
        }
    }
}
