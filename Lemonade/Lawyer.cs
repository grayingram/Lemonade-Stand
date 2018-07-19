using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Lawyer
    {
        public string getResponse(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please enter an actual value for the question\n" + question);
                response = Console.ReadLine();
            }

            return response;
        }
        public int getInt(string question)
        {
            string response = getResponse(question);
            int userInput;

            while (int.TryParse(response, out userInput) == false)
            {
                Console.WriteLine("Unable to determine number. ");
                response = getResponse(question);
            }
            userInput = notNeg(userInput, response, question);

            return userInput;
        }
        public int notNeg(int num, string answer, string query)
        {

            int userInput = 0;

            while ((num < 0) || (num == 0))
            {
                Console.WriteLine("Must be a nonnegative nonzero number");
                num = getInt(query);
            }
            userInput = num;
            return userInput;
        }
        public decimal notNeg(decimal num, string answer, string query)
        {
            decimal userInput = 0;

            while ((num < 0) || (num == 0))
            {
                Console.WriteLine("Must be a nonnegative nonzero number");
                num = getDecimal(query);
            }
            userInput = Math.Round(num, 2);
            return userInput;
        }
        public decimal getDecimal(string question)
        {
            string response = getResponse(question);
            decimal userInput = 0;

            while (decimal.TryParse(response, out userInput) == false)
            {
                Console.WriteLine("Unable to determine number. ");
                response = getResponse(question);
            }
            userInput = notNeg(userInput, response, question);

            return userInput;
        }
    }
}
