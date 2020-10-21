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


namespace ShiverMonoGame.src.assets.player.scripts
{
    public class Player : Entity
    {
        public GraphicsDevice gDevice;
        public float health;
        
        
        public Player(string _path,Vector2 _pos, Vector2 _dimensions,GraphicsDevice device) : base(_path,_pos,_dimensions,device){
            speed = 6f;
            gDevice = device;
            destroyed = false;
            rotation = 0;
        }

        public override void Update(Vector2 _offset){
            MovePlayer();
            Console.WriteLine($"Player width and height: Width: {width}  Height: {height}");
            if(Globals.mouse.LeftClick()){
                
            }
            base.Update(_offset);
        } 

        public override void Draw(Vector2 _offset){
            base.Draw(_offset);
        }

        public void MovePlayer(){
            //CREATE A BETTER METHOD FOR MOVEMENT (URGENT)
            if(Globals.keyBoard.GetPressData("W")){
                pos = new Vector2(pos.X,pos.Y - speed);
            }if(Globals.keyBoard.GetPressData("A")){
                pos = new Vector2(pos.X - speed,pos.Y);
            }if(Globals.keyBoard.GetPressData("S")){
                pos = new Vector2(pos.X,pos.Y + speed);
            }if(Globals.keyBoard.GetPressData("D")){
                pos = new Vector2(pos.X + speed,pos.Y);
            }

        }
    }
}