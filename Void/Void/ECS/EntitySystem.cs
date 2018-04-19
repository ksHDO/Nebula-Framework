using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void.ECS
{
    public class EntitySystem
    {
        public List<Entity> InvolvedEntities;

        public Scene Scene { get; set; }
        public EntitySelector Selector { get; private set; }

        public EntitySystem(EntitySelector selector)
        {
            Selector = selector;
        }

        public virtual void Process(List<Entity> entities)
        {

        }
    }
}
