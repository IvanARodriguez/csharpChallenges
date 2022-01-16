using System;
using static CsharpChallenges.PinValidation;

namespace CsharpChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user inputs through console
            Console.WriteLine("Hi, please enter a 4 or 6 number pin");
            string userInput = Console.ReadLine();
            // validate the pin is 4 or 6 characters and numbers only
            ValidatePin(userInput);

        }
    }
}
