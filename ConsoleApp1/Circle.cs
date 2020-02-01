using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Circle : IFigure
    {
        int radius;
        public Circle()
        {
            radius = 0;
        }
        public Circle(int r)
        {
            radius = r;
        }
        public int GetSquare()
        {
            return (int)(2 * 3.14 * radius);
        }
        public int GetPerimetr()
        {
            return 2 * (int)(3.14) * radius;
        }
    }
}
