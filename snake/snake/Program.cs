using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<char> symbols = new List<char>();
            symbols.Add('*');
            symbols.Add('#');
            symbols.Add('@');
            symbols.Add('$');
            symbols.Add('&');

            List<Point> points = new List<Point>();
            foreach(char c in symbols)
            {
                Point p = new Point(random.Next(0, 10), random.Next(0, 10), c);
                points.Add(p);
                p.Draw();
            }

            Console.ReadLine();
        }
    }
}
