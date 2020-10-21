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
using ShiverMonoGame.src.assets.player.scripts;
using ShiverMonoGame.src.assets.enemies.scripts;
using ShiverMonoGame.src.engine.camera;


namespace ShiverMonoGame.src.engine.physics.collision
{
    public class AABB
    {
        Rectangle box;
        public bool enabled = false;

        public float width;
        public float height;
        public Vector2 pos;

        public AABB(float _width,float _height, Vector2 _pos){
            width = _width;
            height = _height;
            pos = _pos;
            
        }

        public void UpdateCoords(Vector2 _pos){
            pos = _pos;
        }

        public bool Toggle(){
            enabled = !enabled;
            return enabled;
        }

        public bool IsColliding(float _otherWidth, float _otherHeight, Vector2 _otherPos){
            if(enabled){
                if(
                pos.X < _otherPos.X + _otherWidth &&
                pos.X + width > _otherPos.X &&
                pos.Y < _otherPos.Y + _otherHeight &&
                pos.Y + height > _otherHeight
                ){
                    return true;
                }else{
                    return false;
                }
            }else{
                return false;
            }

        }

        public virtual void Update(Vector2 _pos,Vector2 _offset){
            UpdateCoords(_pos);
        }

        public virtual void Draw(Vector2 _offset){

        }
    }
}