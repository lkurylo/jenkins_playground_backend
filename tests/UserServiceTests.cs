using api.Services;
using Xunit;

namespace tests
{
    public class UserServiceTests
    {
        [Fact]
        public void UserService_GetUserId_CorrectResult(){
            UserService service = new UserService();

            var actual = service.GetUserId();
            var expected = 1;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void UserService_GetUserId_FailingResult()
        {
            UserService service = new UserService();

            var actual = service.GetUserId();
            var expected = 2;

            Assert.Equal(actual, expected);
        }
    }
}