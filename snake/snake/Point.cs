using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right) x += offset;
            else if (direction == Direction.Left) x -= offset;
            else if (direction == Direction.Up) y -= offset;
            else y += offset;
        }

        internal void Clear()
        {
            symbol = ' ';
            Draw();
        }
    }
}
