using System;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void simple_passing_test()
        {
            Assert.Equal(1, 1);
        }
    }
}
