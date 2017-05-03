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

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            CarsController controller = new CarsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Car>>(result);
        }

        [Fact]
        public void Post_MethodAddsItem_Test()
        {
            //Arrange
            CarsController controller = new CarsController();
            ViewResult indexView = new CarsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Car>;
            var collectionLength = collection.Count();

            //Act
            controller.NewCar("Make", "Model", "Year", 1, "test car description");
            var collectionLength2 = collection.Count();

            //Assert
            Assert.Equal(collectionLength, collectionLength2);
        }
    }
}
