


using ConsoleApp1;

Rules SkaitluMinetajs = new Rules();

SkaitluMinetajs.Greeting();

Console.WriteLine("Matrix ir izvēlējies skaitli.");
Console.WriteLine("Tavs uzdevums ir to atminēt.");
Console.WriteLine("Matrix tev dos mājienu, ja tavs ievadītais skaitlis ir par lielu vai par mazu.");
Console.WriteLine("Lūdzu seko tam, cik mēģinājumi tev ir atlikuši!");




//piedāvāju, ka izveidojam klasi Player, kur definējam visus spēlētāju raksturlielumus
//(šobrīd ieliku vārdu, vecumu, mēģinājumu skaitu, iegūtos punktus (ja izlemsim tos skaitīt)
//un uzvaras). In tad uzreiz katra spēlētāja info saglabāsim un varēsim izmantot.
//Ja pareizi saprotu, programmas failā tas izskatītos apmēram šādi:

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
Console.WriteLine("Lūdzu ieraksti kā Tevi sauc?");
string userName = Console.ReadLine();
Console.WriteLine($"Prieks iepazīties, {userName} šī ir " +
    $"mācību nolūkos izveidotā skaitļu minēšanas spēle");


Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();


ConsoleApp1.GameBoard board = new GameBoard();

board.GameBoardGreeting();

board.Game_1Board();

Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();

board.Game_2Board();

Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();

board.Game_3Board();

Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();

Console.WriteLine($"{userName}, paldies par spēli :)");


