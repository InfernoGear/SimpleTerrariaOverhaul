using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleTerrariaOverhaul.Items
{
	public class ExcabliurKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Excabliur Knife");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 34;
			item.height = 34;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 3.9f;
			item.value = 200000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
