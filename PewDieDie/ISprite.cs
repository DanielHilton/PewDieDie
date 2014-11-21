using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PewDieDie
{
    interface ISprite
    {
        void Initialise(); //Initialise Sprite
        void Update(GameTime gameTime); //Update position, health, whatever
        void Draw(GameTime gameTime); //Actually draw it
        void Destroy(); //KILL
    }
}
