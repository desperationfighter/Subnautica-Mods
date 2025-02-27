﻿using HarmonyLib;
using UnityEngine;

namespace BuildingTweaks.Patches
{
    [HarmonyPatch(typeof(Constructable), nameof(Constructable.DeconstructionAllowed))]
    public static class Constructable_DeconstructionAllowed_Patch
    {
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result)
        {
            if (Main.config.FullOverride)
            {
                __result = true;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(BaseDeconstructable), nameof(BaseDeconstructable.DeconstructionAllowed))]
    public static class BaseDeconstructable_DeconstructionAllowed_Patch
    {
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result)
        {
            if (Main.config.FullOverride)
            {
                __result = true;
                return false;
            }
            return true;
        }
    }
}
