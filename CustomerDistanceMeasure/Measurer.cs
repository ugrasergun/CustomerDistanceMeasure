using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDistanceMeasure
{
    public class Measurer
    {
        public const double earthRadius = 6371; //Mean radius according to wikipedia.
        public static double MeasureDistanceInRadians(double pointALatitude, double pointALongitude, double PointBLatitude, double PointBLongitude)
        {
            return Math.Acos(Math.Sin(pointALatitude) * Math.Sin(PointBLatitude) + Math.Cos(pointALatitude) * Math.Cos(PointBLatitude) * Math.Cos(Math.Abs(pointALongitude - PointBLongitude))) * earthRadius;
        }
        public static double MeasueDistanceInDegrees(double pointALatitude, double pointALongitude, double PointBLatitude, double PointBLongitude)
        {
            return MeasureDistanceInRadians(pointALatitude.DegreesToRadians(), pointALongitude.DegreesToRadians(), PointBLatitude.DegreesToRadians(), PointBLongitude.DegreesToRadians());
        }
    }
}
