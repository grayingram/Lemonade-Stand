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
            int numofStands = bestLawyer.GetInt("How many lemonade stands do you want to create?");
            List<Stand> listofStands = new List<Stand>();
            for (int i = 0; i < numofStands; i++)
            {
                Stand ownerStand = new Stand();
                Console.WriteLine("For Stand #" + (i + 1));
                ownerStand.Name = bestLawyer.GetResponse("What do you want to name this lemonade stand?");

                ownerStand.Predictivesell = bestLawyer.GetInt("How many cups do you plan to sell at this stand?");
                ownerStand.Price = bestLawyer.GetDecimal("How much do you want to charge for cup of lemonade at this stand?");
                ownerStand.OwnerLoss = bestLawyer.GetDecimal("How much will this cost you per cup for this stand?");
                listofStands.Add(ownerStand);
            }

            foreach(var stand in listofStands)
            {
                Console.WriteLine(stand.RevealResult());
                Console.ReadLine();
            }
            
            Console.ReadLine();
            
        }       

    }
}
