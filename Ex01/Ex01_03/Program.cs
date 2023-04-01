using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_03
{
    public class Program
    {

        public static void Main()
        {
            diamondForAdvanced();
        }



        private static void diamondForAdvanced()
        {
            int high;
            string userDiamondHigh = getInputFromUser("Please enter the high of the diamond you want: ");
            bool unvalidInput = int.TryParse(userDiamondHigh, out high);

            while (!unvalidInput)
            {
                userDiamondHigh = getInputFromUser("Please enter valid input(only number): ");
                unvalidInput = int.TryParse(userDiamondHigh, out high);
            }

            Ex01_02.Program.DiamondForBeginners(high, 0);

        }

        private static string getInputFromUser(string i_massegeToOutput)
        {
            Console.WriteLine(i_massegeToOutput);
            string userInput = Console.ReadLine();

            return userInput;
        }
        
    }


}
