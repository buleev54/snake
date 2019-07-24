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
            int x1 = 1; //координата точки по оси Х
            int y1 = 3; //координата точки по оси Y
            char sym1 ='*'; // точка будет отображаться  в таком виде
            Console.SetCursorPosition(x1, y1);// определяет положение курсора с заданными координатами
            Console.Write(sym1);// выводит на экран точку в указанном виде

            int x2 = 5; 
            int y2 = 6; 
            char sym2 = '#'; 
            Console.SetCursorPosition(x2, y2);
            Console.Write(sym2);

            int x3 = 11; 
            int y3 = 31; 
            char sym3 = '&'; 
            Console.SetCursorPosition(x3, y3);
            Console.Write(sym3);



            Console.ReadKey();
        }
    }
}
