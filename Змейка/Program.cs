using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //отрисовка рамочки

            VerticalLine leftLine = new VerticalLine(0,24,0,'+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine= new HorizontalLine(0, 78, 24, '+');

            topLine.Drew();
            bottomLine.Drew();
            leftLine.Drew();
            rightLine.Drew();

            //отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drew();  //вывод змейки на экран



            Console.ReadKey();
        }       
    }
}
