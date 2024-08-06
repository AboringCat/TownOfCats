using AmongUs.GameOptions;

namespace TOC.Crewmate
{
    public class Altruist : RoleBase
    {
        public static bool On;
        public override bool IsEnable => On;

        public override void Init()
        {
            On = false;
        }

        public override void Add(byte playerId)
        {
            On = true;
        }

        public override void SetupCustomOption() => Options.SetupRoleOptions(642600, TabGroup.CrewmateRoles, CustomRoles.Altruist);

        public static void OnKilled(PlayerControl killer)
        {
            if (killer == null) return;
            if (!killer.GetCustomRole().IsImpostor()) return;

            killer.RpcSetCustomRole(killer.Is(RoleTypes.Shapeshifter) ? CustomRoles.ShapeshifterTOC : killer.IsImpostor() ? CustomRoles.ImpostorTOC : CustomRoles.Amnesiac);
        }
    }
}