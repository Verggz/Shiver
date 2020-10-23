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


namespace ShiverMonoGame.src.engine.world.scenes
{
    public class SceneManager
    {
        
        public string name;
        public List<Scene> scenes;
        public IDictionary<string,Func<Object,Object>> funcs; 

        public SceneManager(string _name){
            name = _name;
            scenes = new List<Scene>();
        }

        //Returns scene if found, else returns null
        public Scene FindSpecificSceneByName(string _name){
            for(int i = 0; i < scenes.Count; i++){
                if(scenes[i].name == _name){
                    return scenes[i];
                }
            }
            return null;
        }

        public Scene LoadScene(int index){
            return scenes[index];
        }

        //Creates a Scene and Returns and adds it to the
        public Scene CreateScene(string _name,Entity player ,List<Entity> _entities,List<GameObject> _objects){
            Scene newScene = new Scene(_name,player,_entities,_objects);
            scenes.Add(newScene);
            return newScene;
        }


        //Returns true if successfully saved scene, else returns false
        public bool SaveScene(){
            return false;
        }
    }
}