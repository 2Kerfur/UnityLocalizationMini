using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent (typeof(TMP_Text))]
public class LocalizeTMP_Text : MonoBehaviour
{
    [SerializeField] private List<Locale> locales = new List<Locale>();

    [Serializable]
    public struct Locale
    {
        public LocalizationManager.Language language;
        public string text;
    }

    private TMP_Text m_Text;
    public void ChangeLocale(LocalizationManager.Language language)
    {
        m_Text = GetComponent<TMP_Text>();
        Locale locale = FindLocaleWithLanguage(language);
        if(locale.language != LocalizationManager.Language.None)
        {
            if (locale.text != null)
            {
                m_Text.text = locale.text;
            }
            else Debug.LogError("Locale has no text on GameObject: " + name);
        }
        else Debug.LogError("Locale with that language not assigned on GameObject: " + name);
    }
    private Locale FindLocaleWithLanguage(LocalizationManager.Language language)
    {
        foreach (Locale locale in locales)
        {
            if(locale.language == language)
                return locale;
        }
        return new Locale();
    }
}
