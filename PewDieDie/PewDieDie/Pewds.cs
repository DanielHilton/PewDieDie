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

        const int PEWDIE_SPEED = 5;
        
        public Pewds() : base(
            new Vector2i(PewDieDie.textures[Textures.PEWDIE].Width,PewDieDie.textures[Textures.PEWDIE].Height),
            new Vector2i(512,384))
        {
            this.Health = 100;
        }

        public void Move(Direction pDir)
        {
            base.Move(pDir, PEWDIE_SPEED);
        }

        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, PewDieDie.textures[Textures.PEWDIE]);
        }
    }
}
