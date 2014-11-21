using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PewDieDie
{
    class Sprite : ISprite
    {
        private Texture2D spriteTex;
        public Texture2D SpriteTex
        {
            get { return spriteTex; }
            set { spriteTex = value; }
        }
        
        private Rectangle spriteRect;
        public Rectangle SpriteRect
        {
            get { return spriteRect; }
            set { spriteRect = value; }
        }

        private Vector2i position;
        public Vector2i Position
        {
            get { return position; }
            set { position = value; }
        }

        private float rotation;
        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public Sprite() //default
        {
            this.spriteTex = null;
            this.spriteRect = new Rectangle();
            this.position = new Vector2i();
            this.rotation = 0.0f;
        }
        public Sprite(Texture2D pTex, Vector2i pSize, Vector2i pPos) //Initialised, no rotation
        {
            this.spriteTex = pTex;
            this.position = pPos;
            this.spriteRect = new Rectangle(this.Position.X, this.Position.Y, pSize.X, pSize.Y);
            this.rotation = 0.0f;
        }
        public Sprite(Texture2D pTex, Vector2i pSize, Vector2i pPos, float pRot) //Initialised + rotation
        {
            this.spriteTex = pTex;
            this.position = pPos;
            this.spriteRect = new Rectangle(this.Position.X, this.Position.Y, pSize.X, pSize.Y);
            this.rotation = pRot;
        }

        public void Update(GameTime gameTime)
        {
            //Update position of rectangle from position vector
            this.spriteRect.X = this.position.X;
            this.spriteRect.Y = this.position.Y;
        }

        public void Initialise()
        {
            // Init here if necessary
        }

        public void Draw(GameTime gameTime)
        {
            Game1.spriteBatch.Draw(this.spriteTex, this.spriteRect, null, Color.White, this.rotation,
                new Vector2(this.position.X + this.spriteRect.Width / 2,
                    this.position.Y + this.spriteRect.Height / 2),SpriteEffects.None, 0.0f);
        }

        public void Destroy()
        {
            this.spriteTex.Dispose();
        }
    }
}
