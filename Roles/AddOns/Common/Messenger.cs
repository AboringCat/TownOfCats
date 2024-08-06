using System.Collections.Generic;

namespace TOC.AddOns.Common
{
    public class Messenger : IAddon
    {
        public static HashSet<byte> Sent = [];
        public AddonTypes Type => AddonTypes.Helpful;

        public void SetupCustomOption()
        {
            Options.SetupAdtRoleOptions(649394, CustomRoles.Messenger, canSetNum: true, teamSpawnOptions: true);
        }
    }
}