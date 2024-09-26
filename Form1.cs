// Decompiled with JetBrains decompiler
// Type: MUConverter.Form1
// Assembly: MUConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE4A4DCB-8C0F-441B-8AC5-6D21D74D9F9B
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\Converters\CashShop\CashShop Converter.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MUConverter
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private RadioButton radItemInfo;
    private RadioButton radItemList;
    private Button button1;
    private Panel panel1;
    private Panel panel2;
    private GroupBox groupBox1;
    private Label label1;
    private RichTextBox txtConvert;

    public Form1() => this.InitializeComponent();

    private string ConvertText(string itemType, string text)
    {
      StringBuilder stringBuilder = new StringBuilder();
      string str = text;
      char[] chArray = new char[1]{ '\n' };
      foreach (string input in str.Split(chArray))
      {
        string[] strArray = new Regex("\\s{2,}").Replace(input, " ").Replace("\t", " ").Split(' ');
        if (itemType.Equals("ItemInfo"))
          stringBuilder.AppendLine(string.Format("<Item GUID=\"{0}\" ID=\"{1}\" Cat=\"{2}\" Index=\"{3}\" Level=\"{4}\" Durability=\"{5}\" Skill=\"{6}\" Luck=\"{7}\" Option=\"{8}\" Exc=\"{9}\" Set=\"{10}\" SocketCount=\"{11}\" Element=\"0\" Type=\"{12}\" Duration=\"{13}\" />", (object) strArray[0], (object) strArray[1], (object) strArray[2], (object) strArray[3], (object) strArray[4], (object) strArray[5], (object) strArray[6], (object) strArray[7], (object) strArray[8], (object) strArray[9], (object) strArray[10], (object) strArray[11], (object) strArray[12], (object) strArray[13]));
        else if (itemType.Equals("ItemList"))
          stringBuilder.AppendLine(string.Format("<Item GUID=\"{0}\" iIndex=\"{1}\" iSubIndex=\"{2}\" OptionSelect=\"{3}\" PackageID=\"{4}\" CoinType=\"{5}\" CoinValue=\"{6}\" UniqueID1=\"{7}\" UniqueID2=\"{8}\" ShopCategory=\"{9}\" GPRewardValue=\"{10}\" CanBuy=\"{11}\" CanGift=\"{12}\" RandomItemSelect=\"0\" />", (object) strArray[0], (object) strArray[1], (object) strArray[2], (object) strArray[3], (object) strArray[4], (object) strArray[5], (object) strArray[6], (object) strArray[7], (object) strArray[8], (object) strArray[9], (object) strArray[10], (object) strArray[11], (object) strArray[12]));
      }
      return stringBuilder.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      StringBuilder stringBuilder = new StringBuilder();
      try
      {
        if (this.radItemInfo.Checked)
        {
          this.txtConvert.Text = this.ConvertText("ItemInfo", this.txtConvert.Text);
        }
        else
        {
          if (!this.radItemList.Checked)
            return;
          this.txtConvert.Text = this.ConvertText("ItemList", this.txtConvert.Text);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("erro!: " + ex.Message);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.radItemInfo = new RadioButton();
      this.radItemList = new RadioButton();
      this.button1 = new Button();
      this.panel1 = new Panel();
      this.label1 = new Label();
      this.panel2 = new Panel();
      this.groupBox1 = new GroupBox();
      this.txtConvert = new RichTextBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.radItemInfo.AutoSize = true;
      this.radItemInfo.Location = new Point(12, 12);
      this.radItemInfo.Name = "radItemInfo";
      this.radItemInfo.Size = new Size(63, 17);
      this.radItemInfo.TabIndex = 2;
      this.radItemInfo.TabStop = true;
      this.radItemInfo.Text = "ItemInfo";
      this.radItemInfo.UseVisualStyleBackColor = true;
      this.radItemList.AutoSize = true;
      this.radItemList.Location = new Point(81, 12);
      this.radItemList.Name = "radItemList";
      this.radItemList.Size = new Size(61, 17);
      this.radItemList.TabIndex = 3;
      this.radItemList.TabStop = true;
      this.radItemList.Text = "ItemList";
      this.radItemList.UseVisualStyleBackColor = true;
      this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button1.AutoSize = true;
      this.button1.Location = new Point(379, 11);
      this.button1.Name = "button1";
      this.button1.Size = new Size(138, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Convert";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.radItemInfo);
      this.panel1.Controls.Add((Control) this.radItemList);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(851, 38);
      this.panel1.TabIndex = 6;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(758, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(81, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "TitaoYamamoto";
      this.panel2.Controls.Add((Control) this.button1);
      this.panel2.Dock = DockStyle.Bottom;
      this.panel2.Location = new Point(0, 467);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(851, 46);
      this.panel2.TabIndex = 8;
      this.groupBox1.Controls.Add((Control) this.txtConvert);
      this.groupBox1.Dock = DockStyle.Fill;
      this.groupBox1.Location = new Point(0, 38);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(851, 429);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Text Convert";
      this.txtConvert.Dock = DockStyle.Fill;
      this.txtConvert.Location = new Point(3, 16);
      this.txtConvert.Name = "txtConvert";
      this.txtConvert.Size = new Size(845, 410);
      this.txtConvert.TabIndex = 0;
      this.txtConvert.Text = "";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(851, 513);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "MuConvert";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
