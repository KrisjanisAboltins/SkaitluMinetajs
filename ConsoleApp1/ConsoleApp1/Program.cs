


Console.WriteLine("Labdien,");
Console.WriteLine("Kā tevi sauc?");
string userName = Console.ReadLine();
Console.WriteLine($"Prieks iepazīties, {userName} šī ir " +
    $"mācību nolūkos izveidotā skaitļu minēšanas spēle");

Console.WriteLine("Tad sākam :)!");


string secretNumber1 = "3";
string guess = "";
int guessCount = 0;
int guessCountLimit = 3;
bool reachedguessCountLimit = false;

while (guess != secretNumber1 && !reachedguessCountLimit)
{
    if (guessCount < guessCountLimit)
    {
        Console.WriteLine("mini skaitli no 1 līdz 5, Tev kopā ir 3 iespējas");
        guess = Console.ReadLine();
        guessCount++;
    }
    else reachedguessCountLimit = true;
}

if (reachedguessCountLimit) Console.WriteLine("Sasniegts skaitļu minēšans limits, diemžēl tu zaudēji :(");

else Console.WriteLine($":):):) " +
    $"Tu ierakstīji skaitli {secretNumber1}, skaitlis ir pareizs, TU UZMINĒJI!");

Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Nākamā spēle, gadījuma skaitlis no 1 līdz 10");
{ 
Random random = new Random();
int randomNumber1to10 = random.Next(1, 11);
int guess1to10;
int guessCountLimit1to10 = 5;
bool reachedguessCountLimit1to10 = false;

Console.WriteLine("Es iedomājos veselu skaitli no 1 līdz 10");
Console.WriteLine($"Lūdzu, uzmini. tev ir {guessCountLimit1to10} iespējas");

while (reachedguessCountLimit1to10 == false)
{
    guess1to10 = int.Parse(Console.ReadLine());
    guessCountLimit1to10--;

    if (guessCountLimit1to10 != randomNumber1to10 && guessCountLimit1to10 == 0)
    {
        Console.WriteLine($"Tavu iespēju skaits ir beidzies, pareizais skaitslis bija {randomNumber1to10}");
        reachedguessCountLimit1to10 = true;
    }
    else if (guess1to10 == randomNumber1to10)
    {
        Console.WriteLine($":):):) " +
        $"Tu ierakstīji skaitli {randomNumber1to10}, skaitlis ir pareizs, TU UZMINĒJI!");
        reachedguessCountLimit1to10 = true;
    }
    else if (guess1to10 > randomNumber1to10) Console.WriteLine("Mans skaitlis ir mazāks");
    else if (guess1to10 < randomNumber1to10) Console.WriteLine("Mans skaitlis ir lielāks");
}
    Console.ReadLine();
}



