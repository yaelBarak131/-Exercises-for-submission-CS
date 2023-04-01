namespace Ex01.StatisticsOfNumbers
{
    using Ex01.AnalysisOfStrings;
    public class Program
    {
        public static void Main(string[] args)
        {
            StatisticsOfNumbers(args[0]);
        }

        public static void StatisticsOfNumbers(String i_StringToValidate)
        {
            if (!AnalysisOfStrings.Program.StringHasSpecifiedLength(i_StringToValidate, 6))
            {
                //todo chage this to something else
                return;
            }

            if (!AnalysisOfStrings.Program.IsNumeric(i_StringToValidate))
            {
                //todo change this to something else
                Console.WriteLine($"The string: {i_StringToValidate} does not contain only numbers");
                return;
            }
           
            LargerThenTheOnesDigit(i_StringToValidate);
            SmallestDigitInString(i_StringToValidate);
            HowManyDigitsAreDivisibleBy3(i_StringToValidate);
            AvgOfDigitisInString(i_StringToValidate);

        }

        public static void LargerThenTheOnesDigit(string i_String)
        {
            if(i_String.Length < 2)
            {
                Console.WriteLine("No digit is larger then the ones digit");
                return;
            }

            int countDigitsLargerThenOnes = 0;
            
            for(int i = 0; i < i_String.Length - 1; i++)
            {
                if (i_String[i] > i_String[i_String.Length - 1])
                {
                    countDigitsLargerThenOnes++;
                }
            }

            
            Console.WriteLine($"The number of digits in the string: {i_String} that are larger then {i_String[i_String.Length - 1]} are: {countDigitsLargerThenOnes}");
            
            
        }

        public static void SmallestDigitInString(string i_String)
        {
            if(i_String.Length < 1)
            {
                return;
            }
            char smallestDigitInStr = '9';

            for(int i = 0; i < i_String.Length; i++)
            {
                if(smallestDigitInStr > i_String[i])
                {
                    smallestDigitInStr = i_String[i];
                }
            }

            Console.WriteLine($"The smallest digit in: {i_String} is: {smallestDigitInStr}");

        }
        public static void HowManyDigitsAreDivisibleBy3(string i_String)
        {
            int countDigitsDivisibleBy3 = 0;


            for (int i = 0; i < i_String.Length; i++)
            {
                if ((i_String[i] - '0') % 3 == 0)
                {
                    countDigitsDivisibleBy3++;
                }
            }

            Console.WriteLine($"The number of digits in the string: {i_String[i_String.Length - 1]} that are divisible by 3 are: {countDigitsDivisibleBy3}");
        }

        public static void AvgOfDigitisInString(string i_String)
        {
            if(i_String.Length < 1)
            {
                return;
            }

            int sumOfDigits = 0;

            for (int i = 0; i < i_String.Length; i++)
            {
                sumOfDigits += (i_String[i] - '0');
            }
            Console.WriteLine($"The average sum of the string: {i_String[i_String.Length - 1]} digits is: {sumOfDigits/i_String.Length}");
        }
    }
}