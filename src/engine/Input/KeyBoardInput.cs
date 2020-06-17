using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShiverMonoGame.src.engine.Input.keyboard;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ShiverMonoGame.src.engine.Input
{
    public class KeyBoardInput
    {
        public KeyboardState oldKeyboardState;
        public KeyboardState newKeyboardState;

        public List<KeyInput> curPressedKeys = new List<KeyInput>();
        public List<KeyInput> prevPressedKeys = new List<KeyInput>();


        public KeyBoardInput(){

        }

        public virtual void Update(){
            newKeyboardState = Keyboard.GetState();
            GetPressedKeys();
        }

        public virtual void Draw(){

        }

        public virtual void GetPressedKeys(){
            bool found = false;
            curPressedKeys.Clear();
            for(int i = 0; i < newKeyboardState.GetPressedKeys().Length; i++){
                curPressedKeys.Add(new KeyInput(newKeyboardState.GetPressedKeys()[i].ToString(),0));
            }
        }

        public bool GetPressData(string _key){
            for(int i = 0; i < curPressedKeys.Count; i++){
                if(curPressedKeys[i].key == _key){
                    return true;
                }
            }

            return false;

        }

        public void UpdateOldKeyboard(){
            oldKeyboardState = newKeyboardState;

            prevPressedKeys = new List<KeyInput>();
            for(int i = 0; i < curPressedKeys.Count; i++){
                prevPressedKeys.Add(curPressedKeys[i]);
            }
        }

        
    }
}