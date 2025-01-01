using System;

namespace HomePoint
{
    class Graphic3D:Point
    {
        private int z;
        public Graphic3D(int z,int x,int y) : base(x, y)
        {
            this.z = z;
        }

        public void Start3D()
        { 
            Console.WriteLine("Graphic 3D: " + x + "," + y + "," + z); 
        }
    }
}
