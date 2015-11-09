using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDistanceMeasure
{
    public static class Extensions
    {
        public static double DegreesToRadians(this double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static bool EqualsAprroximately(this double firstValue, double secondValue, double tolerance)
        {
            return Math.Abs(firstValue - secondValue) <= tolerance;
        }
    }
}
