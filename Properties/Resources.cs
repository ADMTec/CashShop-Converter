// Decompiled with JetBrains decompiler
// Type: MUConverter.Properties.Resources
// Assembly: MUConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE4A4DCB-8C0F-441B-8AC5-6D21D74D9F9B
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\Converters\CashShop\CashShop Converter.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MUConverter.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (MUConverter.Properties.Resources.resourceMan == null)
          MUConverter.Properties.Resources.resourceMan = new ResourceManager("MUConverter.Properties.Resources", typeof (MUConverter.Properties.Resources).Assembly);
        return MUConverter.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => MUConverter.Properties.Resources.resourceCulture;
      set => MUConverter.Properties.Resources.resourceCulture = value;
    }
  }
}
