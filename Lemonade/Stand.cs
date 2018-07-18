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
            decimal profit = revenue - OwnerLoss;
            message += ("Revenue was: " + revenue + "\nCost for the owner was: " + OwnerLoss + "\nOverall profit was: " +profit + "\n");
            if (profit > 0)
            {
                message +=("This was a great idea");
            }
            else
            {
                message += ("Better luck planning next time.");
            }
            return message;

        }

    }
}
