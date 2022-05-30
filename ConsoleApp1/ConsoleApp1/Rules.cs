using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rules
    {
        public string GameRules { get; set; }   

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
                            Console.Write("*");
                        else if (k == e)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                x = x + 2;
                e = e + 2;

                Console.WriteLine();
            }
        }



    }
}
