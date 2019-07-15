using System;

namespace Marsh {
    public class ItemInfoAttribute : Attribute {
        public string Name, Description;
        public ItemInfoAttribute(string name, string description) {
            // todo: globalization
            Name = name;
            Description = description;
        }
    }
}