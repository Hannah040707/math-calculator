namespace _1082003_Final
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.特效ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.公式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一元二次方程式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbxData = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.到N的總和ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.公式ToolStripMenuItem,
            this.特效ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(502, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 特效ToolStripMenuItem
            // 
            this.特效ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFont,
            this.MenuBackColor,
            this.MenuForeColor,
            this.MenuTransparent});
            this.特效ToolStripMenuItem.Name = "特效ToolStripMenuItem";
            this.特效ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.特效ToolStripMenuItem.Text = "特效";
            // 
            // MenuFont
            // 
            this.MenuFont.Name = "MenuFont";
            this.MenuFont.Size = new System.Drawing.Size(216, 26);
            this.MenuFont.Text = "字型";
            this.MenuFont.Click += new System.EventHandler(this.MenuFont_Click);
            // 
            // MenuBackColor
            // 
            this.MenuBackColor.Name = "MenuBackColor";
            this.MenuBackColor.Size = new System.Drawing.Size(216, 26);
            this.MenuBackColor.Text = "背景顏色";
            this.MenuBackColor.Click += new System.EventHandler(this.MenuBackColor_Click);
            // 
            // MenuForeColor
            // 
            this.MenuForeColor.Name = "MenuForeColor";
            this.MenuForeColor.Size = new System.Drawing.Size(216, 26);
            this.MenuForeColor.Text = "文字顏色";
            this.MenuForeColor.Click += new System.EventHandler(this.MenuForeColor_Click);
            // 
            // MenuTransparent
            // 
            this.MenuTransparent.Name = "MenuTransparent";
            this.MenuTransparent.Size = new System.Drawing.Size(216, 26);
            this.MenuTransparent.Text = "鏤空效果";
            this.MenuTransparent.Click += new System.EventHandler(this.MenuTransparent_Click);
            // 
            // 公式ToolStripMenuItem
            // 
            this.公式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一元二次方程式ToolStripMenuItem,
            this.到N的總和ToolStripMenuItem});
            this.公式ToolStripMenuItem.Name = "公式ToolStripMenuItem";
            this.公式ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.公式ToolStripMenuItem.Text = "公式";
            // 
            // 一元二次方程式ToolStripMenuItem
            // 
            this.一元二次方程式ToolStripMenuItem.Name = "一元二次方程式ToolStripMenuItem";
            this.一元二次方程式ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.一元二次方程式ToolStripMenuItem.Text = "一元二次方程式";
            this.一元二次方程式ToolStripMenuItem.Click += new System.EventHandler(this.一元二次方程式ToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 488);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbxData
            // 
            this.lbxData.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxData.FormattingEnabled = true;
            this.lbxData.ItemHeight = 20;
            this.lbxData.Location = new System.Drawing.Point(12, 32);
            this.lbxData.Name = "lbxData";
            this.lbxData.Size = new System.Drawing.Size(478, 424);
            this.lbxData.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextFont,
            this.ContextBackColor,
            this.ContextForeColor,
            this.ContextTransparent});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 100);
            // 
            // ContextFont
            // 
            this.ContextFont.Name = "ContextFont";
            this.ContextFont.Size = new System.Drawing.Size(210, 24);
            this.ContextFont.Text = "字型";
            // 
            // ContextBackColor
            // 
            this.ContextBackColor.Name = "ContextBackColor";
            this.ContextBackColor.Size = new System.Drawing.Size(210, 24);
            this.ContextBackColor.Text = "背景顏色";
            // 
            // ContextForeColor
            // 
            this.ContextForeColor.Name = "ContextForeColor";
            this.ContextForeColor.Size = new System.Drawing.Size(210, 24);
            this.ContextForeColor.Text = "文字顏色";
            // 
            // ContextTransparent
            // 
            this.ContextTransparent.Name = "ContextTransparent";
            this.ContextTransparent.Size = new System.Drawing.Size(210, 24);
            this.ContextTransparent.Text = "鏤空效果";
            // 
            // 到N的總和ToolStripMenuItem
            // 
            this.到N的總和ToolStripMenuItem.Name = "到N的總和ToolStripMenuItem";
            this.到N的總和ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.到N的總和ToolStripMenuItem.Text = "1到N的總和";
            this.到N的總和ToolStripMenuItem.Click += new System.EventHandler(this.到N的總和ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 544);
            this.Controls.Add(this.lbxData);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "簡易數學公式計算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 特效ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFont;
        private System.Windows.Forms.ToolStripMenuItem MenuBackColor;
        private System.Windows.Forms.ToolStripMenuItem MenuForeColor;
        private System.Windows.Forms.ToolStripMenuItem MenuTransparent;
        private System.Windows.Forms.ToolStripMenuItem 公式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一元二次方程式ToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbxData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextFont;
        private System.Windows.Forms.ToolStripMenuItem ContextBackColor;
        private System.Windows.Forms.ToolStripMenuItem ContextForeColor;
        private System.Windows.Forms.ToolStripMenuItem ContextTransparent;
        private System.Windows.Forms.ToolStripMenuItem 到N的總和ToolStripMenuItem;
    }
}

