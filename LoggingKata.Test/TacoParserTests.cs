using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
         [Fact]
         public void ShouldDoSomething()
         {
             // TODO: Complete Something, if anything

             //Arrange
             var tacoParser = new TacoParser();

             //Act
             var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

             //Assert
             Assert.NotNull(actual);
         }


        // TODO: Complete - "line" represents input data we will Parse to
        //       extract the Longitude.  Your .csv file will have many of these lines,
        //       each representing a TacoBell location

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("654113,-87.912144,Taco Bell Daphn... ", -87.912144)]
        [InlineData("795116,-86.97191,Taco Bell Athens...", -86.97191)]
        [InlineData("571839,-87.014351,Taco Bell Decatur...", -87.014351)]
        public void ShouldParseLongitude(string line, double expected)
        {
            //Arrange -  
            var longitudeParser = new TacoParser();
            //Act
            var actual = longitudeParser.Parse(line).Location.Longitude;
            //Assert
            Assert.Equal(expected, actual);
        }



        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("654113,-87.912144,Taco Bell Daphn... ", 654113)]
        [InlineData("795116,-86.97191,Taco Bell Athens...", 795116)]
        [InlineData("571839,-87.014351,Taco Bell Decatur... ", 571839)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var latitudeParser = new TacoParser();
            //Act
            var actual = latitudeParser.Parse(line).Location.Latitude;
            //Assert
            Assert.Equal(expected, actual);
        }
    }

}
