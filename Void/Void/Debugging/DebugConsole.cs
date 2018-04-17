using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Nebula.Debug
{
    public class DebugConsole
    {
        struct Command
        {
            public Action<string[]> Action;
            public string Help;
        }

        private Dictionary<string, Command> _commands;

        public DebugConsole()
        {
            _commands = new Dictionary<string, Command>();
            
            ProcessAssembly(typeof(DebugConsole).Assembly);
        }

        private void ProcessAssembly(Assembly assembly)
        {
            foreach (var type in assembly.DefinedTypes)
            {
                foreach (var method in type.DeclaredMethods)
                {
                    CommandAttribute command = method.GetCustomAttribute<CommandAttribute>();
                    if (command != null)
                    {
                        ProcessMethod(method, command);
                    }
                }
            }
        }

        private void ProcessMethod(MethodInfo method, CommandAttribute attribute)
        {
            if (!method.IsStatic)
            {
                throw new Exception($"{method.DeclaringType.Name}.{method.Name} should be static");
            }

            var parameters = method.GetParameters();


        }

    }
}
