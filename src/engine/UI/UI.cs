using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ShiverMonoGame.src.engine.entities;
using ShiverMonoGame.src.assets;
using ShiverMonoGame.src.engine.world;
using ShiverMonoGame.src.assets.player.scripts;
using ShiverMonoGame.src.assets.enemies.scripts;

namespace ShiverMonoGame.src.engine.UI
{
    public class UI
    {
        public SpriteFont font;
        
        public UI(){
            font = Globals.content.Load<SpriteFont>("fonts\\Arial16");
        }

        public void Update(World _world = null){

        }

        public void Draw(World _world = null){
            string str = "Hello world";
            Vector2 strDims = font.MeasureString(str);
            Globals.spriteBatch.DrawString(font,"Hello World",new Vector2(Globals.screenWidth / 2 - strDims.X/2,Globals.screenHeight - 40),Color.Black);
        }
    }
}