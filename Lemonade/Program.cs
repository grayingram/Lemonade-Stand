using System;

namespace Lemonade
{
    class Program
    {
        static void Main(string[] args)
        {
            Stand ownerStand = new Stand();
            Lawyer ownerLawyer = new Lawyer();
            ownerStand.Name = ownerLawyer.getResponse("What do you want to name the lemonade stand?");
            ownerStand.Predictivesell = ownerLawyer.getInt("How many cups do you plan to sell?");
            ownerStand.Price = ownerLawyer.getDecimal("How much do you want to charge for cup of lemonade?");
            ownerStand.OwnerLoss = ownerLawyer.getDecimal("How much will this cost you per cup?");
            Console.WriteLine(ownerStand.RevealResult());
            Console.ReadLine();
            
        }       

    }
}
