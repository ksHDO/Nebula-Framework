using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Void.ECS.Components
{
    public class Transform : Component
    {
        public Transform Parent;
        public List<Transform> Children;

        public Vector2 LocalPosition;
        public float Rotation;

        public Vector2 GlobalPosition
        {
            get
            {
                Vector2 position = (Parent?.GlobalPosition ?? Vector2.Zero) + LocalPosition;
                return position;
            }
        }

        public Vector2 Position
        {
            get => LocalPosition;
            set => LocalPosition = value;
        }


    }
}
