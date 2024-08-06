using static TOC.Options;

namespace TOC.AddOns.Common
{
    internal class Seer : IAddon
    {
        public AddonTypes Type => AddonTypes.Helpful;

        public void SetupCustomOption()
        {
            SetupAdtRoleOptions(14800, CustomRoles.Seer, canSetNum: true, teamSpawnOptions: true);
        }
    }
}