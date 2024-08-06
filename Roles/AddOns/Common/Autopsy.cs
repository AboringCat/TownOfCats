using static TOC.Options;

namespace TOC.AddOns.Common
{
    internal class Autopsy : IAddon
    {
        public AddonTypes Type => AddonTypes.Helpful;

        public void SetupCustomOption()
        {
            SetupAdtRoleOptions(13600, CustomRoles.Autopsy, canSetNum: true, teamSpawnOptions: true);
        }
    }
}