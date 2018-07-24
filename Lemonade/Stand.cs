using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStands
{
    class Stand
    {
        public string Name { get; set; }
        public int Predictivesell { get; set; }
        public decimal Price { get; set; }
        public decimal OwnerLoss { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }
        public decimal Profit { get; set; }
        public string Type { get; set; }
        public string Item { get; set; }

        public void SetRevenue()
        {
            Revenue = Price * Predictivesell;
        }
        public void SetExpenses()
        {
            Expenses = OwnerLoss * Predictivesell;
        }
        public void SetProfit()
        {
            Profit = Revenue - Expenses;
        }
        public decimal GetRevenue()
        {
            return Revenue;
        }
        public decimal GetExpenses()
        {
            return Expenses;
        }
        public decimal GetProfit()
        {
            return Profit;
        }
        public void SetStands(Lawyer myLawyer, List<Stand> aStand)
        {
            int numofStands = myLawyer.GetInt("How many lemonade stands do you want to create?");

            for (int i = 0; i < numofStands; i++)
            {
                var ownerStand = new Stand();
                Console.WriteLine("For Stand #" + (i + 1));
                ownerStand.Name = myLawyer.GetResponse("What do you want to name this lemonade stand?");

                ownerStand.Predictivesell = myLawyer.GetInt("How many cups do you plan to sell at this stand?");
                ownerStand.Price = myLawyer.GetDecimal("How much do you want to charge for cup of lemonade at this stand?");
                ownerStand.OwnerLoss = myLawyer.GetDecimal("How much will this cost you per cup for this stand?");
                aStand.Add(ownerStand);
            }
        }
        public List<Hotdog> SetStands(Lawyer myLawyer, List<Hotdog> aStand)
        {
            int numofStands = myLawyer.GetInt("How many " + Type + " stands do you want to create?");

            for (int i = 0; i < numofStands; i++)
            {
                var ownerStand = new Hotdog();
                Console.WriteLine("For Stand #" + (i + 1));
                ownerStand.Name = myLawyer.GetResponse("What do you want to name this " + Type + " stand?");

                ownerStand.Predictivesell = myLawyer.GetInt("How many " + Item + "s do you plan to sell at this stand?");
                ownerStand.Price = myLawyer.GetDecimal("How much do you want to charge for a " + Item + " of " + Type + " at this stand?");
                ownerStand.OwnerLoss = myLawyer.GetDecimal("How much will this cost you per " + Item + " for this stand?");
                aStand.Add(ownerStand);
            }
            return aStand;
        }
        public List<Lemonade> SetStands(Lawyer myLawyer, List<Lemonade> aStand)
        {
            int numofStands = myLawyer.GetInt("How many " + Type + " stands do you want to create?");

            for (int i = 0; i < numofStands; i++)
            {
                var ownerStand = new Lemonade();
                Console.WriteLine("For Stand #" + (i + 1));
                ownerStand.Name = myLawyer.GetResponse("What do you want to name this " + Type + " stand?");

                ownerStand.Predictivesell = myLawyer.GetInt("How many " + Item + "s do you plan to sell at this stand?");
                ownerStand.Price = myLawyer.GetDecimal("How much do you want to charge for a " + Item + " of " + Type + " at this stand?");
                ownerStand.OwnerLoss = myLawyer.GetDecimal("How much will this cost you per " + Item + " for this stand?");
                aStand.Add(ownerStand);
            }
            return aStand;
        }
        public List<Popsicle> SetStands(Lawyer myLawyer, List<Popsicle> aStand)
        {
            int numofStands = myLawyer.GetInt("How many " + Type + " stands do you want to create?");

            for (int i = 0; i < numofStands; i++)
            {
                var ownerStand = new Popsicle();
                Console.WriteLine("For Stand #" + (i + 1));
                ownerStand.Name = myLawyer.GetResponse("What do you want to name this " + Type + " stand?");

                ownerStand.Predictivesell = myLawyer.GetInt("How many " + Item + "s do you plan to sell at this stand?");
                ownerStand.Price = myLawyer.GetDecimal("How much do you want to charge for a " + Item + " of " + Type + " at this stand?");
                ownerStand.OwnerLoss = myLawyer.GetDecimal("How much will this cost you per " + Item + " for this stand?");
                aStand.Add(ownerStand);
            }
            return aStand;
        }

        /*public string RevealResult()
        {
            string message = "";
            decimal revenue = Price * Predictivesell;
            decimal realLoss = OwnerLoss * Predictivesell;
            decimal profit = revenue - realLoss;
            message += ("Revenue will be: " + revenue + "\nThe expenses will be: " + realLoss + "\nOverall profit will be: " +profit + "\n");
            if (profit > 0)
            {
                message +=("This is a great idea");
            }
            else
            {
                message += ("This is a terrible idea.");
            }
            return message;

        }*/


    }
}
