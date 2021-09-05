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
            HorizontalLine hline = new HorizontalLine(3, 7, 5, '*');
            hline.Draw();

            VertikalLine vline = new VertikalLine(1, 1, 5, '#');
            vline.Draw();

            Console.ReadLine();
        }
    }
}
