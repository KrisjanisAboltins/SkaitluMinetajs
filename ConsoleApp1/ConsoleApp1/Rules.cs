using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rules
    {
        public string gamerules = "Šī ir mācību nolūkos izveidotā skaitļu minēšanas spēle ar 3 grūtības līmeņiem. Matrix ir izvēlējies skaitli un Tavs uzdevums ir to atminēt. 1.līmenī tu drīskti minēt 3 reizes, 2.līmenī - 5 reizes, bet 3.līmenī 7 reizes.  Matrix tev dos mājienu, ja Tavs ievadītais skaitlis ir par lielu vai par mazu. Lūdzu seko tam, cik mēģinājumi Tev ir atlikuši! ";

        public string GameRules() { return gamerules; }

        public void Greeting ()
        {
            Console.WriteLine(" Es jau sen Tevi gaidīju...");
        }
        public static void pattern(int wave_height, int wave_length)
        {
            int   e, count, x;
            e = 2;
            x = 1;


            for (int i = 0; i < wave_height; i++)
            {
                for (int j = wave_height; j <= wave_height + i; j++)
                    Console.Write(" ");

            
                for (count = 1; count <= wave_length; count++)
                {
                 
                    for (int n = (wave_height + wave_height - 2); n >= x; n--)
                        Console.Write(" ");

                    for (int k = 1; k <= e; k++)
                    {
                        if (k == 1)
                            Console.Write("1");
                        else if (k == e)
                            Console.Write("2");
                        else
                            Console.Write("0");
                    }
                }
                x = x + 2;
                e = e + 2;

                Console.WriteLine();
            }
        }
        

    }
}
