// Decompiled with JetBrains decompiler
// Type: MUConverter.Program
// Assembly: MUConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE4A4DCB-8C0F-441B-8AC5-6D21D74D9F9B
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\Converters\CashShop\CashShop Converter.exe

using System;
using System.Windows.Forms;

namespace MUConverter
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
