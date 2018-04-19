using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Void.ECS.Components
{
    public class Sprite : Renderer
    {
        private readonly Texture2D _texture;
        public Color Color = Color.White;

        public Sprite(ContentManager content, string spritePath)
        {
            _texture = content.Load<Texture2D>(spritePath);
        }

        public Sprite(Texture2D texture)
        {
             _texture = texture;
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.Draw(_texture, Transform.Position, Color);
            base.Draw(batch);
        }
    }
}
