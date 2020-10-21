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

namespace ShiverMonoGame.src.assets.world.scripts.types
{
    public class WorldScene : Scene
    {
        public WorldScene(string _name, List<Entity> _entities,List<GameObject> _objects) : base(_name,_entities,_objects){

        }
    }
}