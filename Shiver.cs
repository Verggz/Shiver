using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ShiverMonoGame.src.engine;
using ShiverMonoGame.src.engine.world;
using ShiverMonoGame.src.engine.Input;

namespace ShiverMonoGame
{
    public class Shiver : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private MainWorld world;
        

        public Shiver()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Window.Title = "Shiver";
            Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //_graphics.PreferredBackBufferWidth= GraphicsDevice.DisplayMode.Width;
            //_graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            //_graphics.IsFullScreen = true;
            Globals.screenWidth = 1280;
            Globals.screenHeight = 720;

            _graphics.PreferredBackBufferWidth = Globals.screenWidth;
            _graphics.PreferredBackBufferHeight = Globals.screenHeight;

            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.screenWidth = _graphics.PreferredBackBufferWidth;
            Globals.screenHeight = _graphics.PreferredBackBufferHeight;
            Globals.keyBoard = new KeyBoardInput();
            Globals.mouse = new MouseInput();
            Globals.content = this.Content;
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);

            world = new MainWorld(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            Globals.gameTime = gameTime;
            
            Globals.keyBoard.Update();
            Globals.mouse.Update();

            world.Update(new Vector2(0,0),gameTime);

            Globals.keyBoard.UpdateOldKeyboard(); 
            Globals.mouse.UpdateOld();


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            Globals.spriteBatch.Begin(SpriteSortMode.Deferred,BlendState.AlphaBlend);

            world.Draw(Vector2.Zero,gameTime);

            Globals.spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
