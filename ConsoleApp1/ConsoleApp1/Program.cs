


using ConsoleApp1;


Rules.pattern(4,10);

string gmName = Configuration.GameName;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(gmName);
Console.ResetColor(); 

Rules SkaitluMinetajs = new Rules();

SkaitluMinetajs.Greeting();

Console.WriteLine("Šī ir mācību nolūkos izveidotā skaitļu minēšanas spēle");
Console.WriteLine("Matrix ir izvēlējies skaitli.");
Console.WriteLine("Tavs uzdevums ir to atminēt.Matrix tev dos mājienu, ja tavs ievadītais skaitlis ir par lielu vai par mazu.");
Console.WriteLine("Lūdzu seko tam, cik mēģinājumi tev ir atlikuši!");



Player player = new Player();

player.GetPlayerName();
 


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

Console.WriteLine($"{player}, paldies par spēli :)");


