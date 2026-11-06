using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BepInEx;
using GoldDigger;
using HarmonyLib;
using UnityEngine;

[BepInPlugin("local.omc.japanese", "One Million Coins Japanese", "1.0.0")]
public sealed class JapaneseLocalization : BaseUnityPlugin
{
    internal static TranslationCatalog Catalog;
    internal static IReadOnlyList<GameLocalization.LanguageOption> Options;
    internal static Font JapaneseFont;
    private Harmony harmony;

    private void Awake()
    {
        try
        {
            string path = Path.Combine(Path.GetDirectoryName(Info.Location), "ja.json");
            Catalog = TranslationCatalog.FromJson(File.ReadAllText(path), "ja");
            if (Catalog.Count < 100) throw new Exception("Japanese catalog is empty or invalid");
            harmony = new Harmony("local.omc.japanese");
            harmony.PatchAll(typeof(JapaneseLocalization).Assembly);
            if (!PlayerPrefs.HasKey("local.omc.japanese.initialized"))
            {
                GameLocalization.Language = "ja";
                PlayerPrefs.SetInt("local.omc.japanese.initialized", 1);
                PlayerPrefs.Save();
            }
            Logger.LogInfo("Japanese localization ready: " + Catalog.Count + " entries; Continue = " + Catalog.Translate("Continue"));
        }
        catch (Exception ex) { Logger.LogError(ex); }
    }

    [HarmonyPatch(typeof(GameLocalization), "get_SupportedLanguages")]
    private static class LanguagesPatch
    {
        private static void Postfix(ref IReadOnlyList<GameLocalization.LanguageOption> __result)
        {
            if (Options == null)
            {
                var list = new List<GameLocalization.LanguageOption>(__result);
                ConstructorInfo ctor = typeof(GameLocalization.LanguageOption).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null,
                    new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) }, null);
                list.Add((GameLocalization.LanguageOption)ctor.Invoke(new object[] { "ja", "日本語", null, null }));
                Options = list.AsReadOnly();
            }
            __result = Options;
        }
    }

    [HarmonyPatch]
    private static class CatalogPatch
    {
        private static MethodBase TargetMethod() { return AccessTools.PropertyGetter(typeof(GameLocalization.LanguageOption), "Catalog"); }
        private static bool Prefix(GameLocalization.LanguageOption __instance, ref TranslationCatalog __result)
        {
            if (__instance.Id != "ja") return true;
            __result = Catalog;
            return false;
        }
    }

    [HarmonyPatch(typeof(LocalizationFonts), "ForText")]
    private static class FontPatch
    {
        private static bool Prefix(Font original, string text, FontStyle weight, ref Font __result)
        {
            bool japanese = false;
            if (text != null)
                foreach (char c in text)
                    if ((c >= '\u3040' && c <= '\u30ff') || (c >= '\u3400' && c <= '\u9fff') || (c >= '\uff00' && c <= '\uffef')) { japanese = true; break; }
            if (!japanese) return true;
            if (JapaneseFont == null)
            {
                JapaneseFont = Font.CreateDynamicFontFromOSFont(new string[] { "Meiryo", "Yu Gothic", "MS Gothic" }, 20);
                UnityEngine.Object.DontDestroyOnLoad(JapaneseFont);
            }
            if (JapaneseFont == null) return true;
            __result = JapaneseFont;
            return false;
        }
    }
}
