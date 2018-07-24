using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStands
{
    class Lemonade : Stand
    {
        public new string Type = "lemonade";
        public new string Item = "cup";
        
        public void PrintIndivInfoLemonStands(List<Lemonade> LemonStands)
        {
            int count = 1;
            foreach (Lemonade mystand in LemonStands)
            {   

                Console.WriteLine("Here are the results for stand #" + count + "and is  a " + Type + "stand");
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
