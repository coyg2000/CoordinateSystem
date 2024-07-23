using System;
using System.Collections.Generic;
using System.IO;

namespace CoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputFilePath = @"C:\Users\shpat\Desktop\points.txt";
            
            // string inputFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "points.txt");

            string inputFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"InputFiles\points.txt");
           

            
            if (File.Exists(inputFilePath))
            {
               
                string fileContents = File.ReadAllText(inputFilePath);

              
                Console.WriteLine(fileContents);
            }
            else
            {
                Console.WriteLine("The file 'CoordinateSystem.points.txt' does not exist in the 'InputFiles' folder.");
            }

            var fileReader = new FileReader();
            var pointParser = new PointParser();
            var pointAnalyzer = new PointAnalyzer();

            List<Point> points = new List<Point>();

            // Read and parse the input file
            try
            {
                foreach (var line in fileReader.ReadLines(inputFilePath))
                {
                    try
                    {
                        var point = pointParser.Parse(line);
                        points.Add(point);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Invalid line skipped: {line} - {ex.Message}");
                    }
                }

                // Analyze points
                var furthestPoints = pointAnalyzer.FindFurthestPoints(points);

                // Output the results
                foreach (var point in furthestPoints)
                {
                    Console.WriteLine($"Point {point.Name} at ({point.X}, {point.Y}) is furthest from the origin at distance {point.DistanceFromOrigin:F2} in quadrant {point.Quadrant}.");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
