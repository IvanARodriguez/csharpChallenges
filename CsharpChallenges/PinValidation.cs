using System;
using System.Text.RegularExpressions;

namespace CsharpChallenges
{
    public class PinValidation
    {
        public static bool ValidatePin(string pin)
        {
            //check if the pin is either 4
            if (pin.Length == 4)
            {
                //regular expression to identify numbers in a 4 digit pin
                Regex regex = new Regex("[0-9]{4}");
                //if pin matches the regex return true else return false
                if (regex.IsMatch(pin))
                {
                    Console.WriteLine("True, the pin you entered is 4 digit and Numbers only");
                    return true;
                }
                else
                {
                    Console.WriteLine("False, the Pin have to be numbers only");
                    return false;
                }
            }
            else if (pin.Length == 6)
            {
                //regular expression to identify numbers
                Regex regex = new Regex("([0-9]{6})");
                //if pin matches the regex return true else return false
                if (regex.IsMatch(pin))
                {
                    Console.WriteLine("True, the pin you entered is 6 digit and Numbers only");
                    return true;
                }
                else
                {
                    Console.WriteLine("False, the Pin have to be numbers only");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("False, your pin have to be 4 or 6 numbers");
                return false;
            }
        }

    }
}