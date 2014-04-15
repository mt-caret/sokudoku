using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sokudoku
{
    public partial class Form1 : Form
    {
        string FullText, FormatText;
        double DelayTime;
        static Queue<string> TextQ;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "default.txt";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter =
                "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
                FullText = File.ReadAllText(ofd.FileName, System.Text.Encoding.GetEncoding("Shift_JIS"));
            else
                this.Close();

            FormatText = System.Text.RegularExpressions.Regex.Replace(
                FullText.Replace("\r", "").Replace("\n", "").Replace("　", ""),
                @"《.*?》 ", "");

            //MessageBox.Show(FormatText);

            TextQ = new Queue<string>(FormatText.Split(' '));
        }

        async Task ShowText()
        {
            var doc = azukiControl1.Document;
            while (TextQ.Count != 0)
            {
                await Task.Delay((int)DelayTime);
                var str = TextQ.Dequeue();
                str = ((str.Count() == 1) ? "　" : "") + str;
                var next = TextQ.Peek();
                if (next == "。" || next == "、" || str == "「" || next == "」")
                {
                    str = str + TextQ.Dequeue();
                }
                doc.Replace(str, 0, doc.Length);
            }
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            DelayTime = 60 / double.Parse(textBox.Text) * 1000;
            await ShowText();
        }
    }
}
