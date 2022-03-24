using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trignometry
{
  public  class TrignometricOperations
    {
        public double AreaOfSqaure(double length)
        {
            return length * length;
        }
        public double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }
        public double PerimeterOfSquare(double length)
        {
            return 4 * length; 
        }
        public static void Main()
        {
        }
    }
}
