using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Void.ECS
{
    public class Scene
    {
        public Color ClearColor = Color.CornflowerBlue;
        public GraphicsDevice GraphicsDevice;
        public ContentManager SharedContent;
        public ContentManager Content;

        public List<Entity> Entities;

        public Scene()
        {
        }

        public void Start()
        {
            Entities.ForEach(e => e.Start());
        }

        public void Update()
        {
            Entities.ForEach(e => e.Update());
        }

        public void Draw(SpriteBatch batch)
        {
            GraphicsDevice.Clear(ClearColor);
            foreach (var entity in Entities)
            {
                entity.Draw(batch);
            }
        }

        public void End()
        {
            Entities.ForEach(e => e.End());
        }
    }
}
