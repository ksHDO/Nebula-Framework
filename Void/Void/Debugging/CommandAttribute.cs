using System;

namespace Void.Debugging
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class CommandAttribute : Attribute
    {
        public string Name;
        public string Help;

        public CommandAttribute(string name, string help)
        {
            Name = name;
            Help = help;
        }
    }
}
