namespace _1082003_Final
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxUseTransparency = new System.Windows.Forms.CheckBox();
            this.gbxTransparency = new System.Windows.Forms.GroupBox();
            this.rbtTextTransparency = new System.Windows.Forms.RadioButton();
            this.rbtBackTransparency = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxTransparency.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxUseTransparency
            // 
            this.cbxUseTransparency.AutoSize = true;
            this.cbxUseTransparency.Location = new System.Drawing.Point(49, 30);
            this.cbxUseTransparency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxUseTransparency.Name = "cbxUseTransparency";
            this.cbxUseTransparency.Size = new System.Drawing.Size(151, 24);
            this.cbxUseTransparency.TabIndex = 0;
            this.cbxUseTransparency.Text = "啟動鏤空效果";
            this.cbxUseTransparency.UseVisualStyleBackColor = true;
            this.cbxUseTransparency.CheckedChanged += new System.EventHandler(this.cbxUseTransparency_CheckedChanged);
            this.cbxUseTransparency.Click += new System.EventHandler(this.cbxUseTransparency_Click);
            // 
            // gbxTransparency
            // 
            this.gbxTransparency.Controls.Add(this.rbtBackTransparency);
            this.gbxTransparency.Controls.Add(this.rbtTextTransparency);
            this.gbxTransparency.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxTransparency.Location = new System.Drawing.Point(49, 86);
            this.gbxTransparency.Name = "gbxTransparency";
            this.gbxTransparency.Size = new System.Drawing.Size(282, 100);
            this.gbxTransparency.TabIndex = 1;
            this.gbxTransparency.TabStop = false;
            this.gbxTransparency.Text = "鏤空效果";
            // 
            // rbtTextTransparency
            // 
            this.rbtTextTransparency.AutoSize = true;
            this.rbtTextTransparency.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtTextTransparency.Location = new System.Drawing.Point(6, 45);
            this.rbtTextTransparency.Name = "rbtTextTransparency";
            this.rbtTextTransparency.Size = new System.Drawing.Size(110, 24);
            this.rbtTextTransparency.TabIndex = 0;
            this.rbtTextTransparency.TabStop = true;
            this.rbtTextTransparency.Text = "文字鏤空";
            this.rbtTextTransparency.UseVisualStyleBackColor = true;
            // 
            // rbtBackTransparency
            // 
            this.rbtBackTransparency.AutoSize = true;
            this.rbtBackTransparency.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtBackTransparency.Location = new System.Drawing.Point(150, 45);
            this.rbtBackTransparency.Name = "rbtBackTransparency";
            this.rbtBackTransparency.Size = new System.Drawing.Size(110, 24);
            this.rbtBackTransparency.TabIndex = 1;
            this.rbtBackTransparency.TabStop = true;
            this.rbtBackTransparency.Text = "背景鏤空";
            this.rbtBackTransparency.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(77, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 37);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 295);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxTransparency);
            this.Controls.Add(this.cbxUseTransparency);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "設定特殊效果";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbxTransparency.ResumeLayout(false);
            this.gbxTransparency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxUseTransparency;
        private System.Windows.Forms.GroupBox gbxTransparency;
        private System.Windows.Forms.RadioButton rbtBackTransparency;
        private System.Windows.Forms.RadioButton rbtTextTransparency;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}