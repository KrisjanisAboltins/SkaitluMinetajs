


Console.WriteLine("Labdien,");
Console.WriteLine("Kā tevi sauc?");
string userName = Console.ReadLine();
Console.WriteLine($"Prieks iepazīties, {userName} šī ir " +
    $"mācību nolūkos izveidotā skaitļu minēšanas spēle");

Console.WriteLine("Tad sākam :)!");

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
        Console.WriteLine($"{userName}, mini skaitli no 1 līdz 5, Tev kopā ir 3 iespējas");
        guess = Console.ReadLine();
        guessCount++;
    }
    else reachedguessCountLimit = true;
}

if (reachedguessCountLimit) Console.WriteLine("Sasniegts skaitļu minēšans limits, diemžēl tu zaudēji :(");

else Console.WriteLine($":):):) " +
    $"Tu ierakstīji skaitli {secretNumber1}, skaitlis ir pareizs, {userName}, TU UZMINĒJI!");

Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Nākamā spēle, gadījuma skaitlis no 1 līdz 10");
{ 
Random random2 = new Random();
int randomNumber1to10 = random2.Next(1, 11);
int guess1to10;
int guessCountLimit1to10 = 5;
bool reachedguessCountLimit1to10 = false;

Console.WriteLine("Es iedomājos veselu skaitli no 1 līdz 10");
Console.WriteLine($"{userName}, lūdzu, uzmini. tev ir {guessCountLimit1to10} iespējas");

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
        $"Tu ierakstīji skaitli {randomNumber1to10}, skaitlis ir pareizs, {userName}, TU UZMINĒJI!");
        reachedguessCountLimit1to10 = true;
    }
    else if (guess1to10 > randomNumber1to10) Console.WriteLine("Es Tev nedaudz palīdzēšu, mans skaitlis ir mazāks");
    else if (guess1to10 < randomNumber1to10) Console.WriteLine("Es Tev nedaudz palīdzēšu, mans skaitlis ir lielāks");
}
    Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine($"Nākamā spēle, šoreiz grūtāka, {userName}, būs jātmin 1 skaitlis");

Random random3 = new Random();
int randSecretNumber3 = random3.Next(1, 500);
int guess1to20;
int guessCountLimit1to20 = 7;
bool reachedguessCountLimit1to20 = false;

int advice1 = (randSecretNumber3 / 10);
int advice2 = (randSecretNumber3 % 10);

Console.WriteLine("Es iedomājos veselu skaitli no 1 līdz 500, bet es Tev nedaudz palīdzēšu");
Console.WriteLine($"Lūdzu, uzmini. tev ir {guessCountLimit1to20} iespējas");
{

    while (reachedguessCountLimit1to20 == false)
    {
        guess1to20 = int.Parse(Console.ReadLine());
        guessCountLimit1to20--;

        if (guessCountLimit1to20 != randSecretNumber3 && guessCountLimit1to20 == 0)
        {
            Console.WriteLine($"Tavu iespēju skaits ir beidzies, pareizais skaitslis bija {randSecretNumber3}");
            reachedguessCountLimit1to20 = true;
        }
        else if (guess1to20 == randSecretNumber3)
        {
            Console.WriteLine($":):):) " +
            $"Tu ierakstīji skaitli {randSecretNumber3}, skaitlis ir pareizs, {userName}, TU UZMINĒJI!");
            reachedguessCountLimit1to20 = true;
        }
        else if (guess1to20 > randSecretNumber3) Console.WriteLine($"Es Tev nedaudz palīdzēšu, Mans skaitlis ir mazāks, " +
            "to dalot uz 7 sanāk {advice1} bet pāri paliek {advice2}");
        
        else if (guess1to20 < randSecretNumber3) Console.WriteLine($"Mans skaitlis ir lielāks, " +
            $"to dalot uz 7 sanāk {advice1} bet pāri paliek {advice2}");
    }
    Console.ReadLine();
}
