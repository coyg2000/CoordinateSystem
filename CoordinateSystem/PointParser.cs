using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace CoordinateSystem
{
   public class PointParser
    {
        public Point Parse(string line)
        {
            var match = Regex.Match(line, @"^Point(\d+)\(([-\d]+),\s*([-\d]+)\)$");
            if (!match.Success)
            {
                throw new FormatException("Invalid point format.");
            }

            string name = match.Groups[1].Value;
            int x = int.Parse(match.Groups[2].Value);
            int y = int.Parse(match.Groups[3].Value);

            return new Point(name, x, y);
        }
    }
}
