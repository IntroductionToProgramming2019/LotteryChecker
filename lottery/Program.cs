/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Lottery
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            int winningNumber1 = 3;
            int winningNumber2 = 5;
            int winningNumber3 = 6;
            int userPrize = 0;
            Console.WriteLine("enter your first number: ");
            int chosenNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your second number ");
            int chosenNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your third number ");
            int chosenNumber3 = int.Parse(Console.ReadLine());

            int counterWinningNumbers = 0;
            if ((chosenNumber1 == winningNumber1) || (chosenNumber1 == winningNumber2) || (chosenNumber1 == winningNumber3))
            {
                counterWinningNumbers++;
            }
            if ((chosenNumber2 == winningNumber1) || (chosenNumber2 == winningNumber2) || (chosenNumber2 == winningNumber3))
            {
                counterWinningNumbers++;
            }
            if ((chosenNumber3 == winningNumber1) || (chosenNumber3 == winningNumber2) || (chosenNumber3 == winningNumber3))
            {
                counterWinningNumbers++;
            }
            if (counterWinningNumbers == 0)
            {
                userPrize = 0;
            }
            if (counterWinningNumbers == 1)
            {
                userPrize = 10;
            }
            if (counterWinningNumbers == 2)
            {
                userPrize = 100;
            }
            if (counterWinningNumbers == 3)
            {
                userPrize = 1000;
            }
            Console.WriteLine("You picked {0} winning numbers, your prize money is {1:c}", counterWinningNumbers, userPrize);
        }
    }
}
