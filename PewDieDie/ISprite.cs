using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PewDieDie
{
    interface ISprite
    {
        public void Initialise(); //Initialise Sprite
        public void Update(GameTime gameTime); //Update position, health, whatever
        public void Draw(GameTime gameTime); //Actually draw it
        public void Destroy(); //KILL
    }
}
