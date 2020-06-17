using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShiverMonoGame.src.engine.entities
{
    public class BasicGameObject2D
    {
       public Vector2 pos;
       public Vector2 dimensions;
       public Texture2D img;
       
        public BasicGameObject2D(string _path,Vector2 _pos, Vector2 _dimensions,GraphicsDevice _graphicsDevice ){
            pos = _pos;
            dimensions = _dimensions;
            FileStream stream = new FileStream(_path,FileMode.Open);
            img = Texture2D.FromStream(_graphicsDevice,stream);
        }

        public virtual void Update(){

        }

        public virtual void Draw(){
            if(img != null){
                Globals.spriteBatch.Draw(img,pos,null,Color.White,0.0f,new Vector2(img.Bounds.Width / 2,img.Bounds.Height / 2),new Vector2(1,1),new SpriteEffects(),0);
            }
        }
    }
}