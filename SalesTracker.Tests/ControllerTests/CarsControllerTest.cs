using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesTracker.Controllers;
using Xunit;
using SalesTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace SalesTracker.Tests
{
    public class CarsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            CarsController controller = new CarsController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);

        }
    }
}
