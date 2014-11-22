using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace PewDieDie
{
    class Button : Sprite
    {
        private bool isHovered;
        public bool IsHovered
        {
            get { return isHovered; }
            set { value = isHovered; }
        }

        private Texture2D[] buttonTextures = new Texture2D[2];

        public EventHandler onClick;

        public Button(Texture2D normalTex, Texture2D hoverTex, Vector2i pPos)
            : base(new Vector2i(normalTex.Width, normalTex.Height),
            pPos)
        {
            isHovered = false;
            buttonTextures[0] = normalTex;
            buttonTextures[1] = hoverTex;
        }

        public void Update(GameTime gameTime)
        {
            MouseState mouseState = Mouse.GetState();

            if (mouseState.X >= this.rectangle.X && mouseState.X < this.rectangle.X + this.rectangle.Width &&
                    mouseState.Y >= this.rectangle.Y && mouseState.Y < this.rectangle.Y + this.rectangle.Height)
                isHovered = true;
            else
                isHovered = false;

            if (isHovered && Mouse.GetState().LeftButton == ButtonState.Pressed)
                onClick(this, null);
        }

        public void Draw(GameTime gameTime)
        {
            if (!isHovered)
                base.Draw(gameTime, buttonTextures[0]);
            else
                base.Draw(gameTime, buttonTextures[1]);
        }

    }
}
