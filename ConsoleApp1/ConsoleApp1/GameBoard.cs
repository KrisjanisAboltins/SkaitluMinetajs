using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameBoard
    {



        public void GameBoardGreeting()
        {
            Console.WriteLine("Tad sākam :)!");
        }



        

        public void Game1Board()
        {

            Random random1 = new Random();
            int randSecretNumber1 = random1.Next(1, 6);

            string secretNumber1 = randSecretNumber1.ToString();
            string guess = "";
            int guessCount = 0;
            int guessCountLimit = 3;
            bool reachedguessCountLimit = false;


            while (guess != secretNumber1 && !reachedguessCountLimit)
            {
                if (guessCount < guessCountLimit)
                {
                    Console.WriteLine($"Lūdzu, ieraksti savu skaitli no 1 līdz 5, ja nebūs pareizi būs jāraksta vēl :)");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else reachedguessCountLimit = true;
            }

            if (reachedguessCountLimit) Console.WriteLine($"Sasniegts skaitļu minēšans limits {guessCountLimit} , diemžēl tu zaudēji :(");

            else Console.WriteLine($":):):) " +
            $"Tu ierakstīji skaitli {secretNumber1}, skaitlis ir pareizs, TU UZMINĒJI!");

        }






    }

}
