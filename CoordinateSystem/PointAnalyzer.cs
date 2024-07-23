using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
   public class PointAnalyzer
    {
        public IEnumerable<Point> FindFurthestPoints(IEnumerable<Point> points)
        {
            var maxDistance = points.Max(p => p.DistanceFromOrigin);
            return points.Where(p => p.DistanceFromOrigin == maxDistance);
        }
    }
}
