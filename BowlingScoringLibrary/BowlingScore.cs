using System;

namespace BowlingScoringLibrary
{
    public class BowlingScore 
    {
        BowlingScoreBase _bowlingScoreBase = new BowlingScoreBase();
        public int _rollIndex = 0;
        /// <summary>
        /// Add Roll Count using the pins
        /// </summary>
        /// <param name="pins"></param>
        public void RollGame(int pins)
        {
            _bowlingScoreBase._pinsBall[_rollIndex] += pins;
            _rollIndex++;
        }

        /// <summary>
        /// Get Score of all required Frames
        /// </summary>
        /// <returns>int</returns>
        public int Score()
        {
            int score=0;
            int iFrameIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                if (_bowlingScoreBase.isStrickCount1(iFrameIndex))
                {
                    score += _bowlingScoreBase.GetStrickBonus(iFrameIndex);
                }
                else if (_bowlingScoreBase.isStrickCount2(iFrameIndex))
                {
                    score += 10 + _bowlingScoreBase.GetSpareBonus(iFrameIndex);
                    iFrameIndex += 1;
                }
                else
                {
                    score += _bowlingScoreBase.GetSrickFrameCount(iFrameIndex);
                    iFrameIndex += 1;
                }
                iFrameIndex += 1;
            }
            return score;
        }

        
    }
}
