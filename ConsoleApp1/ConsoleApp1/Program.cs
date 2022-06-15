


using ConsoleApp1;

Rules.pattern(4,14);

string gmName = Configuration.GameName;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(gmName);
Console.ResetColor(); 

Rules SkaitluMinetajs = new Rules();

SkaitluMinetajs.Greeting();

ConsoleApp1.Rules GameRules = new Rules();

Console.WriteLine(GameRules.GameRules());



Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.ResetColor();


ConsoleApp1.GameBoard board = new GameBoard();

Console.WriteLine(board.GameBoardGreeting());

Console.WriteLine(board.GameBoardGreeting2());

string player = Player.GetPlayerName();
GameLevel level = Player.GetPlayerLevel();

if (level == GameLevel.Low) 
{
    board.Game_1Board();
}
if (level == GameLevel.Medium)
{
    board.Game_2Board();
}
if (level == GameLevel.High)
{
    board.Game_3Board();
}

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


Console.WriteLine($"{player}, paldies par spēli :)");




