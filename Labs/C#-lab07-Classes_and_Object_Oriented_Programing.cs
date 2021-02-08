#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int _x = 0;
        private int _y = 0;
        private static int objectCount = 0;
        private static int serialNum;
        public static int ObjectCount()
        {
            return objectCount;
        }       
        public Point()              
        {
            _x = -1;
            _y = -1;
            objectCount++;
            Console.WriteLine("Default constructor called");
        }
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
            objectCount++;
            Console.WriteLine($"{x}:, {y}:");
        }
        public double DistanceTo(Point other)
        {
            int xDiff = _x - other._x;
            int yDiff = _y - other._y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
    }
}
