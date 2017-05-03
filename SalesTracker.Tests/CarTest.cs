using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesTracker.Models;
using Xunit;


namespace SalesTracker.Tests
{
    public class CarTest
    {
        [Fact]
        public void GetMakeTest()
        {
            //Arrange
            var newCar = new Car();
            newCar.Make = "Lexus";


            //Act
            var result = newCar.Make;

            //Assert
            Assert.Equal("Lexus", result);
        }
    }
}
