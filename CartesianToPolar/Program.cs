using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianToPolar
{
    class Program
    {
        static void Main(string[] args)
        {
            CartesianToPolar();
        }

        /// <summary>
        /// Converting coordinates from cartesian to polar
        /// </summary>

        static void CartesianToPolar()
        {
            double x, y;
            double r, theta;

            Console.WriteLine("Please enter the Cartesian coordinates");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            theta = Math.Atan(y / x);

            Console.WriteLine("The polar coordinates for the cartesian coordinates (using radians) ({0},{1}) are {2},{3}", x, y, r, theta);
        }
    }
}
