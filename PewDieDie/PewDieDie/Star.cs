using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PewDieDie
{
    class Star : Sprite
    {
        private int STAR_SPEED;
        private static Random rand = new Random();
        private const int Y_AXIS_LIMIT = 768;
        private const int START_X = 1050;

        public Star()
            : base(new Vector2i(PewDieDie.textures[Textures.STAR].Width, PewDieDie.textures[Textures.STAR].Height),
            new Vector2i(rand.Next(START_X, START_X + 15), rand.Next(Y_AXIS_LIMIT)))
        {
            STAR_SPEED = rand.Next(4, 10);
        }

        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, PewDieDie.textures[Textures.STAR]);
        }

        public void Update(GameTime gameTime)
        {
            //Restart star
            if (this.Rectangle.X < 0)
                this.setPosition(new Vector2i(rand.Next(START_X,START_X + 15), rand.Next(Y_AXIS_LIMIT)));
            Move();
        }

        private void Move()
        {
            base.Move(Direction.Left, STAR_SPEED);
        }
    }
}
