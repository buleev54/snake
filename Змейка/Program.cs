﻿using System;
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
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 6;
            p2.sym = '#';
            p2.Draw();

            Point p3 = new Point();
            p3.x = 11;
            p3.y = 31;
            p3.sym = '&';
            p3.Draw();
            



            Console.ReadKey();
        }       
    }
}
