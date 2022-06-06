using Xunit;

namespace ConsoleApp1.Tests
{
    public class ConfigurationTests
    {
        [Fact]
        public void IsItRightGamneName()
        {
            //Arange
            string v = "Matrix Skaitļu Minētājs";
            //Act
            string configuration = Configuration.GameName;
           
            //Assert
            Assert.Equal ("Matrix Skaitļu Minētājs", Configuration.GameName);
        }

       
    }
}