using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStands
{
    class Hotdog : Stand
    {
        public new string Type = "hotdog";
        public new string Item = "frank";
       
        public void PrintIndivInfoHotdogStands(List<Hotdog> HotdogStands)
        {
            int count = 1;
            foreach (Hotdog mystand in HotdogStands)
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

