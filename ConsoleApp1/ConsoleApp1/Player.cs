using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {


        public void GetPlayerName()
        {
            Console.WriteLine("Sākam! Lūdzu ieraksti savu vārdu");
            string player = Console.ReadLine();
            Console.WriteLine($"Prieks iepazīties, {player}!");
        }

        public void CountAttempts() 
        {
            
        }
    }

}



