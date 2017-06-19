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
            Assert.Equal(1,changeMaker.MakeChange(0.01).PenniesCount);
        }
    }
}
