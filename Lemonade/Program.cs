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
            Console.WriteLine(ownerStand.Name);
            Console.WriteLine(ownerStand.Predictivesell);
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
                Console.WriteLine("Unable to determine number. " + question);
                response = getResponse(question);
            }
            return userInput;
        }
    }
}
