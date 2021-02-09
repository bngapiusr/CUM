using CUM.Data;
using CUM.Domain.Entities;
using Xunit;

namespace CUM.Test.Users
{
    public class UserTests : BaseTest
    {

        #region Add User

        [Fact]
        public void AddUser_Return_UserId()
        {
            // Arrange
            var user = new UserRequest
            {
                UserId = 0,
                UserName = "TestUser",
                FirstName = "John",
                MiddleInitial = "J",
                LastName = "Smith",
                Email = "jsmith@testing.com",
                EmailConfirmed = "smith@testing.com",
                Password = "P@ssw0rd"
            };

            var newusr = new User
            {
                UserId = user.UserId,
                UserName = user.UserName,
                FirstName = user.FirstName,
                MiddleInitial = user.MiddleInitial,
                LastName = user.LastName,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                Password = user.Password

            };

            // Act
            cxt.User.Add(newusr);
            cxt.SaveChanges();

            // Assert
            Assert.Equal(1, user.UserId);

        }

        //[Fact]
        //public async void Task_GetUserById_Return_OkResult()
        //{
        //    // Arrange the data
        //    var controller = new UserController();
        //    var userId = 1;

        //    // Performing the data
        //    var data = await controller.GetPost(userId);

        //    // Matching the ouput (Arrange, Act, Assert)
        //    Assert.IsType<OkObjectResult>(data);
        //}



        #endregion


       
    }
}