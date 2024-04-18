using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    class Triangle : Polygon
    {
        // attributes
        public float Size { get; set; }

        // constructor
        public Triangle(float size)
        {
            Size = size;
            NumberOfSides = 3;
        }// end constructor
    }// end class
}// end namespace
