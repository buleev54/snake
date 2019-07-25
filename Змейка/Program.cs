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

            HorizontalLine line = new HorizontalLine(); //создаем новую линию
            line.Drow();//выводим ее на экран



            Console.ReadKey();
        }       
    }
}
