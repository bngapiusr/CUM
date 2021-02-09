using Xunit;

namespace CUM.Test.Users
{
    public class UserTests
    {


        #region Get By Id

        [Fact]
        public void AddUser_Return_UserId()
        {
            // Arrange
            var user = new User();

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