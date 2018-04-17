using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Void.ECS.Components
{
    public class Sprite : Component
    {
        private readonly Texture2D _texture;


        public Sprite(Texture2D texture)
        {
             _texture = texture;
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.Draw(_texture, Transform.Position, Color.White);
            base.Draw(batch);
        }
    }
}
