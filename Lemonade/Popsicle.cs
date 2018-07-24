using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStands
{
    class Popsicle : Stand
    {
        public string type = "popsicle";
        public string item = "stick";
        public List<Popsicle> SetPopsicleStands(Lawyer myLawyer, List<Popsicle> aStand)
        {
            int numofStands = myLawyer.GetInt("How many " + type + " stands do you want to create?");

            for (int i = 0; i < numofStands; i++)
            {
                var ownerStand = new Popsicle();
                Console.WriteLine("For Stand #" + (i + 1));
                ownerStand.Name = myLawyer.GetResponse("What do you want to name this " + type + " stand?");

                ownerStand.Predictivesell = myLawyer.GetInt("How many "+ item + "s do you plan to sell at this stand?");
                ownerStand.Price = myLawyer.GetDecimal("How much do you want to charge for a " + item + " of " + type + " at this stand?");
                ownerStand.OwnerLoss = myLawyer.GetDecimal("How much will this cost you per " + item + " for this stand?");
                aStand.Add(ownerStand);
            }
            return aStand;
        }
        public void PrintIndivInfoPopsicleStands(List<Popsicle> PopsicleStands)
        {
            int count = 1;
            foreach (Popsicle mystand in PopsicleStands)
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
