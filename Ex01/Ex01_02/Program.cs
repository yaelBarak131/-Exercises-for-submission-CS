
namespace Ex01_02
{
    public class Program
    {
        public static void Main()
        {
            PrintDaimon(5, 0);
        }

        public static void PrintDaimon(int high, int i_currentRow)
        {
            if (i_currentRow <= high * 2 - 1)//musere the num of total rows
            {
                int numStarsToPrint;
                int numSpaceToPrint;

                if (i_currentRow < high)//if we got to the "middle" of the rows
                {
                    numStarsToPrint = i_currentRow * 2 + 1;
                }
                else
                {
                    numStarsToPrint = (high * 2 - 1 - i_currentRow) * 2 - 1;
                }
                numSpaceToPrint = (high * 2 - 1 - numStarsToPrint) / 2;

                string textToPrint = (new string(' ', numSpaceToPrint) + new string('*', numStarsToPrint) + new string(' ', numSpaceToPrint));

                System.Console.WriteLine(textToPrint);
                PrintDaimon(high,i_currentRow + 1);
            }
        }
    }
}
