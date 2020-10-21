using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShiverMonoGame.src.engine.Input;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShiverMonoGame.src.engine
{
    public delegate void PassObject(object i);
    public delegate object PassObjectAndReturn(object i);
    public class Globals
    {

        
        public static ContentManager content;
        public static SpriteBatch spriteBatch;
        public static GameTime gameTime;

        public static KeyBoardInput keyBoard;
        public static MouseInput mouse;
        
        public static int screenWidth;
        public static int screenHeight;
    }
}