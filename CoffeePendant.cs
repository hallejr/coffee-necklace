using COTL_API.CustomInventory;
using System.IO;

namespace CotLTemplateMod.Items
{
    internal class ExampleItem : CustomInventoryItem
    {
        public override string InternalName => "Coffee_Pendant";
        public override string LocalizedName() { return "Coffee Pendant"; }
        public override string LocalizedDescription() { return "All speed, no sleep."; }
        public override string	LocalizedLore()	{ return "Followers wearing this necklace are caffenated. They do not sleep, and walk faster than others."; }

        public override Sprite InventoryIcon => TextureHelper.CreateSpriteFromPath(Path.Combine(Plugin.PluginPath, "Assets", "coffee_necklace_icon.png"));
        public override Sprite	Sprite	TextureHelper.CreateSpriteFromPath(PluginPaths.ResolveAssetPath(“coffee_necklace_sprite.png”))
        
        public override bool CanBeGivenToFollower True
        public override string	GiftTitle(Follower follower)	$“{Name()} ({Inventory.GetItemQuantity(ItemType)})“
        public override CustomItemManager.AddNecklace()
        public override CustomItemManager.ItemRarity	Rarity	CustomItemManager.ItemRarity.UNCOMMON

        public override bool	AddItemToDungeonChests	true
        public override int	DungeonChestSpawnChance	5
        public override int	DungeonChestMinAmount	1
        public override int	DungeonChestMaxAmount	3
        
    }
}
