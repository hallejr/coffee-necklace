using COTL_API.CustomInventory;
using System.IO;

namespace CotLTemplateMod.Items
{
    internal class ExampleItem : CustomInventoryItem
    {
        public override string InternalName => "Coffee_Pendant";
        public override string LocalizedName() { return "Coffee Pendant"; }
        public override string LocalizedDescription() { return "All speed, no sleep."; }

        public override Sprite InventoryIcon => TextureHelper.CreateSpriteFromPath(Path.Combine(Plugin.PluginPath, "Assets", "coffee_necklace.png"));
    }
}
