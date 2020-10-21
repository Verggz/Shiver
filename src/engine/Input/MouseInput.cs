using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using ShiverMonoGame.src.engine;

namespace ShiverMonoGame.src.engine.Input
{
    public class MouseInput
    {
        public bool dragging;
        public bool rightDragging;

        public MouseState newMouse;
        public MouseState oldMouse;
        public MouseState firstMouse;

        public Vector2 newMousePos;
        public Vector2 oldMousePos;
        public Vector2 firstMousePos;
        public Vector2 newMouseAdjustedPos;
        public Vector2 systemCursorPos;
        public Vector2 screenLocation;

        public MouseInput(){
            dragging = false;

            newMouse = Mouse.GetState();
            oldMouse = newMouse;
            firstMouse = newMouse;

            newMousePos = new Vector2(newMouse.Position.X,newMouse.Position.Y);
            oldMousePos = new Vector2(newMouse.Position.X,newMouse.Position.Y);
            firstMousePos = new Vector2(newMouse.Position.X,newMouse.Position.Y);

            GetMouseAdjust();
        } 

        public virtual void Update(){
            GetMouseAdjust();

            if(newMouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && oldMouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                firstMouse = newMouse;
                firstMousePos = newMousePos = GetScreenPos(firstMouse);
            }
        }

        public virtual void Draw(){

        }

        public void UpdateOld(){
            oldMouse = newMouse;
            oldMousePos = GetScreenPos(newMouse);
        }

        public Vector2 GetScreenPos(MouseState _mouse){
            Vector2 tempVec = new Vector2(_mouse.Position.X,_mouse.Position.Y);

            return tempVec;
        }

        public void GetMouseAdjust(){
            newMouse = Mouse.GetState();
            newMousePos = new Vector2(newMouse.Position.X,newMouse.Position.Y);
        }

        public virtual bool LeftClick(){
            if(newMouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && oldMouse.LeftButton != Microsoft.Xna.Framework.Input.ButtonState.Pressed && newMouse.Position.X >= 0 && newMouse.Position.X <= Globals.screenWidth && newMouse.Position.Y >= 0 && newMouse.Position.Y <= Globals.screenHeight){
                return true;
            }

            return false;

        }

        public virtual bool LeftClickHold(){
            bool holding = false;
            if(newMouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && oldMouse.LeftButton == ButtonState.Pressed && newMouse.Position.X >= 0 && newMouse.Position.X <= Globals.screenWidth && newMouse.Position.Y >= 0 && newMouse.Position.Y <= Globals.screenHeight){
                holding = true;
                if(Math.Abs(newMouse.Position.X - firstMouse.Position.X) > 8 || Math.Abs(newMouse.Position.Y - firstMouse.Position.Y) > 8){
                    dragging = true;
                }

            }
            return holding;
        }

        public virtual bool LeftClickRelease(){
            if(newMouse.LeftButton == ButtonState.Released && oldMouse.LeftButton == ButtonState.Pressed){
                dragging = false;
                return true;
            }
            return false;
        }

        public virtual bool RightClick(){
            if(newMouse.RightButton == ButtonState.Pressed && oldMouse.RightButton != ButtonState.Pressed && newMouse.Position.X >= 0 && newMouse.Position.X <= Globals.screenWidth && newMouse.Position.Y >= 0 && newMouse.Position.Y <= Globals.screenHeight){
                return true;
            }
            return false;
        }

        public virtual bool RightClickHold(){
            bool holding = true;
            if(newMouse.RightButton == ButtonState.Pressed && oldMouse.RightButton == ButtonState.Pressed && newMouse.Position.X >= 0 && newMouse.Position.X <= Globals.screenWidth && newMouse.Position.Y >= 0 && newMouse.Position.Y <= Globals.screenHeight){
                holding = true;
                if(Math.Abs(newMouse.Position.X - firstMouse.Position.X) > 8 || Math.Abs(newMouse.Position.Y - firstMouse.Position.Y) > 8){
                    dragging = true;
                }

            }
            return holding;
        }

        public virtual bool RightClickRelease(){
            if(newMouse.RightButton == ButtonState.Released && oldMouse.RightButton == ButtonState.Pressed){
                dragging = false;
                return true;
            }
            return false;
        }
    }
}