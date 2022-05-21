


Console.WriteLine("Labdien,");
Console.WriteLine("Kā tevi sauc?");
string userName = Console.ReadLine();
Console.WriteLine($"Prieks iepazīties, {userName} šī ir " +
    $"mācību nolūkos izveidotā skaitļu minēšanas spēle");

Console.WriteLine("Tad sākam :)!");


string secretNumber1 = "3";
string guess = "";
int guessCount = 0;
int guessCountLimit = 5;
bool reachedguessCountLimit = false;

while (guess != secretNumber1 && !reachedguessCountLimit)
{
    if (guessCount < guessCountLimit)
    {
        Console.WriteLine("mini skaitli no 1 līdz 10, Tev kopā ir piecas iespējas");
        guess = Console.ReadLine();
        guessCount++;
    }
    else reachedguessCountLimit = true;
}
if (reachedguessCountLimit) Console.WriteLine("Sasniegts skaitļu minēšans limits, diemžēl tu zaudēji :(");


else Console.WriteLine($":):):) " +
    $"Tu ierakstīji skaitli {secretNumber1}, skaitlis ir pareizs, TU UZMINĒJI!");


Console.WriteLine("================================================================================");
