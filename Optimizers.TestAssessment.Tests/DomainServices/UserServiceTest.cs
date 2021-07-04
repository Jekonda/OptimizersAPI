using System.Threading.Tasks;
using Moq;
using Optimizers.TestAssessment.Database;
using Optimizers.TestAssessment.DomainModels.DTO;
using Optimizers.TestAssessment.DomainServices;
using Optimizers.TestAssessment.Repositories.Interface;
using Xunit;

namespace Optimizers.TestAssessment.Tests.DomainServices
{
    public class UserServiceTest
    {
        private readonly Mock<IUserRepository> _userRepositoryMock = new Mock<IUserRepository>();
        
        #region CreateUser

        [Fact]
        public async Task CreateUser_ValidParams_NotNull()
        {
            //Arrange
            _userRepositoryMock.Setup(x => x.CreateUser(It.IsAny<User>())).ReturnsAsync(new User());

            var userService = new UserService(_userRepositoryMock.Object);

            //Act
            var actionResult = await userService.CreateUser(new UserDTO());

            //Assert
            Assert.NotNull(actionResult);
        }
        
        [Fact]
        public async Task CreateUser_NotValidParams_Null()
        {
            //Arrange
            _userRepositoryMock.Setup(x => x.CreateUser(It.IsAny<User>())).ReturnsAsync((User)null);

            var userService = new UserService(_userRepositoryMock.Object);

            //Act
            var actionResult = await userService.CreateUser(new UserDTO());

            //Assert
            Assert.Null(actionResult);
        }
        
        #endregion
    }
}