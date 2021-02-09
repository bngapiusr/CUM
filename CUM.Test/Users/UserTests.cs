using Xunit;

namespace CUM.Test.Users
{
    public class UserTests
    {


        #region Get By Id

        [Fact]
        public async void Task_GetUserById_Return_OkResult()
        {
            // Arrange the data
            var controller = new UserController();
            var userId = 1;

            // Performing the data
            var data = await controller.GetPost(userId);

            // Matching the ouput (Arrange, Act, Assert)
            Assert.IsType<OkObjectResult>(data);
        }

        #endregion
    }
}