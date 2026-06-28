using System;
using System.Runtime.InteropServices;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace TheOtherRoles.Modules;

public class BepInExUpdater : MonoBehaviour
{
    public const string RequiredBepInExVersion = "6.0.0-be.697+53625800b86f6c68751445248260edf0b27a71c2";
    public static bool UpdateRequired => false;

    public void Awake()
    {
        TheOtherRolesPlugin.Logger.LogMessage($"Expected BepInEx version: {RequiredBepInExVersion}");
        TheOtherRolesPlugin.Logger.LogMessage($"Detected BepInEx version: {Paths.BepInExVersion}");
    }

    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();
    [DllImport("user32.dll")]
    public static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);
    [DllImport("user32.dll")]
    public static extern int MessageBoxTimeout(IntPtr hwnd, String text, String title, uint type, Int16 wLanguageId, Int32 milliseconds);
}

[HarmonyPatch(typeof(SplashManager), nameof(SplashManager.Update))]
public static class StopLoadingMainMenu
{
    public static bool Prefix()
    {
        return !BepInExUpdater.UpdateRequired;
    }
}
