using Terraria.ModLoader;

namespace SimpleTerrariaOverhaul
{
	class SimpleTerrariaOverhaul : Mod
	{
		public SimpleTerrariaOverhaul()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
