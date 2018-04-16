using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Void.ECS
{
    public class Scene
    {
        public Color ClearColor = Color.CornflowerBlue;
        public GraphicsDevice GraphicsDevice;

        public List<Entity> Entities;

        public void Start()
        {
            foreach (var entity in Entities)
            {
                entity.Start();   
            }
        }



        public void Update()
        {
        }

        public void Draw(SpriteBatch batch)
        {
            GraphicsDevice.Clear(ClearColor);
        }
    }
}
