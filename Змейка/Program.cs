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
            Point p1 = new Point(1,3,'*');       
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            Point p3 = new Point(10,15,'&');           
            p3.Draw();

            HorizontalLine line = new HorizontalLine(5,20,8,'+'); //создаем новую линию, слева 5, справа 20, в восьмой строке, символ +
            line.Drow();//выводим ее на экран

            VerticalLine line1 = new VerticalLine(7, 22, 5, '$');
            line1.Drew();



            Console.ReadKey();
        }       
    }
}
