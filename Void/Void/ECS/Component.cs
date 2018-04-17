using System;
using Microsoft.Xna.Framework.Graphics;
using Void.ECS.Components;

namespace Void.ECS
{
    public class Component
    {
        private bool _isEnabled = true;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                if (_isEnabled)
                {
                    OnEnabled();
                }
                else
                {
                    OnDisabled();
                }
            }
        }

        public Transform Transform => Entity.Transform;

        public Entity Entity;

        public T GetComponent<T>() where T : Component
        {
            return Entity.GetComponent<T>();
        }

        public virtual void Start()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch batch)
        {

        }

        public virtual void OnEnabled()
        {

        }

        public virtual void OnDisabled()
        {

        }

        public virtual void End()
        {
            
        }
    }
}
