using System.Collections.Generic;

namespace Void.ECS
{
    public class Entity
    {
        private List<Component> _components = new List<Component>();

        public void Start()
        {
            _components.ForEach(c => c.Start());
        }

        public void Update()
        {
            _components.ForEach(c => c.Update());
        }

        public void Draw()
        {
            _components.ForEach(c => c.Draw());
        }
    }
}
