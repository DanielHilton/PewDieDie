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

    public class PewDieDie : Game
    {
        GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        public static List<Texture2D> textures = new List<Texture2D>();
        public static GameState gameState = GameState.MAIN_MENU;
        
        private SpriteFont hudFont;

        public Song bgm;
        public List<SoundEffect> soundEffects = new List<SoundEffect>();

        private Pewds pewdie;
        private Background background;
        private Sprite logo;
        private Button playBtn;

        public PewDieDie()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;

            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.IsMouseVisible = true;

            LoadTextures();
            LoadFonts();

            pewdie = new Pewds();
            background = new Background();
            playBtn = new Button(textures[Textures.PLAY_BTN], textures[Textures.PLAY_BTN_HOVER], new Vector2i(310, 425));
            playBtn.onClick += new EventHandler(StartGame);
            logo = new Sprite(new Vector2i(textures[Textures.LOGO].Width, textures[Textures.LOGO].Height), new Vector2i(185, 100));

            LoadSounds();

            MediaPlayer.Volume = 0.5f;
            MediaPlayer.Play(bgm);
        }

        private void LoadFonts()
        {
            hudFont = Content.Load<SpriteFont>("font");
        }
        private void LoadTextures()
        {
            textures.Add(Content.Load<Texture2D>("pewds"));
            textures.Add(Content.Load<Texture2D>("background"));
            textures.Add(Content.Load<Texture2D>("logo"));
            textures.Add(Content.Load<Texture2D>("star"));
            textures.Add(Content.Load<Texture2D>("playBtn"));
            textures.Add(Content.Load<Texture2D>("playBtnHover"));
        }
        private void LoadSounds()
        {
            bgm = Content.Load<Song>("bgm");
            soundEffects.Add(Content.Load<SoundEffect>("intro"));
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            for (int i = 0; i < textures.Count; i++)
                textures[i].Dispose();
            for (int i = 0; i < soundEffects.Count; i++)
                soundEffects[i].Dispose();
            bgm.Dispose();
        }

        protected override void Update(GameTime gameTime)
        {
            HandleKeyboardInput();
            base.Update(gameTime);
            background.Update(gameTime);

            switch (gameState)
            {
                case(GameState.MAIN_MENU):
                    playBtn.Update(gameTime);
                    break;
                case(GameState.GAME):
                    break;
                case(GameState.PAUSE):
                    break;
                case(GameState.GAME_OVER):
                    break;
            }
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

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            background.Draw(gameTime);
            switch (gameState)
            {
                case(GameState.MAIN_MENU):
                    DrawMainMenu(gameTime);
                    break;
                case(GameState.GAME):
                    pewdie.Draw(gameTime);
                    break;
                case(GameState.PAUSE):
                    break;
                case(GameState.GAME_OVER):
                    break;
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

        private void DrawMainMenu(GameTime gameTime)
        {
            logo.Draw(gameTime, textures[Textures.LOGO]);
            playBtn.Draw(gameTime);
            spriteBatch.DrawString(hudFont, "Controls: UP/DOWN/LEFT/RIGHT - Move \n                 SPACE = Fire", new Vector2(80, 650), Color.White);
        }

        public void StartGame(object sender, EventArgs e)
        {
            gameState = GameState.GAME;
            soundEffects[Sounds.INTRO].Play(0.8f, -0.5f, 0.0f);
        }
    }
}
