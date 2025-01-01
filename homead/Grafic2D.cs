using System;

namespace HomePoint
{
    class Graphic2D : Point
    {
        public Graphic2D(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        }

        public void Start2D()
        {
            Console.WriteLine("Graphic2D: " + x + "," + y);
        }
    }
}