using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameBoard
    {


        public string greeting = "Tad sākam :)!";
        public string GameBoardGreeting() { return greeting; }

        public string greeting2 = "Veiksmi!";
        public string GameBoardGreeting2() { return greeting2; }


        public void Game_1Board()
        {
        Start1:
            Random random1 = new Random();
            int randSecretNumber1 = random1.Next(1, 6);

            string secretNumber1 = randSecretNumber1.ToString();
            string guess = "";
            int guessCount = 0;

            EnumLevel countLimit1 = EnumLevel.guessCountLimit;
            int countLimit1Value = (int)countLimit1;

            //int guessCountLimit = 3;
            bool reachedguessCountLimit = false;


            while (guess != secretNumber1 && !reachedguessCountLimit)
            {
                if (guessCount < countLimit1Value)
                {
                    Console.WriteLine($"Lūdzu, ieraksti savu skaitli no 1 līdz 5, ja nebūs pareizi būs jāraksta vēl :)");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else reachedguessCountLimit = true;
            }

            if (reachedguessCountLimit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sasniegts skaitļu minēšans limits {countLimit1Value} , diemžēl tu zaudēji :(");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($":):):) " +
                $"Tu ierakstīji skaitli {secretNumber1}, skaitlis ir pareizs, Tu minēji {guessCount} reizes un TU UZMINĒJI!");
                Console.ResetColor();
            }
            Console.WriteLine("Vēlies atkārtot 1.līmeņa spēli (ja/ne): ");
            string result = Console.ReadLine();

            if (result == "ne") ;


            else goto Start1;
            Console.Clear();


        }

        public void Game_2Board()
        {
        

            Console.WriteLine("Nākamais 2.līmenis");
            {
            Start2:
                Random random2 = new Random();
                int randomNumber1to10 = random2.Next(1, 11);
                int guess1to10;

                EnumLevel countLimit2 = EnumLevel.guessCountLimit1to10;
                int countLimit2Value = (int)countLimit2;

                //int guessCountLimit1to10 = 5;
                
                bool reachedguessCountLimit1to10 = false;

                Console.WriteLine("Es iedomājos veselu skaitli no 1 līdz 10");
            
                Console.WriteLine($"Lūdzu, ieraksti veselu skaitli, Tev ir {countLimit2Value} iespējas");

                while (reachedguessCountLimit1to10 == false)
                {
                    guess1to10 = int.Parse(Console.ReadLine());
                    countLimit2Value--;

                    if (guess1to10 == randomNumber1to10)
                    //(guessCountLimit1to10 != randomNumber1to10 && guessCountLimit1to10 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($":):):) " +
                        $"Tu ierakstīji skaitli {randomNumber1to10}, skaitlis ir pareizs, TU UZMINĒJI!");
                        reachedguessCountLimit1to10 = true;
                        Console.ResetColor();

                    }
                    else if (countLimit2Value != randomNumber1to10 && countLimit2Value == 0)
                    //(guess1to10 == randomNumber1to10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Tavu iespēju skaits ir beidzies, pareizais skaitslis bija {randomNumber1to10}");
                        reachedguessCountLimit1to10 = true;
                        Console.ResetColor();

                    }
                    else if (guess1to10 > randomNumber1to10) Console.WriteLine("Es Tev nedaudz palīdzēšu, mans skaitlis ir mazāks, mēģini vēlrez ierakstīt savu skaitli");
                    else Console.WriteLine("Es Tev nedaudz palīdzēšu, mans skaitlis ir lielāks, mēģini vēlrez ierakstīt savu skaitli");
                }
                Console.WriteLine("Vēlies atkārtot 2.līmeņa spēli (ja/ne): ");
                string result2 = Console.ReadLine();

                if (result2 == "ne") ;

                else goto Start2;
                Console.Clear();
            }
            
        }




        public void Game_3Board() 
        {
            Console.WriteLine($"Nākamais 3.līmenis, šoreiz grūtāks!");
            Start3:
            Random random3 = new Random();
            int randSecretNumber3 = random3.Next(1, 501);
            int guess1to20;


            EnumLevel countLimit3 = EnumLevel.guessCountLimit1to20;
            int countLimit3Value = (int)countLimit3;

            //int guessCountLimit1to20 = 7;

            bool reachedguessCountLimit1to20 = false;

            int advice1 = (randSecretNumber3 / 7);
            int advice2 = (randSecretNumber3 % 7);

            Console.WriteLine("Es iedomājos veselu skaitli no 1 līdz 500, bet es Tev nedaudz palīdzēšu");
            Console.WriteLine($"Lūdzu, ieraksti veselu skaitli, Tev ir {countLimit3Value} iespējas");
            
                while (reachedguessCountLimit1to20 == false)
                {
                    guess1to20 = int.Parse(Console.ReadLine());
                    countLimit3Value--;

                    if (guess1to20 == randSecretNumber3)
                    {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($":):):) " +
                    $"Tu ierakstīji skaitli {randSecretNumber3}, skaitlis ir pareizs, TU UZMINĒJI!");
                    reachedguessCountLimit1to20 = true;
                    Console.ResetColor();
                }
                else if (countLimit3Value != randSecretNumber3 && countLimit3Value == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Tavu iespēju skaits ir beidzies, pareizais skaitslis bija {randSecretNumber3}");
                    reachedguessCountLimit1to20 = true;
                    Console.ResetColor();
                }
                else if (guess1to20 > randSecretNumber3) Console.WriteLine($"Es Tev nedaudz palīdzēšu, Mans skaitlis ir mazāks, " +
                        $"to dalot uz 7 sanāk {advice1} bet pāri paliek {advice2}, mēģini vēlrez ierakstīt savu skaitli");

                    else Console.WriteLine($"Es Tev nedaudz palīdzēšu, Mans skaitlis ir lielāks, " +
                        $"to dalot uz 7 sanāk {advice1} bet pāri paliek {advice2}, mēģini vēlrez ierakstīt savu skaitli");
                }
            Console.WriteLine("Vēlies atkārtot 2.līmeņa spēli (ja/ne): ");
            string result3 = Console.ReadLine();

            if (result3 == "ne") ;


            else goto Start3;
            Console.Clear();
        }

               
    }

}


