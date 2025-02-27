﻿using HarmonyLib;

namespace WarpersNoWarping.Patches
{
    [HarmonyPatch(typeof(Warper), nameof(Warper.OnKill))]
    public class Warper_OnKill
    {
        [HarmonyPrefix]
        public static void Prefix(Warper __instance)
        {
            __instance.WarpOut();
        }
    }
}