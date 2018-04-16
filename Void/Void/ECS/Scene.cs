using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Void.ECS
{
    public class Scene
    {
        public Color ClearColor = Color.CornflowerBlue;
        public GraphicsDevice GraphicsDevice;

        public void Update()
        {

        }

        public void Draw(SpriteBatch batch)
        {
            GraphicsDevice.Clear(ClearColor);
        }
    }
}
