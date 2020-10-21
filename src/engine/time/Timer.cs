using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

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

namespace ShiverMonoGame.src.engine.time
{
    public class Timer
    {
        public bool run;
        public int mSec;
        public TimeSpan timerspan = new TimeSpan();

        public Timer(int _mTime){
            run = false;
            mSec = _mTime;
        }
        public Timer(int _mTime,bool _startLoaded){
            run = _startLoaded;
            mSec = _mTime;
            
        }

        public int timer{
            get{return (int)timerspan.TotalMilliseconds; }
        }

        public void UpdateTimer(){
            timerspan += Globals.gameTime.ElapsedGameTime;
        }

        public void UpdateTimer(float _speed){
            timerspan += TimeSpan.FromTicks((long)(Globals.gameTime.ElapsedGameTime.Ticks * _speed));
        }

        public virtual void AddToTimer(int _mTime){
            timerspan += TimeSpan.FromMilliseconds((long)_mTime);
        }

        public bool CheckTimer(){
            if(timerspan.TotalMilliseconds >= mSec || run){
                return true;
            }else{
                return false;
            }
        }

        public void ResetTimer(){
            timerspan = timerspan.Subtract(new TimeSpan(0,0,mSec / 60000, mSec / 100, mSec % 100));
            if(timerspan.TotalMilliseconds < 0){
                timerspan = TimeSpan.Zero;
            }

            run = false;
        }

        public void ResetTimer(int _newTime){
            timerspan = TimeSpan.Zero;
            mSec = _newTime;
            run = false;
        }

        public void ResetTimerToZero(){
            timerspan = TimeSpan.Zero;
            run = false;
        }

        public virtual XElement ReturnTimerXml(){
            XElement data = new XElement("Timer",new XElement("mSec",mSec),new XElement("timer",timer));

            return data;
        }

        public void SetTimer(TimeSpan _timeSpan){
            timerspan = _timeSpan;
        }

        public void SetTimer(int _mSec){
            timerspan = TimeSpan.FromMilliseconds((long)_mSec);
        }


    }
}