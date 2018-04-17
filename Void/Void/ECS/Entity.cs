using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Void.ECS.Components;

namespace Void.ECS
{
    public class Entity
    {
        public string Name { get; set; }
        public Scene Scene { get; set; }
        private List<Component> _components;
        public bool IsEnabled { get; set; } = true;

        public Transform Transform;

        public Entity()
        {
            _components = new List<Component>();

            Transform = AddComponent<Transform>();
        }

        public Entity(string name) : this()
        {
            Name = name;
        }

        public void Start()
        {
            _components.ForEach(c => c.Start());
        }

        public void Update()
        {
            _components.ForEach(c => c.Update());
        }

        public void Draw(SpriteBatch batch)
        {
            _components.ForEach(c => c.Draw(batch));
        }

        public T AddComponent<T>() where T : Component
        {
            T component = (T) Activator.CreateInstance(typeof(T));
            return AddComponent(component);
        }

        public void End()
        {
           _components.ForEach(c => c.End());
        }

        public T AddComponent<T>(T component) where T : Component
        {
            component.Entity = this;
            _components.Add(component);
            return component;
        }

        public T GetComponent<T>() where T : Component
        {
            foreach (var component in _components)
            {
                if (component.GetType() == typeof(T))
                {
                    return (T) component;
                }
            }
            return default(T);
        }

        public Component GetComponent(Type t)
        {
            foreach (var component in _components)
            {
                if (component.GetType() == t)
                {
                    return component;
                }
            }
            return default(Component);
        }
    }
}
