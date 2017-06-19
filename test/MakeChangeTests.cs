using System;
using Xunit;
using src;

namespace test
{
    public class ChangeMakerTests
    {
        [Fact]
        public void Dot01ShouldReturn1Penny()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Assert.Equal(1,changeMaker.MakeChange(0.01m).PenniesCount);
        }

        [Fact]
        public void Dot02ShoudlReturn2Pennies()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Assert.Equal(2,changeMaker.MakeChange(0.02m).PenniesCount);
        }
    }
}
