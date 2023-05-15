using UnitTest_Case;
namespace UnitTest_Case
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var num1 = 2;
            var num2 = 3;
            var expectedValue = 5;

            var sum = MathOperation.Add(num1, num2);
            Assert.Equal(expectedValue, sum, 1);
        }
    }
}