using ControllersAndActions.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace ControllersAndActions.Tests
{
    public class ActionTests
    {
        
        [Fact]
        public void NotFoundActionMethod()
        {
            // Arrange
            ExampleController controller = new ExampleController();
            // Act
            StatusCodeResult result = controller.Index();
            // Assert
            Assert.Equal(404, result.StatusCode);
        }
    }
}
