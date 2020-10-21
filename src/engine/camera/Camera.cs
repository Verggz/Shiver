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


namespace ShiverMonoGame.src.engine.camera
{
    public class Camera
    {
        public Matrix transform;
        Vector2 pos;

        public Camera(){

        }

        public virtual void Update(Entity player){
            pos = new Vector2(player.pos.X,0);
            transform = Matrix.CreateTranslation(-player.pos.X, -player.pos.Y,0);
        }

    }
}