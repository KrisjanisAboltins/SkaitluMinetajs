


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

//string player = Player.GetPlayerName();
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


Console.WriteLine("Bet pirms atsākam vēlreiz, būsim priecīgi par spēles novērtējumu (ar 1 līdz 10, kur 1 ir zemākais vērtējums un 10 ir augstākais)");

try
{
    string GameRatingText = Console.ReadLine();
    int GameRatingNumber = int.Parse(GameRatingText);

    if (GameRatingNumber > 10 || GameRatingNumber == 0)
    {
        throw new NumberExceptions("Skaitlis ir ārpus vērtējuma robežām");
    }

}

catch (FormatException)
{
    Console.WriteLine("Tas nebija skaitlis");
}

catch (NumberExceptions NumberExceptions)
{
    Console.WriteLine($"Kļudas paziņojums: {NumberExceptions.Message}");
}

catch (Exception)
{
    Console.WriteLine("Bija kāda nezināma kļuda");
}

Console.WriteLine("================================================================================");


board.Game_1Board();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.ResetColor();

board.Game_2Board();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.ResetColor();

board.Game_3Board();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("================================================================================");
Console.WriteLine();
Console.ResetColor();


//Console.WriteLine($"{player}, paldies par spēli :)");









