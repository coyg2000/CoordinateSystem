using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoordinateSystem
{
    public class FileReader
    {
        public IEnumerable<string> ReadLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllLines(filePath);
            }
            else
            {
                throw new FileNotFoundException("Input file not found.", filePath);
            }
        }
    }
}
