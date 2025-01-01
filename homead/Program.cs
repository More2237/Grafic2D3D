using System;

namespace HomePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphic2D g2 = new Graphic2D(100, 200);
            Graphic3D  g3 = new Graphic3D(100, 200,300);
            g2.Start2D();
            g3.Start3D();
            
        }
    }
}