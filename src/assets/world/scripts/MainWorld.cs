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
using ShiverMonoGame.src.engine.world;
using ShiverMonoGame.src.engine.UI;
using ShiverMonoGame.src.engine.camera;

namespace ShiverMonoGame.src.assets.world
{
    public class MainWorld : World
    {
        public Player player;
        public UI ui;
        public List<Enemy> enemies = new List<Enemy>();
        
        public MainWorld(GraphicsDevice device) : base(device){
            CreateSceneManager("main");

            ui = new UI();
            
            player = new Player("./src/assets/player/sprites/penguinsprite.png",new Vector2(400,200),new Vector2(16,16),device);
            GameManager.passEnemy = AddEnemy;
            
            enemies.Add(new Enemy("./Icon.bmp",new Vector2(400,400),new Vector2(0.5f,0.5f),device));
            List<Entity> allEntities = new List<Entity>();
            allEntities.AddRange(enemies);
            Scene mainScene = FindSceneManagerByName("main").CreateScene("mainScene",player,allEntities,null);
            mainScene.Update = (_offset) =>{
                mainScene.player.Update(_offset);

                for(int i = 0; i < mainScene.entities.Count; i++){
                    if(mainScene.entities[i].collision.IsColliding(mainScene.player.collision.width,mainScene.player.collision.height,mainScene.player.pos)){
                        Console.WriteLine("True: Is Colliding");
                    }else{
                        Console.WriteLine("False: Is Not Colliding");
                    }
                    mainScene.entities[i].Update(_offset);
                    //Console.WriteLine($"Enemy: X: {enemies[i].collision.pos.X} Y: {enemies[i].collision.pos.Y}");
                    if(mainScene.entities[i].destroyed){
                        mainScene.entities.RemoveAt(i);
                        i--;
                    }
                }

                return null;
            };

            mainScene.Draw = (_offset) =>{
                player.Draw(_offset);

                for(int i = 0; i < enemies.Count; i++){
                    enemies[i].Draw(_offset);
                }

                return null;
            };


            
        }
        public virtual void AddEnemy(object _enemy){
            enemies.Add((Enemy) _enemy);
        }
        
        public virtual void Update(Vector2 _offset, GameTime gameTime){
            FindSceneManagerByName("main").FindSpecificSceneByName("mainScene").Update(_offset);
        }

        public virtual void Draw(Vector2 _offset,GameTime gameTime){
            FindSceneManagerByName("main").FindSpecificSceneByName("mainScene").Draw(_offset);
            ui.Draw();
        }
    }


}