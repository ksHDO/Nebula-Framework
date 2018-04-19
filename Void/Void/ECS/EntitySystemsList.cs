using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Void.ECS
{
    public class EntitySystemsList : IEnumerable<EntitySystem>
    {
        private struct EntitySystemData
        {
            public EntitySystem System;
            public List<Entity> Entities;
        }

        private List<EntitySystemData> _entitySystems;

        public EntitySystemsList()
        {
            _entitySystems = new List<EntitySystemData>();
        }

        public void AddSystem(EntitySystem system, List<Entity> entities)
        {
            var esd = new EntitySystemData()
            {
                System = system,
                Entities = entities.Where(e => system.Selector.TestEntity(e)).ToList()
            };
            _entitySystems.Add(esd);
        }

        public void RemoveSystem(EntitySystem system)
        {
            _entitySystems.RemoveAll(esd => esd.System == system);
        }

        public void AddEntity(Entity entity)
        {
            _entitySystems.ForEach(esd =>
            {
                if (esd.System.Selector.TestEntity(entity))
                {
                    esd.Entities.Add(entity);
                }
            });
        }

        public void RemoveEntity(Entity entity)
        {
            _entitySystems.ForEach(esd =>
            {
                if (esd.Entities.Contains(entity))
                {
                    esd.Entities.Remove(entity);
                }
            });
        }

        public void Process()
        {
            _entitySystems.ForEach(esd =>
            {
                esd.System.Process(esd.Entities);
            });
        }

        public IEnumerator<EntitySystem> GetEnumerator()
        {
            return _entitySystems.Select(es => es.System).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
