using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygonsExamples
{
    public class Octagon : Object,  IRegularPolygon
    {

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int lenth)
        {
            NumberOfSides = 8;
            SideLength = lenth;
        }
        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
    }
}
