using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VertikalLine : Figure
    { 
        public VertikalLine(int x, int y1, int y2, char c)
        {
            points = new List<Point>();
            for (int y = y1; y <= y2; y++)
            {
                points.Add(new Point(x, y, c));
            }
        }

    }
}
