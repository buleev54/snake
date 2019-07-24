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
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();

            Point p2 = new Point(4,5,'#');//создаем новую точку с некоторыми корами и символом      
            p2.Draw();//выводим точку на экран

            Point p3 = new Point(10,15,'&');           
            p3.Draw();
            



            Console.ReadKey();
        }       
    }
}
