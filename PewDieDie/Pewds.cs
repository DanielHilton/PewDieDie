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

        const int PEWDIE_SPEED = 3;
        
        public Pewds() : base(PewDieDie.textures[0],
            new Vector2i(PewDieDie.textures[0].Width,PewDieDie.textures[0].Height),
            new Vector2i(10,10))
        {
            this.Health = 100;
        }

        public void Move(Direction pDir)
        {
            base.Move(pDir, PEWDIE_SPEED);
        }
    }
}
