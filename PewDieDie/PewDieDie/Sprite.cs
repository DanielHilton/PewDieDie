using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PewDieDie
{
    class Sprite
    {   
        private Rectangle rectangle;
        public Rectangle Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }

        private float rotation;
        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        private Vector2 origin;
        public Vector2 Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public Sprite() //default
        {
            this.rectangle = new Rectangle();
            this.rotation = 0.0f;
        }
        public Sprite(Vector2i pSize, Vector2i pPos) //Initialised, no rotation
        {
            this.rectangle = new Rectangle(pPos.X, pPos.Y, pSize.X, pSize.Y);
            this.rectangle.X = pPos.X;
            this.rectangle.Y = pPos.Y;
            this.rotation = 0.0f;
            this.origin = new Vector2(this.rectangle.X + this.rectangle.Width / 2, this.rectangle.Y + this.rectangle.Height / 2);
        }
        public Sprite(Vector2i pSize, Vector2i pPos, float pRot) //Initialised + rotation
        {
            this.rectangle = new Rectangle(pPos.X, pPos.Y, pSize.X, pSize.Y);
            this.rotation = pRot;
            this.origin = new Vector2(this.rectangle.X + this.rectangle.Width / 2, this.rectangle.Y + this.rectangle.Height / 2);
        }

        protected void Move(Direction pDir, int pSpeed)
        {
            switch (pDir)
            {
                case(Direction.Up):
                    this.rectangle.Y -= pSpeed;
                    break;
                case(Direction.Down):
                    this.rectangle.Y += pSpeed;
                    break;
                case(Direction.Right):
                    this.rectangle.X += pSpeed;
                    break;
                case(Direction.Left):
                    this.rectangle.X -= pSpeed;
                    break;
            }
        }

        public void Draw(GameTime gameTime, Texture2D pTex)
        {
            //PewDieDie.spriteBatch.Draw(PewDieDie.textures[0], this.position, Color.White);
            //PewDieDie.spriteBatch.Draw(pTex, this.rectangle, null, Color.White, this.rotation, this.origin, SpriteEffects.None, 0.0f);
            PewDieDie.spriteBatch.Draw(pTex,this.rectangle, Color.White); 
        }
    }
}
