using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShiverMonoGame.src.engine.Maths
{
    public class Distance
    {
        public static float GetDistance(Vector2 pos,Vector2 target){
            //returns distance scalar
            return (float)Math.Sqrt(Math.Pow(pos.X - target.X,2) + Math.Pow(pos.Y - target.Y,2));
        }
    }
}