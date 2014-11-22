using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PewDieDie
{
    class Background : Sprite
    {
        List<Star> stars = new List<Star>();
        public const int STAR_QUANTITY = 30;

                public Background() : base(
            new Vector2i(PewDieDie.textures[Textures.BACKGROUND].Width,PewDieDie.textures[Textures.BACKGROUND].Height),
            new Vector2i(0,0))
        {
            for (int i = 0; i < STAR_QUANTITY; i++)
            {
                stars.Add(new Star());
            }
        }

        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, PewDieDie.textures[Textures.BACKGROUND]);
            for (int i = 0; i < STAR_QUANTITY; i++)
            {
                stars[i].Draw(gameTime);
            }
        }

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < STAR_QUANTITY; i++)
            {
                stars[i].Update(gameTime);
            }
        }
    }
}
