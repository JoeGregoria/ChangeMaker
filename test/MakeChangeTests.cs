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
        public void Dot02ShouldReturn2Pennies()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Assert.Equal(2,changeMaker.MakeChange(0.02m).PenniesCount);
        }

        [Fact]
        public void Dot05ShouldReturn1Nickle()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Change change = changeMaker.MakeChange(0.05m);
            Assert.Equal(1,change.NickelsCount);
            Assert.Equal(0,change.PenniesCount);
        }

        [Fact]
        public void Dot10ShouldReturn1Dime()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Change change = changeMaker.MakeChange(0.1m);
            Assert.Equal(1,change.DimesCount);
            Assert.Equal(0,change.NickelsCount);
            Assert.Equal(0,change.PenniesCount);
        }

        [Fact]
        public void Dot16ShouldReturn1Dime1Nickel1Penny()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Change change = changeMaker.MakeChange(0.16m);
            Assert.Equal(1,change.DimesCount);
            Assert.Equal(1,change.NickelsCount);
            Assert.Equal(1,change.PenniesCount);
        }

        [Fact]
        public void Dot25ShouldReturn1Quarter()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Change change = changeMaker.MakeChange(0.25m);
            Assert.Equal(1,change.QuartersCount);
            Assert.Equal(0,change.DimesCount);
            Assert.Equal(0,change.NickelsCount);
            Assert.Equal(0,change.PenniesCount);
        }

        [Fact]
        public void Dot99ShouldReturn3Quarter2Dimes0Nickels4Pennies()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Change change = changeMaker.MakeChange(0.99m);
            Assert.Equal(3,change.QuartersCount);
            Assert.Equal(2,change.DimesCount);
            Assert.Equal(0,change.NickelsCount);
            Assert.Equal(4,change.PenniesCount);
        }     

        [Fact]
        public void OneDollarShouldThrow()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Assert.Throws<Exception>(() => {
                Change change = changeMaker.MakeChange(1.00m);
            });
        }    

        [Fact]
        public void NegativeShouldThrow()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Assert.Throws<Exception>(() => {
                Change change = changeMaker.MakeChange(-1.00m);
            });
        }          

        [Fact]
        public void ZeroShouldReturnAllZeros()
        {
            ChangeMaker changeMaker = new ChangeMaker();
            Change change = changeMaker.MakeChange(0m);
            Assert.Equal(0,change.QuartersCount);
            Assert.Equal(0,change.DimesCount);
            Assert.Equal(0,change.NickelsCount);
            Assert.Equal(0,change.PenniesCount);
        }                    
    }
}
