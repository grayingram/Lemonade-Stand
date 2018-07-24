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
        public List<Hotdog> HotdogStands { get; set; } = new List<Hotdog>();
        public Lemonade lemonStand = new Lemonade();
        public Popsicle popsicleStand = new Popsicle();
        public Hotdog hotdogStand = new Hotdog();
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
        public void AddTogether(List<Hotdog> allStand)
        {
            foreach (Hotdog stand in allStand)
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
            Stand my_Stand = new Stand();
            CorpName = myLawyer.GetResponse("What would you like of the corporation of various stands to be called?");
            bool lemonFact = myLawyer.GetYesNo("Do you want to have any lemonade stands in your corporation?");
            if (lemonFact)
            {
                LemonStands = lemonStand.SetStands(myLawyer, LemonStands);
            }
            bool popsicleFact = myLawyer.GetYesNo("Do you want to have any popsicle stands in your corporation?");
            if (popsicleFact)
            {
               PopsiclesStands = popsicleStand.SetStands(myLawyer, PopsiclesStands);
            }
            bool hotdogFact = myLawyer.GetYesNo("Do you want to have any hotdog stands in your corporation?");
            if (hotdogFact)
            {
                HotdogStands = hotdogStand.SetStands(myLawyer, HotdogStands);
            }
            
        }

        
}
}
