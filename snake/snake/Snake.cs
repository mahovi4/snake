using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction directyon;
        public Snake(Point tail, int length, Direction direction)
        {
            this.directyon = direction;
            points = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                points.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, directyon);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                points.Add(food);
                return true;
            }
            else return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) directyon = Direction.Left;
            else if (key == ConsoleKey.RightArrow) directyon = Direction.Right;
            else if (key == ConsoleKey.UpArrow) directyon = Direction.Up;
            else if (key == ConsoleKey.DownArrow) directyon = Direction.Down;
        }
    }
}
