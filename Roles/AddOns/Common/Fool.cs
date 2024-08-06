using static TOC.Options;

namespace TOC.AddOns.Common
{
    internal class Fool : IAddon
    {
        public AddonTypes Type => AddonTypes.Harmful;

        public void SetupCustomOption()
        {
            SetupAdtRoleOptions(19200, CustomRoles.Fool, canSetNum: true, teamSpawnOptions: true);
        }
    }
}