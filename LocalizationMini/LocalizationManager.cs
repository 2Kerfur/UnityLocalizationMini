using System;
using UnityEngine;

public class LocalizationManager
{
    static LocalizeTMP_Text[] texts;

    [Serializable]
    public enum Language
    { 
        None,
        ru,
        en
    }

    static Language CurrentLanguage = Language.None;

    public static Language GetCurrentLanguage()
    {
        return CurrentLanguage;
    }
    public static void ChangeLocale(Language language)
    {
        if (texts == null) texts = GameObject.FindObjectsOfType<LocalizeTMP_Text>(true);

        CurrentLanguage = language;
        foreach (LocalizeTMP_Text text in texts)
        {
            text.ChangeLocale(language);
        }
    }
    
}
