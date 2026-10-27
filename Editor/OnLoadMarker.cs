using System.IO;
using UnityEditor;
using UnityEngine;

// [pentest marker] Executes automatically when the editor loads this package
// (asset import / domain reload). Harmless proof of execution.
[InitializeOnLoad]
public static class OnLoadMarker
{
    static OnLoadMarker()
    {
        File.WriteAllText("/tmp/UVCHAIN7DCB34C1_upm_onload",
            "UPM package com.uvchain.marker executed on load @ " + System.DateTime.Now);
        Debug.Log("[UVCHAIN] OnLoadMarker ran — package code executed in editor.");
    }
}
