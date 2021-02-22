using System;

namespace BonusStatsSimulator.Utils
{
    public static class MathExtensions
    {
        public static bool Inside(this int t, int min, int max)
        {
            return t > min && t <= max;
        }
    }
}
