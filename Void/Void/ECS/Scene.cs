using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Void.ECS
{
    public class Scene : IDisposable
    {
        public Color ClearColor = Color.CornflowerBlue;
        public GraphicsDevice GraphicsDevice;
        public ContentManager SharedContent;
        public ContentManager Content;

        private List<Entity> _entities;
        private EntitySystemsList _entitySystems;
        private int _entityId;
        private string _entityName = "entity";

        public Scene()
        {
            _entities = new List<Entity>();
            _entitySystems = new EntitySystemsList();
        }

        public virtual void Initialize()
        {

        }

        public void Start()
        {
            _entities.ForEach(e => e.Start());
        }

        public void Update()
        {
            _entities.ForEach(e =>
            {
                e.Update();
            });

            _entitySystems.Process();
        }

        public void Draw(SpriteBatch batch)
        {
            batch.Begin();
            GraphicsDevice.Clear(ClearColor);
            foreach (var entity in _entities)
            {
                entity.Draw(batch);
            }
            batch.End();
        }

        public void End()
        {
            _entities.ForEach(e => e.End());
        }

        public T AddEntity<T>() where T : Entity
        {
            T entity = Activator.CreateInstance<T>();
            return AddEntity(entity);
        }

        public T AddEntity<T>(T entity) where T : Entity
        {
            entity.Scene = this;
            _entities.Add(entity);
            _entitySystems.AddEntity(entity);
            return entity;
        }

        public T AddEntity<T>(params Component[] components )
            where T : Entity
        {
            T entity = Activator.CreateInstance<T>();
            return AddEntity(entity, components);
        }

        public T AddEntity<T>(T entity, params Component[] components)
            where T : Entity
        {
            entity = AddEntity(entity);
            foreach (var component in components)
            {
                entity.AddComponent(component);
            }
            return entity;
        }

        public T AddEntitySystem<T>(T system) where T : EntitySystem
        {
            _entitySystems.AddSystem(system, _entities);
            return system;
        }

        public void Dispose()
        {
            Content?.Dispose();
        }
    }
}
