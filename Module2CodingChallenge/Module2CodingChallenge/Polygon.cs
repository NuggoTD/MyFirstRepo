using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
     class Polygon
    {
        // Attributes
        public int NumberOfSides { get; set; }

        // Constructors
        public Polygon()
        {
            NumberOfSides = 0;
        }// end constructor

        public Polygon(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
    }// end class
}// end namespace
