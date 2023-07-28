using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace RemoveAnalytics
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}
