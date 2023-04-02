
using System.Text;

namespace Ex01_02
{
    public class Program
    {
        public static void Main()
        {
            DiamondForBeginners(5, 0);
        }

        public static void DiamondForBeginners(int i_DiamondHigh, int i_CurrentRow)
        {
            if (i_CurrentRow < i_DiamondHigh * 2 - 1)//musere the num of total rows
            {
                int numStarsToPrint;
                int numSpaceToPrint;

                if (i_CurrentRow < i_DiamondHigh)//if we got to the "middle" of the rows
                {
                    numStarsToPrint = i_CurrentRow * 2 + 1;
                }
                else
                {
                    numStarsToPrint = (i_DiamondHigh * 2 - 1 - i_CurrentRow) * 2 - 1;
                }

                numSpaceToPrint = (i_DiamondHigh * 2 - 1 - numStarsToPrint) / 2;

                StringBuilder textToPrint = new System.Text.StringBuilder();
                string spacesToprint = new string(' ', numSpaceToPrint);
                string starsToPrint = new string('*', numStarsToPrint);

                textToPrint.Append(spacesToprint).Append(starsToPrint).Append(spacesToprint);


                System.Console.WriteLine(textToPrint.ToString());
                DiamondForBeginners(i_DiamondHigh,i_CurrentRow + 1);
            }
        }
    }
}
