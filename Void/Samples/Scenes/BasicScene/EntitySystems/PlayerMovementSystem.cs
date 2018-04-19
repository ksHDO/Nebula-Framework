using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Samples.Scenes.BasicScene.Components;
using Void.ECS;
using Void.Utilities;

namespace Samples.Scenes.BasicScene.EntitySystems
{
    public class PlayerMovementSystem : EntitySystem
    {
        public PlayerMovementSystem() : base(new EntitySelector().With(typeof(MovementComponent)))
        {
        }

        public override void Process(List<Entity> entities)
        {
            foreach (var entity in entities)
            {
                var movement = entity.GetComponent<MovementComponent>();
                entity.Transform.Position += new Vector2(movement.MoveSpeed, movement.MoveSpeed) * Time.DeltaTime;
            }
            base.Process(entities);
        }
    }
}