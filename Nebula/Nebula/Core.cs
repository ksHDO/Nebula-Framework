using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nebula.ECS;
using Nebula.Utilities;

namespace Nebula
{
    public class Core : Game
    {
        protected GraphicsDeviceManager _graphicsDevice;
        protected SpriteBatch _spriteBatch;

        private Scene _scene;

        public Scene Scene
        {
            get => _scene;
            set { _scene = value; }
        }

        public Core(string contentDirectory = "Content")
        {
            _graphicsDevice = new GraphicsDeviceManager(this);
            Content.RootDirectory = contentDirectory;
        }

        protected override void Update(GameTime gameTime)
        {
            Time.TimeScale = gameTime.TotalGameTime.TotalSeconds;

            _scene?.Update();
        }

        protected override void Draw(GameTime gameTime)
        {
            Time.FixedDeltaTime = gameTime.TotalGameTime.TotalSeconds;
            _scene?.Draw();

            base.Draw(gameTime);
        }
    }
}
