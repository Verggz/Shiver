using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ShiverMonoGame.src.engine;
using ShiverMonoGame.src.engine.Input;
using ShiverMonoGame.src.engine.entities;
using ShiverMonoGame.src.engine.Maths;
using ShiverMonoGame.src.engine.time;
using ShiverMonoGame.src.assets.player.scripts;

namespace ShiverMonoGame.src.assets.enemies.scripts
{
    public class Enemy : Entity
    {
        public Enemy(string _path,Vector2 _pos, Vector2 _dimensions,GraphicsDevice _gDevice): base(_path,_pos,_dimensions,_gDevice){
            speed = 6f;
        }

        public virtual void Update(Vector2 _offset,Player _player){
            base.Update(_offset);
        }

        public override void Draw(Vector2 _offset){
            base.Draw(_offset);
        }

        public virtual void EnemyControl(Player _player){

        }
    }
}