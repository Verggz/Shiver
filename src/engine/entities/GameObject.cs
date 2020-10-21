using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ShiverMonoGame.src.engine.physics.collision;

namespace ShiverMonoGame.src.engine.entities
{
    public class GameObject
    {
       public float width;
       public float height;
       
       public Vector2 pos;
       public Vector2 dimensions;
       public Vector2 scale;

       public Texture2D img;
       public float rotation;
       public AABB collision;

       
        public GameObject(string _path,Vector2 _pos, Vector2 _dimensions,GraphicsDevice _graphicsDevice ){
            pos = _pos;
            dimensions = _dimensions;

            FileStream stream = new FileStream(_path,FileMode.Open);
            img = Texture2D.FromStream(_graphicsDevice,stream);

            width = img.Bounds.Width;
            height = img.Bounds.Height;

            scale = new Vector2(0.5f,0.5f);

            collision = new AABB(img.Bounds.Width * scale.X,img.Bounds.Height * scale.Y,_pos);
        }

        public virtual void Update(Vector2 _offset){
            collision.Update(pos,_offset);
        }

        public virtual void Draw(Vector2 _offset){
            if(img != null){
                Globals.spriteBatch.Draw(img,new Vector2(pos.X + _offset.X,pos.Y + _offset.Y),null,Color.White,rotation,new Vector2(img.Bounds.Width / 2,img.Bounds.Height / 2),scale,new SpriteEffects(),0);
            }
        }
        public virtual void Draw(Vector2 _offset, Vector2 _origin){
            if(img != null){
                Globals.spriteBatch.Draw(img,new Vector2(pos.X + _offset.X,pos.Y + _offset.Y),null,Color.White,rotation,new Vector2(_origin.X,_origin.Y),scale,new SpriteEffects(),0);
            }
        }
    }
}