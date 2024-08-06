using HarmonyLib;

namespace TOC.Patches
{
    public static class CosmeticsPatch
    {
        [HarmonyPatch(typeof(HatManager), nameof(HatManager.CheckLongModeValidCosmetic))]
        class CheckLongModeValidCosmeticPatch
        {
            public static bool Prefix(ref bool __result)
            {
                __result = true;
                return false;
            }
        }
    }
}