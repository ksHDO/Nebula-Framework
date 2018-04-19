using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void.ECS
{
    public class EntitySystem
    {
        public Scene Scene { get; set; }
        public virtual void Process(List<Entity> entities)
        {

        }
    }
}
