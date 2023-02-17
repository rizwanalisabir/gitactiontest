using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()    
        {
            var controller = new HomeController(null);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Test2() 
        {
            var controller = new HomeController(null);
            // Act
            var result = controller.Privacy();
            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}