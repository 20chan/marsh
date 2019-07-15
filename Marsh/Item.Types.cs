using Craft = Marsh.ItemCraftAttribute;

namespace Marsh {
    public enum ItemType {
        BFSword,
        RecurveBow,
        ChainVest,
        NegatronCloak,
        NeedlesslyLargeRod,
        TearOfTheGoddess,
        GiantsBelt,
        Spatula,

        [Craft(RecurveBow, Spatula)]
        BladeOfTheRuinedKing,
    }
}