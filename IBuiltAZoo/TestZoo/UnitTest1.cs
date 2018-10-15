using System;
using Xunit;

using IBuiltAZoo;

namespace TestZoo
{
    public class UnitTest1
    {
        //Test Panda.Name 
        [Fact]
        public void PandaNameIsPanda()
        {
            Assert.Equal("Panda", Program.GetPandaName());
        }

        //Test Panda.Hunts == false
        [Fact]
        public void PandaDoesNotHunt()
        {
            Assert.False(Program.DoesPandaHunt());
        }

        //Test Grizzly.Hunts == true
        [Fact]
        public void GrizzlyDoesHunt()
        {
            Assert.True(Program.DoesGrizzlyHunt());
        }

        //Test Grizzly.Eat()
        [Fact]
        public void GrizzlyEatsSalmonAndBerries()
        {
            Assert.Equal("I eat salmon and berries!", Program.GrizzlyEats());
        }
        //Test PolarBear.Hunts == true
        //Test PolarBear.ClawLength is same as Bear.ClawLength
        //Test Lemur.Eats()
        //Test Lemur.Sound()
        //Test Chimpanzee.HasTail == true
        //Test Chimpanzee.Sound()
        //Test Proboscis.HasTail != Chimpanzee.HasTail
        //Test Proboscis.Eats()
    }
}
