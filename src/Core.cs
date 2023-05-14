using Vintagestory.API.Common;

[assembly: ModInfo(name: "Glider Variations")]

namespace GliderVariations
{
    public class Core : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterCollectibleBehaviorClass("GliderVanillaName", typeof(CollectibleBehaviorGliderVanillaName));
            api.World.Logger.Event("started 'Glider Variations' mod");
        }
    }
}