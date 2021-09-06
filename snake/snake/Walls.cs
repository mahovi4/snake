using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> lines;
        public Walls(int sizeX, int sizeY) 
        {
            lines = new List<Figure>();
            lines.Add(new HorizontalLine(0, sizeX-2, 0, '+'));
            lines.Add(new HorizontalLine(0, sizeX - 2, sizeY-1, '+'));
            lines.Add(new VertikalLine(0, 0, sizeY - 1, '+'));
            lines.Add(new VertikalLine(sizeX - 2, 0, sizeY - 1, '+'));
        }

        public bool IsHit(Figure figure)
        {
            foreach(var line in lines)
            {
                if (line.IsHit(figure)) return true;
            }
            return false;
        }

        public void Draw()
        {
            for(int i = 0; i < lines.Count; i++)
            {
                lines[i].Draw();
            }
        }
    }
}
