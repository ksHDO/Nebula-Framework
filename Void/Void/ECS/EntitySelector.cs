using System;
using System.Collections.Generic;
using System.Linq;
using Void.Debugging;

namespace Void.ECS
{

    public class EntitySelector
    {
        private struct ComponentRule
        {
            public readonly bool ShouldInclude;
            public readonly Type Component;

            public ComponentRule(Type component, bool shouldInclude)
            {
                if (!typeof(Component).IsAssignableFrom(component))
                    throw new ArgumentException("Passed type must be a component!");
                Component = component;
                ShouldInclude = shouldInclude;
            }
        }

        private List<ComponentRule> _componentRules;

        public EntitySelector()
        {
            _componentRules = new List<ComponentRule>();
        }

        public EntitySelector With(params Type[] components)
        {
            // Verify if the component's already excluded?

            _componentRules.AddRange(components.Select(c => new ComponentRule(c, true)));
            return this;
        }

        public EntitySelector Exclude(params Type[] components)
        {
            // Verify if the component's already included?

            _componentRules.AddRange(components.Select(c => new ComponentRule(c, false)));
            return this;
        }

        public bool TestEntity(Entity entity)
        {
            foreach (var componentRule in _componentRules)
            {
                Component c = entity.GetComponent(componentRule.Component);
                if ((componentRule.ShouldInclude && c == null) || (!componentRule.ShouldInclude && c != null))
                    return false;
            }

            return true;
        }
    }
}
