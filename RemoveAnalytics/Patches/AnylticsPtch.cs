using HarmonyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using UnityEngine;

namespace RemoveAnalytics.Patches
{
    [HarmonyPatch(typeof(Gorillanalytics))]
    [HarmonyPatch("Start", MethodType.Normal)]
    internal class AnylticsPtch
    {
        private static void Prefix(Gorillanalytics __instance)
        {
            GameObject.Destroy(__instance.gameObject);
        }
    }
}
