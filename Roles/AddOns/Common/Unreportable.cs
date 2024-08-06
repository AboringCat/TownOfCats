using static TOC.Options;

namespace TOC.AddOns.Common
{
    internal class Unreportable : IAddon
    {
        public AddonTypes Type => AddonTypes.Harmful;

        public void SetupCustomOption()
        {
            SetupAdtRoleOptions(15300, CustomRoles.Unreportable, canSetNum: true, teamSpawnOptions: true);
        }
    }
}