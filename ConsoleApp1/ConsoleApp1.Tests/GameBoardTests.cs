using Xunit;

namespace ConsoleApp1.Tests
{
    public class GameBoardTests
    {
        [Fact]
        public void Get_WhenGameStarts_ThenGameBoardGreetingIsCorrect()
        {
            GameBoard board = new GameBoard();

            Assert.Equal("Tad sākam :)!", board.GameBoardGreeting());
        }


        [Fact]
        public void Get_WhenGameStarts_ThenGameBoardGreeting2IsCorrect()
        {
            GameBoard board = new GameBoard();

            Assert.Equal("Veiksmi!", board.GameBoardGreeting2());
        }



    }
}
