using CuteNamespace;
using Xunit;
using Xunit.Abstractions;

namespace CuteTest
{
    public class UnitTest1
    {

        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }


        //fact example for class
        [Fact]
        public void TestFact()
        {
            Assert.Equal(1, 1);
        }

        //theory with inline data example
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]
        [InlineData(6, 6)]
        [InlineData(7, 7)]
        [InlineData(8, 8)]
        [InlineData(9, 9)]
        [InlineData(10, 10)]
        public void TestInlineDataTheory(int number1, int number2)
        {
           //_output.WriteLine("Running test for: " + number1 + " " + number2);
            Assert.Equal(number1, number2);
        }


        [Theory]
        [ClassData(typeof(CuteGirlsData))]
        public void TestCute(Girl cuteGirl)
        {
            Cute cute = new Cute(cuteGirl);
            _output.WriteLine("Running cute test for girl: " + cuteGirl);
            Assert.True(cute.IsCute(), "Girl is not cute, Reason: " + cute.Reason + "\n" + cuteGirl);
            //Assert.True(cute.IsCute(), "Girl is not cute, Reason: " + cute.Reason);
        }

        [Theory]
        [ClassData(typeof(NotCuteGirlsData))]
        public void TestNotCute(Girl notCuteGirl)
        {
            Cute cute = new Cute(notCuteGirl);
            _output.WriteLine("Running not cute test for girl: " + notCuteGirl);
            Assert.False(cute.IsCute(), "Girl is actually cute:\n"+notCuteGirl);
        }
    }
}
