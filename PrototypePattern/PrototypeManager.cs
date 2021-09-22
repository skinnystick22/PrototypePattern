using System.Collections.Generic;

namespace PrototypePattern
{
    public class PrototypeManager
    {
        private readonly Dictionary<string, Prototype> _prototypeLibrary = new();

        public Prototype this[string key]
        {
            get => _prototypeLibrary[key];
            set => _prototypeLibrary.Add(key, value);
        }
    }
}