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
        GameLevel viegls = GameLevel.Low;
        GameLevel videjs = GameLevel.Medium;  
        GameLevel gruts = GameLevel.High;
        
        public static GameLevel GetPlayerLevel()        
        {
            while (true) 
            {
                Console.WriteLine("Izvēlies spēles grūtības līmeni: 1 - viegls, 2 - vidējs, 3 - grūts");
                string levelS = Console.ReadLine();  
                int level = int.Parse(levelS);
                if (level > 0 && level < 4)
                {
                    return (GameLevel)level;
                }
            }
        }       
            
        
    }

}



