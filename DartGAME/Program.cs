using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGAME
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterA = 0, counterB = 0, counterC = 0, counterD = 0, counterMissed = 0;
            int countergamesplayed = 0;
            Console.WriteLine("DART GAME!");
            Console.WriteLine();
            double percentageofA = 0, percentageofB = 0, percentageofC = 0, percentageofD = 0;
            int numberofdarts, x, y;
            int i = 1;
            Console.Write("Enter the number of darts to be thrown: ");
            numberofdarts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Random rand = new Random();
            for (; i <= numberofdarts; i++)
            {
                x = rand.Next(-7, 7);
                y = rand.Next(-7, 7);
                if (0 <= y && y <= 5 && 0 <= x && x <= 5)
                {
                    Console.WriteLine("DART {0}:\nCoordinates: ({1},{2})\nRegion:A\n", i, x, y);
                    counterA++;
                    countergamesplayed++;
                }
                else if (0 <= y && y <= 5 && -5 <= x && x < 0)
                {
                    Console.WriteLine("DART {0}:\nCoordinates: ({1},{2})\nRegion:B\n ", i, x, y);
                    counterB++;
                    countergamesplayed++;
                }
                else if (-5 <= x && x < 0 && -5 <= y && y < 0)
                {
                    Console.WriteLine("DART {0}:\nCoordinates: ({1},{2})\nRegion:C\n ", i, x, y);
                    counterC++;
                    countergamesplayed++;
                }
                else if (0 <= x && x <= 5 && -5 <= y && y < 0)
                {
                    Console.WriteLine("DART {0}:\nCoordinates: ({1},{2})\nRegion:D\n ", i, x, y);
                    counterD++;
                    countergamesplayed++;
                }
                else
                {
                    Console.WriteLine("DART {0}:\nCoordinates: ({1},{2})\nRegion:Missed\n", i, x, y);
                    counterMissed++;
                    break;
                }
            }
            if (countergamesplayed == 0 && numberofdarts != 1)
            {
                percentageofA = 1.0 * counterA / i;
                percentageofB = 1.0 * counterB / i;
                percentageofC = 1.0 * counterC / i;
                percentageofD = 1.0 * counterD / i;
                Console.WriteLine("Although {9} games are not played, stop the game.\nRegion statistics:\nTotal game: {0}\nA:{1} dart(s)({2:0.00}%)" +
                    "\nB:{3} dart(s)({4:0.00}%)\nC:{5} dart(s)({6:0.00}%)\nD:{7} dart(s)({8:0.00}%)", countergamesplayed, counterA, percentageofA * 100, counterB, percentageofB * 100, +
            counterC, percentageofC * 100, counterD, percentageofD * 100, numberofdarts);
            }
            else if (counterMissed == 1 && numberofdarts == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Region statistics:\nTotal game: 1\nA: 0 dart(s)(0.00%)\nB: 0 dart(s)(0.00%)\nC: 0 dart(s)(0.00%)\nD: 0 dart(s)(0.00%)");
            }
            else if (countergamesplayed < numberofdarts - 1)
            {
                countergamesplayed = i - 1;
                percentageofA = 1.0 * counterA / countergamesplayed;
                percentageofB = 1.0 * counterB / countergamesplayed;
                percentageofC = 1.0 * counterC / countergamesplayed;
                percentageofD = 1.0 * counterD / countergamesplayed;
                Console.WriteLine("Although {9} games are not played, stop the game.\nRegion statistics:\nTotal game: {0}\nA:{1} dart(s)({2:0.00}%)\nB:{3} dart(s)({4:0.00}%)\nC:{5} dart(s)({6:0.00}%)\nD:{7} dart(s)({8:0.00}%)", +
                countergamesplayed, counterA, percentageofA * 100, counterB, percentageofB * 100, counterC, percentageofC * 100, counterD, percentageofD * 100, numberofdarts);
            }
            else
            {
                countergamesplayed = i - 1;
                percentageofA = 1.0 * counterA / countergamesplayed;
                percentageofB = 1.0 * counterB / countergamesplayed;
                percentageofC = 1.0 * counterC / countergamesplayed;
                percentageofD = 1.0 * counterD / countergamesplayed;
                Console.WriteLine("Region statistics:\nTotal game: {0}\nA:{1} dart(s)({2:0.00}%)\nB:{3} dart(s)({4:0.00}%)\nC:{5} dart(s)({6:0.00}%)\nD:{7} dart(s)({8:0.00}%)", +
                countergamesplayed, counterA, percentageofA * 100, counterB, percentageofB * 100, counterC, percentageofC * 100, counterD, percentageofD * 100);
            }
        }
    }
}
