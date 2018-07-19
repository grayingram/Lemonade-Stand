using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Stand
    {
        public string Name { get; set; }
        public int Predictivesell { get; set; }
        public decimal Price { get; set; }
        public decimal OwnerLoss { get; set; }

        public string RevealResult()
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

        }
        

    }
}
