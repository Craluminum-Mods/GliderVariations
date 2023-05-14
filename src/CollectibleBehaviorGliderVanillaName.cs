using Vintagestory.API.Common;
using System.Text;
using Vintagestory.API.Config;

namespace GliderVariations
{
    public class CollectibleBehaviorGliderVanillaName : CollectibleBehavior
    {
        public CollectibleBehaviorGliderVanillaName(CollectibleObject collObj) : base(collObj)
        {
        }

        public override void GetHeldItemName(StringBuilder sb, ItemStack itemStack)
        {
            var gliderName = Lang.Get("item-glider");
            var type = itemStack.Collectible.Variant["type"];
            var colorTranslated = $"color-{type}";
            var part = Lang.Get(colorTranslated);

            var copySb = sb.ToString();

            if (colorTranslated != part)
            {
                sb.Clear();
                sb.Append(Lang.Get("item-glider"));
                sb.Append(" (");
                sb.Append(part);
                sb.Append(')');
            }
            else if (copySb.Contains("dragon"))
            {
                var dragonColor = type.Split('-');
                var dragon = Lang.Get("glidervar:" + dragonColor[0]);
                var color = Lang.Get("color-" + dragonColor[1]);

                sb.Clear();
                sb.Append(gliderName);
                sb.Append(" (");
                sb.Append(dragon);
                sb.Append(") (");
                sb.Append(color);
                sb.Append(')');
            }
            else if (copySb.Contains("bat"))
            {
                sb.Clear();
                sb.Append(gliderName);
                sb.Append(" (");
                sb.Append(Lang.Get("glidervar:bat"));
                sb.Append(')');
            }
            else if (copySb.Contains("feather"))
            {
                sb.Clear();
                sb.Append(gliderName);
                sb.Append(" (");
                sb.Append(Lang.Get("item-feather"));
                sb.Append(')');
            }

            base.GetHeldItemName(sb, itemStack);
        }
    }
}