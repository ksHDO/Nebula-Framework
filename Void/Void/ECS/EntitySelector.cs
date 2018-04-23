using System;
using System.Collections.Generic;
using System.Linq;
using Void.Debugging;

namespace Void.ECS
{

    /// <summary>
    /// Rules for Entity Systems to determine which Entities to use.
    /// </summary>
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

        private readonly List<ComponentRule> _componentRules;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySelector"/> class.
        /// </summary>
        public EntitySelector()
        {
            _componentRules = new List<ComponentRule>();
        }

        /// <summary>
        /// Match entities with the passed component types.
        /// </summary>
        /// <param name="components">The components.</param>
        /// <returns></returns>
        /// <seealso cref="Exclude"/>
        public EntitySelector Include(params Type[] components)
        {
            // Verify if the component's already excluded?

            _componentRules.AddRange(components.Select(c => new ComponentRule(c, true)));
            return this;
        }

        /// <summary>
        /// Excludes entities with the passed component types.
        /// </summary>
        /// <param name="components">The components.</param>
        /// <returns></returns>
        /// <seealso cref="Include"/>
        public EntitySelector Exclude(params Type[] components)
        {
            // Verify if the component's already included?

            _componentRules.AddRange(components.Select(c => new ComponentRule(c, false)));
            return this;
        }

        /// <summary>
        /// Tests the passed entity with whether it matches the rules set by <see cref="Include"/> and <see cref="Exclude"/>.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
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
