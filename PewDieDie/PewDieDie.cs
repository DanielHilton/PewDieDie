#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
#endregion

namespace PewDieDie
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    /// 

    public enum Direction
    {
        Up, Down, Left, Right
    };

    public class PewDieDie : Game
    {
        GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        public static List<Texture2D> textures = new List<Texture2D>();

        public SoundEffect bgm;

        private Pewds pewdie;

        public PewDieDie()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            textures.Add(Content.Load<Texture2D>("pewds"));
            pewdie = new Pewds();

            base.Initialize();

            PlayBGM();
        }

        private void PlayBGM()
        {
            bgm = Content.Load<SoundEffect>("bgm");
            bgm.Play();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
                HandleKeyboardInput();
                base.Update(gameTime);
        }

        private void HandleKeyboardInput()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            for (int i = 0; i < pressedKeys.Length; i++)
            {
                switch (pressedKeys[i])
                {
                    case (Keys.Left):
                        pewdie.Move(Direction.Left);
                        break;
                    case (Keys.Right):
                        pewdie.Move(Direction.Right);
                        break;
                    case (Keys.Up):
                        pewdie.Move(Direction.Up);
                        break;
                    case (Keys.Down):
                        pewdie.Move(Direction.Down);
                        break;
                }
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            pewdie.Draw(gameTime);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
