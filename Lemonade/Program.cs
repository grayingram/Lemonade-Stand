using System;

namespace Lemonade
{
    class Program
    {
        static void Main(string[] args)
        {
            Stand ownerStand = new Stand();
            Lawyer ownerLawyer = new Lawyer();
            ownerStand.Name = ownerLawyer.GetResponse("What do you want to name the lemonade stand?");
            ownerStand.Predictivesell = ownerLawyer.GetInt("How many cups do you plan to sell?");
            ownerStand.Price = ownerLawyer.GetDecimal("How much do you want to charge for cup of lemonade?");
            ownerStand.OwnerLoss = ownerLawyer.GetDecimal("How much will this cost you per cup?");
            Console.WriteLine(ownerStand.RevealResult());
            Console.ReadLine();
            
        }       

    }
}
