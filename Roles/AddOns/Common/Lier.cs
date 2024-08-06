using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using TOC.Modules;
using TOC.AddOns;
using static TOC.Options;

namespace TOC.Roles.AddOns.Common
{
    internal class Lier : IAddon
    {
        public AddonTypes Type => AddonTypes.Harmful;
        public void SetupCustomOption()
        {
            SetupAdtRoleOptions(08926, CustomRoles.Lier, canSetNum: true, teamSpawnOptions: true);
            UnluckyKillSuicideChance = new IntegerOptionItem(18876, "LierKillSuicide", new(100, 100,  100), 2, TabGroup.Addons)
                .SetParent(CustomRoleSpawnChances[CustomRoles.Lier])
                .SetValueFormat(OptionFormat.Percent);
            UnluckyTaskSuicideChance = new IntegerOptionItem(18877, "LierTaskSuicide", new(100, 100, 100), 5, TabGroup.Addons)
                .SetParent(CustomRoleSpawnChances[CustomRoles.Lier])
                .SetValueFormat(OptionFormat.Percent);
        }
    }
}
