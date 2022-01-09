using BowlingScoringLibrary;
using NUnit.Framework;

namespace BowlingScoringTest
{
    public class Tests
    {
        BowlingScore _bowlingScore;

        [SetUp]
        public void Setup()
        {
            _bowlingScore = new BowlingScore();
        } 

        void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                _bowlingScore.RollGame(pins);
            }
        }

        [Test]
        public void RollGameTest()
        {
            RollMany(20, 0);
            Assert.That(_bowlingScore.Score(), Is.EqualTo(0));
        }

        [Test]
        public void RollOnesTest()
        { 
            RollMany(20, 1);
            Assert.That(_bowlingScore.Score(), Is.EqualTo(20));

        }

        [Test]
        public void RollSpareFirstTest()
        {
            _bowlingScore.RollGame(9);
            _bowlingScore.RollGame(1);
            RollMany(18, 1);
            Assert.That(_bowlingScore.Score(), Is.EqualTo(29));
        }

        [Test]
        public void RollSpareEveryFrameTest()
        { 
            RollMany(21, 5);
            Assert.That(_bowlingScore.Score(), Is.EqualTo(150));
        }

        [Test]
        public void RollTest()
        {
            RollMany(4, 5);
            Assert.That(_bowlingScore.Score(), Is.EqualTo(25));
        }

        [Test]
        public void RollSparePerfectFrameTest()
        {
            RollMany(12, 10);
            Assert.That(_bowlingScore.Score(), Is.EqualTo(300));
        }

        [Test]
        public void RollSpareNineOneFrameTest()
        {
            for (int i = 0; i < 10; i++)
            {
                _bowlingScore.RollGame(9);
                _bowlingScore.RollGame(1);
            }
            _bowlingScore.RollGame(9);
            Assert.That(_bowlingScore.Score(), Is.EqualTo(190));
        }

        [Test]
        public void RollActualFrameTest()
        {  
            _bowlingScore.RollGame(10);
            _bowlingScore.RollGame(9); _bowlingScore.RollGame(1);
            _bowlingScore.RollGame(5); _bowlingScore.RollGame(5);
            _bowlingScore.RollGame(7); _bowlingScore.RollGame(2);
            _bowlingScore.RollGame(10);  
            _bowlingScore.RollGame(10);  
            _bowlingScore.RollGame(10);  
            _bowlingScore.RollGame(9); _bowlingScore.RollGame(0);
            _bowlingScore.RollGame(8); _bowlingScore.RollGame(2);
            _bowlingScore.RollGame(9); _bowlingScore.RollGame(1);
            _bowlingScore.RollGame(10);
 
            Assert.That(_bowlingScore.Score(), Is.EqualTo(187));
        }
    }
}