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
    public class Rotation
    {
        public static float RotateTowards(Vector2 Pos, Vector2 focus)
        {
            float h, sineTheta, angle;
            if(Pos.Y-focus.Y != 0)
            {
                h = (float)Math.Sqrt(Math.Pow(Pos.X-focus.X, 2) + Math.Pow(Pos.Y-focus.Y, 2));
                sineTheta = (float)(Math.Abs(Pos.Y-focus.Y)/h); //* ((item.Pos.Y-focus.Y)/(Math.Abs(item.Pos.Y-focus.Y))));
            }
            else
            {
                h = Pos.X-focus.X;
                sineTheta = 0;
            }

            angle = (float)Math.Asin(sineTheta);

            // Drawing diagonial lines here.
            //Quadrant 2
            if(Pos.X-focus.X > 0 && Pos.Y-focus.Y > 0)
            {
                angle = (float)(Math.PI*3/2 + angle);
            }
            //Quadrant 3
            else if(Pos.X-focus.X > 0 && Pos.Y-focus.Y < 0)
            {
                angle = (float)(Math.PI*3/2 - angle);
            }
            //Quadrant 1
            else if(Pos.X-focus.X < 0 && Pos.Y-focus.Y > 0)
            {
                angle = (float)(Math.PI/2 - angle);
            }
            else if(Pos.X-focus.X < 0 && Pos.Y-focus.Y < 0)
            {
                angle = (float)(Math.PI/2 + angle);
            }
            else if(Pos.X-focus.X > 0 && Pos.Y-focus.Y == 0)
            {
                angle = (float)Math.PI*3/2;
            }
            else if(Pos.X-focus.X < 0 && Pos.Y-focus.Y == 0)
            {
                angle = (float)Math.PI/2;
            }
            else if(Pos.X-focus.X == 0 && Pos.Y-focus.Y > 0)
            {
                angle = (float)0;
            }
            else if(Pos.X-focus.X == 0 && Pos.Y-focus.Y < 0)
            {
                angle = (float)Math.PI;
            }

            return angle;
        }
    }
}