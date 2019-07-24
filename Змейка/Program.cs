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
            /*int x1 = 1; //координата точки по оси Х
            int y1 = 3; //координата точки по оси Y
            char sym1 ='*'; // точка будет отображаться  в таком виде
            //Console.SetCursorPosition(x1, y1);// определяет положение курсора с заданными координатами
            //Console.Write(sym1);// выводит на экран точку в указанном виде
            Draw(x1, y1, sym1);*/

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym);

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 6;
            p2.sym = '#';
            Draw(p2.x, p2.y, p2.sym);

            Point p3 = new Point();
            p3.x = 11;
            p3.y = 31;
            p3.sym = '&';
            Draw(p3.x, p3.y, p3.sym);
            



            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
