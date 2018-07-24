using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStands
{
    class Popsicle : Stand
    {
        public new string Type = "popsicle";
        public new string Item = "stick";
        
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
