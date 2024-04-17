using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.018008, -86.079099, Taco Bell Attall...", -86.079099)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("33.22997, -86.805275, Taco Bell Alabaste...", 33.22997)]
        [InlineData("33.145076,-86.749777,Taco Bell Caler...",33.145076)]
        [InlineData("34.796417,-84.962282,Taco Bell Dalton...",34.796417)]

        public void ShouldParseLatitude(string line, double expected)
        {
            var tacoParser1 = new TacoParser();
            var actual = tacoParser1.Parse(line);
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
