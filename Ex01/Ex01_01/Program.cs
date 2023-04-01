namespace Ex01.BinarySeries
{
    using System;
    using System.Text;
    
    
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySeries();
        }

        public static void BinarySeries()
        {
            Console.WriteLine("Please type 3 numbers in binary format:");
            Console.WriteLine("After entering a number press Enter");
            int numberOfDigitsOfANumber = 8;

            string firstBinaryNum = Program.GetNumberInBinaryFormat(numberOfDigitsOfANumber, out int firstDecimalNum);
            string secondBinaryNum = Program.GetNumberInBinaryFormat(numberOfDigitsOfANumber, out int secondDecimalNum);
            string thirdBinaryNum = Program.GetNumberInBinaryFormat(numberOfDigitsOfANumber, out int thirdDecimalNum);
            Program.PrintInDescendingOrder(firstDecimalNum, secondDecimalNum, thirdDecimalNum);
            Program.PrintNumberOfZerosAndOnesInAvg(firstBinaryNum, secondBinaryNum, thirdBinaryNum);
            Program.PrintHowManyDivideBy4(firstDecimalNum, secondDecimalNum, thirdDecimalNum);
            Program.PrintHowManyNumbersAreDescendingOrder(firstDecimalNum, secondDecimalNum, thirdDecimalNum);
            Program.PrintHowManyNumbersArePalindrome(firstDecimalNum, secondDecimalNum, thirdDecimalNum);
        }

        public static void PrintHowManyNumbersArePalindrome(int i_FirstNum, int i_SecondNum, int i_ThirdNum)
        {
            int countPalindroms= 0;
            if (IsPalindrome(i_FirstNum))
            {
                countPalindroms++;
            }
            if (IsPalindrome(i_SecondNum))
            {
                countPalindroms++;
            }
            if (IsPalindrome(i_ThirdNum))
            {
                countPalindroms++;
            }

            if (countPalindroms == 0)
            {
                Console.WriteLine("Neither number is a palindrome");
            }
            else
            {
                Console.WriteLine($"The number palindromes is: {countPalindroms}");
            }
        }

        public static bool IsPalindrome(int i_number)
        {
            int useToReverse = i_number;
            int reversedNumber = 0;
            int reminder;
            while(useToReverse > 0)
            {
                reminder = useToReverse % 10;
                reversedNumber = reversedNumber * 10 + reminder;
                useToReverse /= 10;
            }

            return i_number == reversedNumber;
        }
        public static void PrintHowManyNumbersAreDescendingOrder(int i_FirstNum, int i_SecondNum, int i_ThirdNum)
        {

            int countHowManyAreDescending = 0;

            if (CheckIfSeriesIsInDescendingOrder(i_FirstNum.ToString()))
            {
                countHowManyAreDescending++;
            }
            if (CheckIfSeriesIsInDescendingOrder(i_SecondNum.ToString()))
            {
                countHowManyAreDescending++;
            }
            if (CheckIfSeriesIsInDescendingOrder(i_ThirdNum.ToString()))
            {
                countHowManyAreDescending++;
            }


            if (countHowManyAreDescending == 0)
            {
                Console.WriteLine("No number is in descending order");
            }
            else
            {
                Console.WriteLine($"The amount of numbers that are in descending order: {countHowManyAreDescending} ");
            }
        }

        public static bool CheckIfSeriesIsInDescendingOrder(string i_Series)
        {
            for( int i = 0; i < i_Series.Length - 1; i++)
            {
                if (i_Series[i] < i_Series[i + 1]) 
                    return false;
            }

            return true;
        }


        public static void PrintHowManyDivideBy4(int i_FirstNum, int i_SecondNum, int i_ThirdNum)
        {
            int countHowManyDivideBy4 = 0;
            if(i_FirstNum % 4 == 0)
            {
                countHowManyDivideBy4++;
            }
            if(i_SecondNum % 4 == 0)
            {
                countHowManyDivideBy4++;
            }
            if(i_ThirdNum % 4 == 0)
            {
                countHowManyDivideBy4++;
            }

            if(countHowManyDivideBy4 == 0)
            {
                Console.WriteLine("No number is divisible by 4");
            }
            else
            {
                Console.WriteLine($"The amount of numbers are divisible by 4 are: {countHowManyDivideBy4}");
            }
        }

        public static void PrintNumberOfZerosAndOnesInAvg(string i_FirstBinaryNum, string i_SecondBinaryNum, string i_ThirdBinaryNum)
        {
            int countNumberOfZeros = 0;
            int countNumberOfOnes = 0;

            Program.CountNumberOfZerosAndOnedInASeries(i_FirstBinaryNum, ref countNumberOfZeros, ref countNumberOfOnes);
            Program.CountNumberOfZerosAndOnedInASeries(i_SecondBinaryNum, ref countNumberOfZeros, ref countNumberOfOnes);
            Program.CountNumberOfZerosAndOnedInASeries(i_ThirdBinaryNum, ref countNumberOfZeros, ref countNumberOfOnes);

            Console.WriteLine($"The average number of zeros are: {countNumberOfZeros / 3}"); // todo check with yael
            Console.WriteLine($"The average number of zeros are: {countNumberOfOnes / 3}"); // todo check with yael
        }

        public static void CountNumberOfZerosAndOnedInASeries(string i_Series, ref int io_NumberOfZeros, ref int io_NumberOfOnes)
        {
            for (int i = 0; i < i_Series.Length; i++)
            {
                if (i_Series[i] == '0')
                {
                    io_NumberOfZeros += 1;
                }
                else
                {
                    io_NumberOfOnes += 1;
                }
            }
        }

        public static void PrintInDescendingOrder(int i_FirstNum, int i_SecondNum, int i_ThirdNum)
        {
            int minNum, avgNum, maxNum;
            minNum = Math.Min(Math.Min(i_FirstNum, i_SecondNum), i_ThirdNum);
            maxNum = Math.Max(Math.Max(i_FirstNum, i_SecondNum), i_ThirdNum);
            avgNum = i_FirstNum + i_SecondNum + i_ThirdNum - maxNum - minNum;

            Console.WriteLine($"The Decimal numbers are: {maxNum}, {avgNum}, {minNum}");
        }


        public static string GetNumberInBinaryFormat(int i_NumberOfDigits, out int o_DecimalNum)
        {

            bool isBinaryFormat = false;
            StringBuilder binaryForamtNumber = new StringBuilder();
            string userInput;
            Console.WriteLine("Please type a number in binary format:");
            Console.WriteLine("When finished press Enter");
            while (isBinaryFormat != true)
            {
                
                 userInput = Console.ReadLine();
    
                if (CheckIfUserInputIsInBinaryFormat(userInput, i_NumberOfDigits))
                {
                    binaryForamtNumber.Append(userInput);
                    isBinaryFormat = true; 
                }
                else
                {
                    Console.WriteLine($"{userInput} is a worng input!");
                    Console.WriteLine("Please try again, after typing the digit press Enter");
                }

            }
            o_DecimalNum = BinaryToDecimal(binaryForamtNumber.ToString());
            return binaryForamtNumber.ToString();
        }
        public static int BinaryToDecimal(String i_BinaryFormatNumber)
        {
            StringBuilder reveredBinaryNumber = new StringBuilder();

            for(int i = i_BinaryFormatNumber.Length - 1; i >= 0; i--)
            {
                reveredBinaryNumber.Append(i_BinaryFormatNumber[i]);
            }

            int decimalNumber = 0;
            

            for( int i = 0; i < reveredBinaryNumber.Length; i++)
            {
                if (reveredBinaryNumber[i] == '1')
                {
                    decimalNumber += (short)Math.Pow(2, i);
                }
            }
            return decimalNumber;
        }

        public static string ReverseString(string i_StringToBeReversed)
        {
            StringBuilder reveredString = new StringBuilder();

            for (int i = i_StringToBeReversed.Length - 1; i >= 0; i--)
            {
                reveredString.Append(i_StringToBeReversed[i]);
            }

            return reveredString.ToString();
        }
       

        public static bool CheckIfUserInputIsInBinaryFormat(string i_userInput, int i_NumberOfDigitsRequested)
        {
            if (i_userInput == null)
                return false;

            if (i_userInput.Length != i_NumberOfDigitsRequested)
                return false;

            for( int i = 0; i < i_userInput.Length; i++)
            {
                if (!CheckIfDigitIsBinaryFormat(i_userInput[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckIfDigitIsBinaryFormat(char i_BinarayDigitToCheck)
        {
            return i_BinarayDigitToCheck == '1' || i_BinarayDigitToCheck == '0';
        }

    }

}