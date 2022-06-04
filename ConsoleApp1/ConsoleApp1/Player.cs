using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {


        public static string GetPlayerName()
        {
            Console.WriteLine("Sākam! Lūdzu ieraksti savu vārdu");
            string player = Console.ReadLine();
            Console.WriteLine($"Prieks iepazīties, {player}!");
            return player;
        }
        
        public void CountAttempts() 
        {
            //Console.WriteLine($"Paldies par spēli. Tu minēji {guessCount} reizes."); 
            //šo piedāvāju likt Gameboard 49.rindiņā
        }
    }

}



