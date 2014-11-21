using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PewDieDie
{
    class Vector2i
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Vector2i()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Vector2i(int pX, int pY)
        {
            this.X = pX;
            this.Y = pY;
        }

        public void Add(Vector2i pVec)
        {
            this.X += pVec.X;
            this.Y += pVec.Y;
        }
        public void Subtract(Vector2i pVec)
        {
            this.X -= pVec.X;
            this.Y -= pVec.Y;
        }
    }
}
