# UnityLocalizationMini

![AppVeyor](https://img.shields.io/badge/build-passing-brightgreen)

## About
This project made to simplify small mobile/browser games localization.
It is simple and lightweight.
Tested on Unity 2020.3 (Windows).

## Setup
1. Import unitypackage.
2. Rebuld C# project (it might be rebuild automatically).

## How To Use
In LocalizationManager.cs file add languages you need to enum.
```cs
public enum Language
{ 
    None,
    ru, en, br, //Add more here
}
```
Add LocalizeTMP_Text component to your text object and add Locales

![изображение](https://github.com/2Kerfur/UnityLocalizationMini/assets/73479696/f2706592-5e42-4f57-bece-86cbffa479b5)

Select locale on game start (Required)
```cs
LocalizationManager.ChangeLocale(LocalizationManager.Language.en);
```
Change it anywhere with the same code
