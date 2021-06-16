using api.Services;
using Xunit;

namespace tests
{
    public class UserServiceTests
    {
        [Fact]
        public void get_user_id_returns_correct_value(){
            UserService service = new UserService();

            var actual = service.GetUserId();
            var expected = 1;

            Assert.Equal(actual, expected);
        }
    }
}