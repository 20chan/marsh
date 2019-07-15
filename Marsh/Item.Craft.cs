using System;

namespace Marsh {
    public class ItemCraftAttribute : Attribute {
        public ItemType A, B;
        public ItemCraftAttribute(ItemType a, ItemType b) {
            A = a;
            B = b;
        }
    }
}