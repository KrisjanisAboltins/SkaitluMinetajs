namespace ConsoleApp1
{
    
    public static class Tools
    {
        
        public static int InputNumber(int from, int to)
        {
            ConsoleKeyInfo key;
            int number = 0;

            while (true)
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter && number >= from && number <= to)
                {
                    Console.WriteLine();
                    break;
                }
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (number > 0)
                    {
                        number /= 10;
                        Console.Write("\b \b");
                    }
                }
                if (key.KeyChar >= '0' && key.KeyChar <= '9')
                {
                    int digit = int.Parse(key.KeyChar.ToString());
                    if (number * 10 + digit <= to)
                    {
                        if (number > 0 || digit >= 1)
                        {
                            number = number * 10 + digit;
                            Console.Write(key.KeyChar);
                        }
                    }
                }
            }

            return number;
        }

      
        public static string InputString()
        {
            string line = Console.ReadLine().Trim();
            while (line.Length == 0)
            {
                Console.WriteLine("Nepareizs vārds, lūdzu meģini vēlreiz!");
                line = Console.ReadLine().Trim();
            }
            return line;
        }

        public static void PrintYellowLine()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("================================================================================");
            Console.WriteLine();
            Console.ResetColor();
        }

       
        
    }
}
