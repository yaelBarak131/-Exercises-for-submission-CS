namespace Ex01.AnalysisOfStrings
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            AnalysisOfStrings(args[0]);
        }
        public static void AnalysisOfStrings(string i_StringToValidate)
        {   
            if(!StringHasSpecifiedLength(i_StringToValidate, 6))
            {
                return;
            }
            if (!(IsNumeric(i_StringToValidate) || IsLetters(i_StringToValidate)))
            {
                Console.WriteLine($"The string: {i_StringToValidate} does not contain only numbers or only letters");
                return;
            }

            if (IsPalindrome(i_StringToValidate))
            {
                Console.WriteLine($"The string: {i_StringToValidate} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"The string: {i_StringToValidate} is not a Palindrome");
            }

            if (IsNumeric(i_StringToValidate))
            {
                if(int.Parse(i_StringToValidate) % 3 == 0)
                {
                    Console.WriteLine($"The parsed number: {i_StringToValidate} from string is divisible by 3");
                }
                else
                {
                    Console.WriteLine($"The parsed number: {i_StringToValidate} from string is not divisible by 3");
                }
            }
            else
            {
                int howManyUpperCase = CountUpperCaseLetters(i_StringToValidate);
                if(howManyUpperCase == 0)
                {
                    Console.WriteLine($"The string: {i_StringToValidate} has no upper case letters");
                }
                else if(howManyUpperCase == 1)
                {
                    Console.WriteLine($"The string: {i_StringToValidate} has {howManyUpperCase} upper case letter");
                }
                else
                {
                    Console.WriteLine($"The string: {i_StringToValidate} has {howManyUpperCase} upper case letters");
                }
            }
        }
        public static bool StringHasSpecifiedLength(string i_StringToValidate, int i_RequestedLength)
        {
            if (i_StringToValidate.Length != i_RequestedLength)
            {
                Console.WriteLine($"The String: {i_StringToValidate} does not have exactly {i_RequestedLength} letters");
                return false;
            }
            return true;
        }
        public static int CountUpperCaseLetters(string i_String)
        {
            int countUpperCaseLetters = 0;
            for (int i = 0; i < i_String.Length; i++)
            {
                if (char.IsUpper(i_String[i]))
                {
                    countUpperCaseLetters++;
                }
            }
            
            return countUpperCaseLetters;
        }
        public static bool IsLetters(string i_String)
        {
            return Regex.IsMatch(i_String, @"^[a-zA-Z]+$");
        }


        public static bool IsNumeric(string i_String)
        {
            return Regex.IsMatch(i_String, "^[0-9]+$");
        }

        public static bool CheckIfPalindrome(string i_String, ref int i_index)
        {
            if (i_String.Length == i_index)
            {
                return true;
            }
            else
            {
                if (i_String[i_index] != i_String[i_String.Length - 1 - i_index])
                {
                    return false;
                }
                i_index++;
                return CheckIfPalindrome(i_String, ref i_index);

            }
        }

        public static bool IsPalindrome(string i_String)
        {

            int correntIndexInString = 0;
            return CheckIfPalindrome(i_String, ref correntIndexInString);
            
        }
    }
}