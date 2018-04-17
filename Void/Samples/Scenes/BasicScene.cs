using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Void.ECS;
using Void.ECS.Components;

namespace Samples.Scenes
{
    public class BasicScene : Scene
    {
        public override void Initialize()
        {
            Texture2D texture = Content.Load<Texture2D>("Textures/tempCircle");
            Entity e = AddEntity<Entity>(new Sprite(texture));
            
            base.Initialize();
        }
    }
}
