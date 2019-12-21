using Terraria.ID;
using Terraria.ModLoader;

namespace Thorium_fp.Items
{
	public class Frost_Pelter : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Frost Pelter"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			item.damage = 7;
			item.crit = 0;
			item.ranged = true;
			item.width = 32;
			item.height = 30;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 600;
			item.rare = 0;
			item.shootSpeed = 8f;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = 10;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			Mod thoriumMod = ModLoader.GetMod("ThoriumMod");
			if (thoriumMod != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(thoriumMod.ItemType("IcyShard"), 8);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}


	}
}