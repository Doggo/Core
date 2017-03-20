using System;

namespace Doggo
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class InitializerAttribute : Attribute
    {
        public string Name { get; }

        public InitializerAttribute(string name = null)
        {
            Name = name;
        }
    }
}
