using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Змейка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //отрисовка рамочки

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');

            upLine.Drew();
            downLine.Drew();
            leftLine.Drew();
            rightLine.Drew();

            //отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drew();  //вывод змейки на экран

            while (true)
            {
                if (Console.KeyAvailable) //проверка, была ли нажата клавиша с прошлого раза, с прошлого витка цикла
                {
                    ConsoleKeyInfo key = Console.ReadKey();//получаем значение этой клавиши
                    if (key.Key == ConsoleKey.LeftArrow)//если клавиша нажата влево
                        snake.direction = Direction.LEFT;//то змейка движется влево
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                }
            }

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();



            Console.ReadKey();
        }       
    }
}
