namespace BowlingScoringLibrary
{
    public class BowlingScoreBase
    {
        
        public int[] _pinsBall = new int[21];
        /// <summary>
        /// Get Count of GetSrickFrameCount
        /// </summary>
        /// <param name="iCount"></param>
        /// <returns>int</returns>
        public int GetSrickFrameCount(int iCount)
        {
            return _pinsBall[iCount] + _pinsBall[iCount + 1];
        }

        /// <summary>
        /// Get Spare Bonus
        /// </summary>
        /// <param name="iCount"></param>
        /// <returns>int</returns>
        public int GetSpareBonus(int iCount)
        {
            return _pinsBall[iCount + 2];
        }

        /// <summary>
        /// Get Strick Bonus
        /// </summary>
        /// <param name="iCount"></param>
        /// <returns>int</returns>
        public int GetStrickBonus(int iCount)
        {
            return 10 + _pinsBall[iCount + 1] + _pinsBall[iCount + 2];
        }

        /// <summary>
        /// Get Boolean for first and second value count
        /// </summary>
        /// <param name="iCount"></param>
        /// <returns>bool</returns>
        public bool isStrickCount2(int iCount)
        {
            return _pinsBall[iCount] + _pinsBall[iCount + 1] == 10;
        }

        /// <summary>
        /// Get Boolean for first count value if 10
        /// </summary>
        /// <param name="iCount"></param>
        /// <returns>bool</returns>
        public bool isStrickCount1(int iCount)
        {
            return _pinsBall[iCount] == 10;
        }
    }
}