using System;

public class GameBoard
{

	Console.WriteLine("Tad sākam :)!");

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
    if (guessCount<guessCountLimit)
    {
        Console.WriteLine($"{userName}, lūdzu, ieraksti savu skaitli no 1 līdz 5, ja nebūs pareizi būs jāraksta vēl :)");
        guess = Console.ReadLine();
        guessCount++;
    }
    else reachedguessCountLimit = true;
}

if (reachedguessCountLimit) Console.WriteLine($"Sasniegts skaitļu minēšans limits {guessCountLimit} , diemžēl tu zaudēji :(");

else Console.WriteLine($":):):) " +
    $"Tu ierakstīji skaitli {secretNumber1}, skaitlis ir pareizs, {userName}, TU UZMINĒJI!");

//Console.WriteLine();
//Console.WriteLine("================================================================================");
//Console.WriteLine();


Console.WriteLine("nākamā spēle, gadījuma skaitlis no 1 līdz 10");
{
    Random random2 = new Random();
    int randomnumber1to10 = random2.Next(1, 11);
    int guess1to10;
    int guesscountlimit1to10 = 5;
    bool reachedguesscountlimit1to10 = false;

    Console.WriteLine("es iedomājos veselu skaitli no 1 līdz 10");
    Console.WriteLine($"{userName}, lūdzu, ieraksti veselu skaitli, tev ir {guesscountlimit1to10} iespējas");

    while (reachedguesscountlimit1to10 == false)
    {
        guess1to10 = int.Parse(Console.ReadLine());
        guesscountlimit1to10--;

        if (guesscountlimit1to10 != randomnumber1to10 && guesscountlimit1to10 == 0)
        {
            Console.WriteLine($"tavu iespēju skaits ir beidzies, pareizais skaitslis bija {randomnumber1to10}");
            reachedguesscountlimit1to10 = true;
        }
        else if (guess1to10 == randomnumber1to10)
        {
            Console.WriteLine($":):):) " +
            $"tu ierakstīji skaitli {randomnumber1to10}, skaitlis ir pareizs, {userName}, tu uzminēji!");
            reachedguesscountlimit1to10 = true;
        }
        else if (guess1to10 > randomnumber1to10) Console.WriteLine("es tev nedaudz palīdzēšu, mans skaitlis ir mazāks, mēģini vēlrez ierakstīt savu skaitli");
        else if (guess1to10 < randomnumber1to10) Console.WriteLine("es tev nedaudz palīdzēšu, mans skaitlis ir lielāks, mēģini vēlrez ierakstīt savu skaitli");
    }
    Console.ReadLine();
}

//console.writeline();
//console.writeline("================================================================================");
//console.writeline();



Console.WriteLine($"Nākamā spēle, šoreiz grūtāka, {userName}, būs jātmin 1 skaitlis");

Random random3 = new Random();
int randSecretNumber3 = random3.Next(1, 500);
int guess1to20;
int guessCountLimit1to20 = 7;
bool reachedguessCountLimit1to20 = false;

int advice1 = (randSecretNumber3 / 7);
int advice2 = (randSecretNumber3 % 7);

Console.WriteLine("Es iedomājos veselu skaitli no 1 līdz 500, bet es Tev nedaudz palīdzēšu");
Console.WriteLine($"Lūdzu, ieraksti veselu skaitli, Tev ir {guessCountLimit1to20} iespējas");
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
            "to dalot uz 7 sanāk {advice1} bet pāri paliek {advice2}, mēģini vēlrez ierakstīt savu skaitli");

        else if (guess1to20 < randSecretNumber3) Console.WriteLine($"Mans skaitlis ir lielāks, " +
            $"to dalot uz 7 sanāk {advice1} bet pāri paliek {advice2}, mēģini vēlrez ierakstīt savu skaitli");
    }
    Console.ReadLine();
}





}
