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
        [Fact]
        public void PolarBearHunts()
        {
            Assert.True(Program.DoesPolarHunt());
        }
        
        //Test PolarBear.ClawLength is same as Bear.ClawLength
        [Fact]
        public void PolarClawLengthIs3()
        {
            Assert.Equal(3, Program.PolarClawLength());
        }

        //Test Lemur.Eats()
        [Fact]
        public void LemurEatsLemurFood()
        {
            Assert.Equal("Lemur food", Program.LemurEats());
        }

        //Test Lemur.Sound()
        [Fact]
        public void LemurMakesLemurSound()
        {
            Assert.Equal("Lemur sound!", Program.LemurSound());
        }

        //Test Chimpanzee.HasTail == true
        [Fact]
        public void ChimpHasNoTail()
        {
            Assert.False(Program.DoesChimpHaveTail());
        }

        //Test Chimpanzee.Sound()
        [Fact]
        public void ChimpSoundIsCorrect()
        {
            Assert.Equal("Hoo hoo, ha ha", Program.ChimpSound());
        }

        //Test Proboscis.HasTail
        [Fact]
        public void ProbHasTail()
        {
            Assert.True(Program.DoesProbHaveTail());
        }

        //Test Proboscis.Eats()
        [Fact]
        public void ProbEatsProbFood()
        {
            Assert.Equal("Unripe fruit!", Program.ProbEats());
        }
    }
}
