using Xunit;
using LoginApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq; // Note: Add Moq package if testing locally
using LoginApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LoginApi.Tests
{
    public class UnitTests
    {
        [Fact]
        public async Task Register_NewUser_ReturnsOk()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var context = new ApplicationDbContext(options);
            var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string> { {"JWT:Secret", "secret"} }).Build();
            var controller = new AuthController(context, config);

            var dto = new RegisterDto { FirstName = "Test", LastName = "User", Email = "test@example.com", Password = "pass" };

            // Act
            var result = await controller.Register(dto);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        // Add more tests similarly...
    }
}
