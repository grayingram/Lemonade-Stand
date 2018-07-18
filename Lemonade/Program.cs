using System;

namespace Lemonade
{
    class Program
    {
        static void Main(string[] args)
        {
            Stand ownerStand = new Stand();
            ownerStand.Name = getResponse("What do you want to name the lemonade stand?");
            ownerStand.Predictivesell = getInt("How many cups do you plan to sell?");
            ownerStand.Price = getDecimal("How much do you want to charge for cup of lemonade?");
            ownerStand.OwnerLoss = getDecimal("How much will this cost you?");

            
            Console.WriteLine(ownerStand.RevealResult());
            Console.ReadLine();
            
        }

        static string getResponse(string question)
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
        static int getInt(string question)
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
        static int notNeg(int num, string answer, string query)
        {
            
            int userInput = 0;

            while (num < 0)
            {
                Console.WriteLine("Must not be negative");
                num = getInt(query);
            }
            userInput = num;
            return userInput;
        }
        static decimal notNeg(decimal num,  string answer, string query) 
        {
            decimal userInput = 0;

            while (num < 0)
            {
                Console.WriteLine("Must not be negative");
                num = getInt(query);
            }
            userInput = num;
            return userInput;
        }
        static decimal getDecimal(string question)
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
