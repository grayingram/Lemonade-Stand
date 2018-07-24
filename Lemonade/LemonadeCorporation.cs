using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStands
{
    class LemonadeCorporation
    {
        public string CorpName { get; set; }
        public List<Lemonade> LemonStands { get; set; } = new List<Lemonade>();
        public List<Popsicle> PopsiclesStands { get; set; } = new List<Popsicle>();
        public Lemonade lemonStand = new Lemonade();
        public Popsicle popsicleStand = new Popsicle();
        public decimal TotalRevenue { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalProfit { get; set; }


        public void AddTogether(List<Lemonade> allStand)
        {
            foreach (Lemonade stand in allStand)
            {
                stand.SetExpenses();
                stand.SetRevenue();
                stand.SetProfit();
                TotalExpenses += stand.Expenses;
                TotalProfit += stand.Profit;
                TotalRevenue += stand.Revenue;
            }
        }
        public void AddTogether(List<Popsicle> allStand)
        {
            foreach (Popsicle stand in allStand)
            {
                    stand.SetExpenses();
                    stand.SetRevenue();
                    stand.SetProfit();
                    TotalExpenses += stand.Expenses;
                    TotalProfit += stand.Profit;
                    TotalRevenue += stand.Revenue;
            }
            
        }
        public LemonadeCorporation()
        {
            Lawyer myLawyer = new Lawyer();
            CorpName = myLawyer.GetResponse("What would you like of the corporation of various stands to be called?");
            bool lemonFact = myLawyer.GetYesNo("Do you want to have any lemonade stands in your corporation?");
            if (lemonFact)
            {
                LemonStands = lemonStand.SetLemonStands(myLawyer, LemonStands);
            }
            bool popsicleFact = myLawyer.GetYesNo("Do you want any popsicle stands in your corporation?");
            if (popsicleFact)
            {
               PopsiclesStands = popsicleStand.SetPopsicleStands(myLawyer, PopsiclesStands);
            }
            
        }

        
}
}
