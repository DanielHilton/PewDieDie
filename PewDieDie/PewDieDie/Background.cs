using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PewDieDie
{
    class Background : Sprite
    {
                public Background() : base(
            new Vector2i(PewDieDie.textures[Textures.BACKGROUND].Width,PewDieDie.textures[Textures.BACKGROUND].Height),
            new Vector2i(0,0))
        {
        }

        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, PewDieDie.textures[Textures.BACKGROUND]);
        }
    }
}
