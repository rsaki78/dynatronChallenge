using Dyna.API.Data;
using Dyna.API.Models;
using Dyna.API.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Dyna.API.Test.Services
{
    public class CustomerServiceTests
    {
        private MockRepository mockRepository;

        private Mock<CustomerContext> mockCustomerContext;

        public CustomerServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockCustomerContext = this.mockRepository.Create<CustomerContext>();
        }

        private CustomerService CreateService()
        {
            return new CustomerService(
                this.mockCustomerContext.Object);
        }

        [Fact]
        public async Task GetCustomers_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = await service.GetCustomers();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetCustomer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            long id = 0;

            // Act
            var result = await service.GetCustomer(
                id);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CreateCustomer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            Customer customer = null;

            // Act
            var result = await service.CreateCustomer(
                customer);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task UpdateCustomer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            long id = 0;
            Customer customer = null;

            // Act
            await service.UpdateCustomer(
                id,
                customer);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteCustomer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            long id = 0;

            // Act
            await service.DeleteCustomer(
                id);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
