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
using ShiverMonoGame.src.engine.world.scenes;
using ShiverMonoGame.src.assets;
using ShiverMonoGame.src.assets.player.scripts;
using ShiverMonoGame.src.assets.enemies.scripts;
using ShiverMonoGame.src.engine.camera;

namespace ShiverMonoGame.src.engine.world
{
    public class World
    {
        public string name;
        public List<SceneManager> sceneManagers;
        public Vector2 offset;

        public World(GraphicsDevice device){
            sceneManagers = new List<SceneManager>();
        }

        public virtual void Update(Vector2 _offset,GameTime gameTime){

        }

        public virtual void Draw(Vector2 _offset,GameTime gameTime){

        }

        public virtual SceneManager CreateSceneManager(string _name){
            SceneManager newSceneManager = new SceneManager(_name);
            sceneManagers.Add(newSceneManager);

            return newSceneManager;
        }

        public virtual SceneManager FindSceneManagerByName(string _name){
            for(int i = 0; i < sceneManagers.Count; i++){
                if(sceneManagers[i].name == _name){
                    return sceneManagers[i];
                }
            }

            Console.WriteLine("Couldnt find");
            return null;
        }

        public virtual SceneManager LoadSceneManager(int index){
            return sceneManagers[index];
        }
    }
}