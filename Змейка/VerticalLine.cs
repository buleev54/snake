﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class VerticalLine : Figura
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)  // коснтруктор, который будет вызываться присоздании линий
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
