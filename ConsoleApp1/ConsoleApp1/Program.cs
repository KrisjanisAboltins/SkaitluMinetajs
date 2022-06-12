


using ConsoleApp1;

Rules.pattern(4,14);

string gmName = Configuration.GameName;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(gmName);
Console.ResetColor(); 

Rules SkaitluMinetajs = new Rules();

SkaitluMinetajs.Greeting();

Console.WriteLine("Šī ir mācību nolūkos izveidotā skaitļu minēšanas spēle ar 3 grūtības līmeņiem.");
Console.WriteLine("1.līmenī tu drīskti minēt 3 reizes, 2.līmenī - 5 reizes, bet 3.līmenī 7 reizes");
Console.WriteLine("Matrix ir izvēlējies skaitli un Tavs uzdevums ir to atminēt.");
Console.WriteLine("Matrix tev dos mājienu, ja Tavs ievadītais skaitlis ir par lielu vai par mazu.");
Console.WriteLine("Lūdzu seko tam, cik mēģinājumi Tev ir atlikuši!");


string player = Player.GetPlayerName();


Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.ResetColor();


ConsoleApp1.GameBoard board = new GameBoard();


Console.WriteLine(board.GameBoardGreeting());

Console.WriteLine(board.GameBoardGreeting2());


board.Game_1Board();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.ResetColor();

board.Game_2Board();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.ResetColor();

board.Game_3Board();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.ResetColor();

//VĒl JĀPASTRĀDĀ pie šī varianta
//Console.WriteLine($"{player}, vai vēlies spēlēt no jauna? JĀ/ Nē!");
//string answer = Console.ReadLine();
//if (answer != "JĀ")
//{
//    retry = false;
//}
//break;

Console.WriteLine($"{player}, paldies par spēli :)");




