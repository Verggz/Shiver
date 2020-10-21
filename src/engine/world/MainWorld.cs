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
    public class MainWorld
    {
        public Player player;
        public List<Enemy> enemies = new List<Enemy>();
        public List<SceneManager> sceneManagers;
        public Vector2 offset;
        
        public MainWorld(GraphicsDevice device){
            player = new Player("./src/assets/player/sprites/penguinsprite.png",new Vector2(400,200),new Vector2(16,16),device);
            GameManager.passEnemy = AddEnemy;
            enemies.Add(new Enemy("./Icon.bmp",new Vector2(400,400),new Vector2(0.5f,0.5f),device));
        }
        public virtual void AddEnemy(object _enemy){
            enemies.Add((Enemy) _enemy);
        }
        
        public virtual void Update(Vector2 _offset, GameTime gameTime){
            player.Update(_offset);

            for(int i =0; i < enemies.Count; i++){
                if(enemies[i].collision.IsColliding(player.collision.width,player.collision.height,player.pos)){
                    Console.WriteLine("True: Is Colliding");
                }else{
                    Console.WriteLine("False: Is Not Colliding");
                }
                enemies[i].Update(_offset);
                //Console.WriteLine($"Enemy: X: {enemies[i].collision.pos.X} Y: {enemies[i].collision.pos.Y}");
                if(enemies[i].destroyed){
                    enemies.RemoveAt(i);
                    i--;
                }
            }
        }

        public virtual void Draw(Vector2 _offset,GameTime gameTime){
            player.Draw(_offset);

            for(int i = 0; i < enemies.Count; i++){
                enemies[i].Draw(_offset);
            }
        }
    }


}