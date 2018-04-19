using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Samples.Scenes.BasicScene.Components;
using Samples.Scenes.BasicScene.EntitySystems;
using Void.ECS;
using Void.ECS.Components;

namespace Samples.Scenes.BasicScene
{
    public class BasicScene : Scene
    {
        public override void Initialize()
        {
            Entity e = AddEntity<Entity>(new Sprite(Content, "Textures/tempCircle"), new MovementComponent() {MoveSpeed = 20});

            AddEntitySystem(new PlayerMovementSystem());

            base.Initialize();
        }
    }
}
