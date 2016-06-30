using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMaxNuoPradziu
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Controller c = new Controller();
            c.mySeed = "o";
            c.oppSeed = "x";
            for (int i = 0; i < 9; i++)
            {
                c.gameBoard[i] = " ";
            }
            c.gameBoard[c.MiniMax(c.mySeed, 8)[1]] = c.mySeed;       //jei kompas pirmas
            printMatrix(c);
            while (true) { 
            string input = Console.ReadLine();
                //c.gameBoard[Int32.Parse(input)] = c.mySeed;            //jei zaidejas pirmas
                //c.gameBoard[c.MiniMax(c.oppSeed, 8)[1]] = c.oppSeed;
                c.gameBoard[Int32.Parse(input)] = c.oppSeed;         //jei kompas pirmas
                c.gameBoard[c.MiniMax(c.mySeed, 8)[1]] = c.mySeed;
                printMatrix(c);
            }

        }
        public static void printMatrix(Controller c)
        {
            Console.WriteLine((c.gameBoard[0]) + (" ") + c.gameBoard[1] + (" ") + c.gameBoard[2] + (" "));
            Console.WriteLine((c.gameBoard[3]) + (" ") + c.gameBoard[4] + (" ") + c.gameBoard[5] + (" "));
            Console.WriteLine((c.gameBoard[6]) + (" ") + c.gameBoard[7] + (" ") + c.gameBoard[8] + (" "));
        }
    }

}
