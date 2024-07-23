using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
   public  class Point
    {

        public string Name { get; }
        public int X { get; }
        public int Y { get; }
        public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);

        public string Quadrant
        {
            get
            {
                if (X > 0 && Y > 0) return "I";
                if (X < 0 && Y > 0) return "II";
                if (X < 0 && Y < 0) return "III";
                if (X > 0 && Y < 0) return "IV";
                return "Origin";
            }
        }

        public Point(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
