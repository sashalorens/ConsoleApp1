using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.part2
{
    public class Shape
    {
        protected Location c { get; set; } = new Location();

        public override string ToString() => "";

        public double Area() => 0.0;

        public double Perimeter() => 0.0;
    }
}
