using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PewDieDie
{
    class Pewds : Sprite
    {
        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public Pewds() : base(pewdsTex, new Vector2i(10,10), new Vector2i(100,100))
        {
            this.Health = 100;
        }

    }
}
