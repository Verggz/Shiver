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
    public class Scene
    {
        public string name;
        public Entity player;
        public List<Entity> entities;
        public List<GameObject> objects;

        public bool isWorld = true;
        public bool isShop = false;

        public Func<Vector2, Object> Update;
        public Func<Vector2, Object> Draw;

        public Scene(string _name,Entity _player,List<Entity> _entities,List<GameObject> _objects){
            player = _player;
            name = _name;
            entities = _entities;
            objects = _objects;
        }
    }
}