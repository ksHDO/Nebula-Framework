using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Void.ECS;
using Void.Utilities;

namespace Void
{
    public class Core : Game
    {
        protected GraphicsDeviceManager GraphicsDeviceManager;
        protected SpriteBatch SpriteBatch;

        private Scene _currentScene;
        private Scene _pendingScene;

        public Scene Scene
        {
            get => _currentScene;
            set => _pendingScene = value;
        }

        public Core(string contentDirectory = "Content")
        {
            GraphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = contentDirectory;
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            Time.TimeScale = gameTime.TotalGameTime.TotalSeconds;

            if (_pendingScene != null)
            {
                _pendingScene.GraphicsDevice = GraphicsDevice;
                _pendingScene.SharedContent = Content;
                _pendingScene.Content = new ContentManager(Services);
                _currentScene.End();
                _currentScene = _pendingScene;
                _pendingScene.Start();
                _pendingScene = null;
            }
            _currentScene?.Update();
        }

        protected override void Draw(GameTime gameTime)
        {
            Time.FixedDeltaTime = gameTime.TotalGameTime.TotalSeconds;
            _currentScene?.Draw(SpriteBatch);

            base.Draw(gameTime);
        }
    }
}
