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
            var userrequest = new UserRequest
            {
                UserId = 0,
                UserName = "TestUser",
                FirstName = "John",
                MiddleInitial = "J",
                LastName = "Smith",
                Email = "jsmith@testing.com",
                EmailConfirmed = "jsmith@testing.com",
                Password = "P@ssw0rd"
            };

            var user = new User
            {
                UserId = userrequest.UserId,
                UserName = userrequest.UserName,
                FirstName = userrequest.FirstName,
                MiddleInitial = userrequest.MiddleInitial,
                LastName = userrequest.LastName,
                Email = userrequest.Email,
                EmailConfirmed = userrequest.EmailConfirmed,
                Password = userrequest.Password

            };
           

            // Act
            cxt.User.Add(user);
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