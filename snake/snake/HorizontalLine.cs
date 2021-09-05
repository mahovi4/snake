using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int x1, int x2, int y, char c)
        {
            points = new List<Point>();
            for (int x = x1; x <= x2; x++)
            {
                points.Add(new Point(x, y, c));

            }
        }
    }
}
