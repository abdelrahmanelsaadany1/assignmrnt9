using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers.Project1
{
    internal class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

       
        public Point3D() : this(0, 0, 0) { }

        
        public Point3D(double x, double y) : this(x, y, 0) { }

       
        public Point3D(double x, double y, double z)
        {
           this.X = x;
            this.Y = y;
            this.Z = z;
        }

        
        public override string ToString()
        {
              return $"Point Coordinates: ({X}, {Y}, {Z})"; ;
        }
        public static Point3D ReadPoint(string pointName)
        {
            int x = ReadCoordinate("X");
            int y = ReadCoordinate("Y");
            int z = ReadCoordinate("Z");

            return new Point3D(x, y, z);
        }

        // Simple method to read a coordinate with validation
        private static int ReadCoordinate(string coordinateName)
        {
            int value;
            Console.Write($"Enter {coordinateName}: ");

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write($"Enter {coordinateName}: ");
            }

            return value;
        }
        public static bool operator ==(Point3D p1, Point3D p2)
        {
           
            if (ReferenceEquals(p1, p2)) return true;

            
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;

            
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);  
        }
    }

}

