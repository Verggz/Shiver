using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ShiverMonoGame.src.engine.entities;

namespace ShiverMonoGame.src.engine.world
{
    public class MainWorld
    {
        public BasicGameObject2D obj;
        
        public MainWorld(GraphicsDevice device){
            obj = new BasicGameObject2D("./src/assets/player/sprites/bruh.png",new Vector2(400,200),new Vector2(48,48),device);
        }
        
        public virtual void Update(){
            obj.Update();
        }

        public virtual void Draw(){
            obj.Draw();
        }
    }


}