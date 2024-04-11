// Decompiled with JetBrains decompiler
// Type: Properties.Settings
// Assembly: NoTrollBombs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4BA9A07F-8B24-4BFD-8319-697D1130D3F4
// Assembly location: C:\Users\user\Downloads\NoTrollBombs.dll

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
