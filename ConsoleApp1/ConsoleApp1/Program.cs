

using ConsoleApp1;

Rules SkaitluMinetajs = new Rules();

SkaitluMinetajs.Greeting();

Console.WriteLine("Matrix ir izvēlējies skaitli.");
Console.WriteLine("Tavs uzdevums ir to atminēt.");
Console.WriteLine("Matrix tev dos mājienu, ja tavs ievadītais skaitlis ir par lielu vai par mazu.");
Console.WriteLine("Lūdzu seko tam, cik mēģinājumi tev ir palikuši!");




//piedāvāju, ka izveidojam klasi Player, kur definējam visus spēlētāju raksturlielumus
//(šobrīd ieliku vārdu, vecumu, mēģinājumu skaitu, iegūtos punktus (ja izlemsim tos skaitīt)
//un uzvaras). In tad uzreiz katra spēlētāja info saglabāsim un varēsim izmantot.
//Ja pareizi saprotu, programmas failā tas izskatītos apmēram šādi:
using ConsoleApp1;
    {

    Player user1 = new Player();
user1.Name = "";
user1.Age = 0; // ievades dati laikam jāpārbauda, lai int tiešām ir int nevis string
user1.Attempts = 0; //šie nākamie trīs iegūsies spēlēs laikā un mums tos vajadzēs kaut kā uzkrāt
user1.Points = 0;
user1.Wins = 0;

Player user2 = new Player();
user2.Name = "";
user2.Age = 0;
user2.Attempts = 0;
user2.Points = 0;
user2.Wins = 0;
// utt. varam definēt spēlētāju skaitu vai jāizdomā, vai var būt neierobežots.
// Saprotu, ka ja gribam vairākus spēlētājus un pēc tam arī visu ko darīt ar šiem
//datiem, tad Krišjāņa kodā jālieto piemēram, 34 rindā nevis userName, bet user1.
// šis jau sāk palikt sarežģītāk, jo kodā uzreiz arī jāpiedefinē mēģinājumu skaits
//pirmajam spēlētājam tas būtu user1.Attempts, utt.


}



Console.WriteLine("Labdien,");
Console.WriteLine("Ļūdzu ieraksti kā Tevi sauc?");
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


console.writeline("nākamā spēle, gadījuma skaitlis no 1 līdz 10");
{
    random random2 = new random();
    int randomnumber1to10 = random2.next(1, 11);
    int guess1to10;
    int guesscountlimit1to10 = 5;
    bool reachedguesscountlimit1to10 = false;

    console.writeline("es iedomājos veselu skaitli no 1 līdz 10");
    console.writeline($"{username}, lūdzu, ieraksti veselu skaitli, tev ir {guesscountlimit1to10} iespējas");

    while (reachedguesscountlimit1to10 == false)
    {
        guess1to10 = int.parse(console.readline());
        guesscountlimit1to10--;

        if (guesscountlimit1to10 != randomnumber1to10 && guesscountlimit1to10 == 0)
        {
            console.writeline($"tavu iespēju skaits ir beidzies, pareizais skaitslis bija {randomnumber1to10}");
            reachedguesscountlimit1to10 = true;
        }
        else if (guess1to10 == randomnumber1to10)
        {
            console.writeline($":):):) " +
            $"tu ierakstīji skaitli {randomnumber1to10}, skaitlis ir pareizs, {username}, tu uzminēji!");
            reachedguesscountlimit1to10 = true;
        }
        else if (guess1to10 > randomnumber1to10) console.writeline("es tev nedaudz palīdzēšu, mans skaitlis ir mazāks, mēģini vēlrez ierakstīt savu skaitli");
        else if (guess1to10 < randomnumber1to10) console.writeline("es tev nedaudz palīdzēšu, mans skaitlis ir lielāks, mēģini vēlrez ierakstīt savu skaitli");
    }
    console.readline();
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
