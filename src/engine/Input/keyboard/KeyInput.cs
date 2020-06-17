using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShiverMonoGame.src.engine.Input.keyboard
{
    public class KeyInput
    {
        public int state;

        public string key;
        public string print;
        public string display;
        
        public KeyInput(string _key,int _state){
            key = _key;
            state = _state;
        }

        public virtual void Update(){
            state = 1;
        }

        public void ProcessInput(string _key){
            display = _key;
            
        }
    }
}