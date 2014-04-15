namespace Sokudoku
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            Sgry.Azuki.FontInfo fontInfo3 = new Sgry.Azuki.FontInfo();
            this.startButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.azukiControl1 = new Sgry.Azuki.WinForms.AzukiControl();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(197, 96);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 96);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(62, 19);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "語/分";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // azukiControl1
            // 
            this.azukiControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.azukiControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.azukiControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.azukiControl1.DrawingOption = ((Sgry.Azuki.DrawingOption)((Sgry.Azuki.DrawingOption.HighlightCurrentLine | Sgry.Azuki.DrawingOption.HighlightsMatchedBracket)));
            this.azukiControl1.DrawsEolCode = false;
            this.azukiControl1.DrawsFullWidthSpace = false;
            this.azukiControl1.DrawsTab = false;
            this.azukiControl1.FirstVisibleLine = 0;
            this.azukiControl1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            fontInfo3.Name = "MS UI Gothic";
            fontInfo3.Size = 48;
            fontInfo3.Style = System.Drawing.FontStyle.Regular;
            this.azukiControl1.FontInfo = fontInfo3;
            this.azukiControl1.ForeColor = System.Drawing.Color.Black;
            this.azukiControl1.Location = new System.Drawing.Point(0, 0);
            this.azukiControl1.Name = "azukiControl1";
            this.azukiControl1.ScrollPos = new System.Drawing.Point(0, 0);
            this.azukiControl1.ShowsDirtBar = false;
            this.azukiControl1.ShowsHScrollBar = false;
            this.azukiControl1.ShowsLineNumber = false;
            this.azukiControl1.ShowsVScrollBar = false;
            this.azukiControl1.Size = new System.Drawing.Size(284, 90);
            this.azukiControl1.TabIndex = 4;
            this.azukiControl1.ViewWidth = 4097;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.azukiControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 165);
            this.Name = "Form1";
            this.Text = "sokudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sgry.Azuki.WinForms.AzukiControl azukiControl1;
    }
}

