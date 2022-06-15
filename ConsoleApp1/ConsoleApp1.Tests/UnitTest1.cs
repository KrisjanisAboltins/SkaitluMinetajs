using Xunit;

namespace ConsoleApp1.Tests
{
    public class ConfigurationTests
    {
        [Fact]
        public void IsItRightGamneName()
        {
            //Arange
            string v = "MATRIX SKAITĻU MINĒTĀJS";
            //Act
            string configuration = Configuration.GameName;
           
            //Assert
            Assert.Equal ("MATRIX SKAITĻU MINĒTĀJS", Configuration.GameName);
        }

       
    }
}