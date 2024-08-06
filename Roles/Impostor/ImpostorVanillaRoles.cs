using static TOC.Options;

namespace TOC.Impostor
{
    internal class ImpostorVanillaRoles : IVanillaSettingHolder
    {
        public static OptionItem PhantomCooldown;
        public static OptionItem PhantomDuration;
        public static OptionItem ShapeshiftCD;
        public static OptionItem ShapeshiftDur;
        public TabGroup Tab => TabGroup.ImpostorRoles;

        public void SetupCustomOption()
        {
            SetupRoleOptions(300, Tab, CustomRoles.ImpostorTOC);
            SetupRoleOptions(350, Tab, CustomRoles.PhantomTOC);
            PhantomCooldown = new FloatOptionItem(352, "PhantomCooldown", new(1f, 180f, 1f), 30f, Tab)
                .SetParent(CustomRoleSpawnChances[CustomRoles.PhantomTOC])
                .SetValueFormat(OptionFormat.Seconds);
            PhantomDuration = new FloatOptionItem(353, "PhantomDuration", new(1f, 60f, 1f), 10f, Tab)
                .SetParent(CustomRoleSpawnChances[CustomRoles.PhantomTOC])
                .SetValueFormat(OptionFormat.Seconds);
            SetupRoleOptions(400, Tab, CustomRoles.ShapeshifterTOC);
            ShapeshiftCD = new FloatOptionItem(402, "ShapeshiftCooldown", new(1f, 180f, 1f), 30f, Tab)
                .SetParent(CustomRoleSpawnChances[CustomRoles.ShapeshifterTOC])
                .SetValueFormat(OptionFormat.Seconds);
            ShapeshiftDur = new FloatOptionItem(403, "ShapeshiftDuration", new(1f, 60f, 1f), 10f, Tab)
                .SetParent(CustomRoleSpawnChances[CustomRoles.ShapeshifterTOC])
                .SetValueFormat(OptionFormat.Seconds);
        }
    }
}