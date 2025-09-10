using CSharpGithubActions;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(5 % 2 == 1);
        }

        [Theory]
        [InlineData(1, 3, 4)] 
        [InlineData(2, 3, 5)]
        public void Test2(int x, int y, int result)
        {
            Assert.True(Calculator.AddTwoNumbers(x, y) == result);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(5, 0, 0)]
        [InlineData(1, 1, 1)]
        public void Test3(int x, int y, int result)
        {
            Assert.True(x * y == result);
        }
    }
}