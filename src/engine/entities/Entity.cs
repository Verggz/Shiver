using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ShiverMonoGame.src.engine;
using ShiverMonoGame.src.engine.entities;
using ShiverMonoGame.src.engine.Maths;

namespace ShiverMonoGame.src.engine.entities
{
    public class Entity : GameObject
    {
        public float speed;
        public bool destroyed;

        public Entity(string _path,Vector2 _pos, Vector2 _dimensions,GraphicsDevice device) : base(_path,_pos,_dimensions,device){
            speed = 6.0f;
            collision.enabled = true;
        }

        public virtual void Update(Vector2 _offset){
            
            base.Update(_offset);
        }

        public virtual void Draw(Vector2 _offset){
            base.Draw(_offset);
        }
    }
}