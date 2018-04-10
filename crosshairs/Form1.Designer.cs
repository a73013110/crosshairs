namespace crosshairs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.type_box = new System.Windows.Forms.GroupBox();
            this.type_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.cross_radio_btn = new System.Windows.Forms.RadioButton();
            this.dot_radio_btn = new System.Windows.Forms.RadioButton();
            this.circle_radio_btn = new System.Windows.Forms.RadioButton();
            this.color_box = new System.Windows.Forms.GroupBox();
            this.color_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.red_radio_btn = new System.Windows.Forms.RadioButton();
            this.red_label = new System.Windows.Forms.Label();
            this.green_radio_btn = new System.Windows.Forms.RadioButton();
            this.green_label = new System.Windows.Forms.Label();
            this.blue_radio_btn = new System.Windows.Forms.RadioButton();
            this.blue_label = new System.Windows.Forms.Label();
            this.custom_radio_btn = new System.Windows.Forms.RadioButton();
            this.custom_label = new System.Windows.Forms.Label();
            this.color_dialog = new System.Windows.Forms.ColorDialog();
            this.type_box.SuspendLayout();
            this.type_panel.SuspendLayout();
            this.color_box.SuspendLayout();
            this.color_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // type_box
            // 
            this.type_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type_box.Controls.Add(this.type_panel);
            this.type_box.Location = new System.Drawing.Point(12, 12);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(360, 41);
            this.type_box.TabIndex = 0;
            this.type_box.TabStop = false;
            this.type_box.Text = "準心種類";
            // 
            // type_panel
            // 
            this.type_panel.Controls.Add(this.cross_radio_btn);
            this.type_panel.Controls.Add(this.dot_radio_btn);
            this.type_panel.Controls.Add(this.circle_radio_btn);
            this.type_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_panel.Location = new System.Drawing.Point(3, 18);
            this.type_panel.Name = "type_panel";
            this.type_panel.Size = new System.Drawing.Size(354, 20);
            this.type_panel.TabIndex = 0;
            // 
            // cross_radio_btn
            // 
            this.cross_radio_btn.AutoSize = true;
            this.cross_radio_btn.Checked = true;
            this.cross_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cross_radio_btn.Location = new System.Drawing.Point(3, 3);
            this.cross_radio_btn.Name = "cross_radio_btn";
            this.cross_radio_btn.Size = new System.Drawing.Size(47, 16);
            this.cross_radio_btn.TabIndex = 0;
            this.cross_radio_btn.TabStop = true;
            this.cross_radio_btn.Tag = "0";
            this.cross_radio_btn.Text = "十字";
            this.cross_radio_btn.UseVisualStyleBackColor = true;
            this.cross_radio_btn.Click += new System.EventHandler(this.type_radio_btn_Click);
            // 
            // dot_radio_btn
            // 
            this.dot_radio_btn.AutoSize = true;
            this.dot_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dot_radio_btn.Location = new System.Drawing.Point(56, 3);
            this.dot_radio_btn.Name = "dot_radio_btn";
            this.dot_radio_btn.Size = new System.Drawing.Size(47, 16);
            this.dot_radio_btn.TabIndex = 1;
            this.dot_radio_btn.Tag = "1";
            this.dot_radio_btn.Text = "圓點";
            this.dot_radio_btn.UseVisualStyleBackColor = true;
            this.dot_radio_btn.Click += new System.EventHandler(this.type_radio_btn_Click);
            // 
            // circle_radio_btn
            // 
            this.circle_radio_btn.AutoSize = true;
            this.circle_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circle_radio_btn.Location = new System.Drawing.Point(109, 3);
            this.circle_radio_btn.Name = "circle_radio_btn";
            this.circle_radio_btn.Size = new System.Drawing.Size(47, 16);
            this.circle_radio_btn.TabIndex = 2;
            this.circle_radio_btn.Tag = "2";
            this.circle_radio_btn.Text = "全息";
            this.circle_radio_btn.UseVisualStyleBackColor = true;
            this.circle_radio_btn.Click += new System.EventHandler(this.type_radio_btn_Click);
            // 
            // color_box
            // 
            this.color_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color_box.Controls.Add(this.color_panel);
            this.color_box.Location = new System.Drawing.Point(12, 59);
            this.color_box.Name = "color_box";
            this.color_box.Size = new System.Drawing.Size(360, 41);
            this.color_box.TabIndex = 1;
            this.color_box.TabStop = false;
            this.color_box.Text = "準心顏色";
            // 
            // color_panel
            // 
            this.color_panel.Controls.Add(this.red_radio_btn);
            this.color_panel.Controls.Add(this.red_label);
            this.color_panel.Controls.Add(this.green_radio_btn);
            this.color_panel.Controls.Add(this.green_label);
            this.color_panel.Controls.Add(this.blue_radio_btn);
            this.color_panel.Controls.Add(this.blue_label);
            this.color_panel.Controls.Add(this.custom_radio_btn);
            this.color_panel.Controls.Add(this.custom_label);
            this.color_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_panel.Location = new System.Drawing.Point(3, 18);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(354, 20);
            this.color_panel.TabIndex = 0;
            // 
            // red_radio_btn
            // 
            this.red_radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.red_radio_btn.AutoSize = true;
            this.red_radio_btn.Checked = true;
            this.red_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.red_radio_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.red_radio_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.red_radio_btn.Location = new System.Drawing.Point(3, 3);
            this.red_radio_btn.Name = "red_radio_btn";
            this.red_radio_btn.Size = new System.Drawing.Size(14, 16);
            this.red_radio_btn.TabIndex = 0;
            this.red_radio_btn.TabStop = true;
            this.red_radio_btn.Tag = "0";
            this.red_radio_btn.UseVisualStyleBackColor = false;
            this.red_radio_btn.Click += new System.EventHandler(this.color_radio_btn_Click);
            // 
            // red_label
            // 
            this.red_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.red_label.BackColor = System.Drawing.Color.Red;
            this.red_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.red_label.Location = new System.Drawing.Point(21, 4);
            this.red_label.Margin = new System.Windows.Forms.Padding(1, 4, 8, 4);
            this.red_label.Name = "red_label";
            this.red_label.Size = new System.Drawing.Size(24, 14);
            this.red_label.TabIndex = 3;
            // 
            // green_radio_btn
            // 
            this.green_radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.green_radio_btn.AutoSize = true;
            this.green_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.green_radio_btn.Location = new System.Drawing.Point(56, 3);
            this.green_radio_btn.Name = "green_radio_btn";
            this.green_radio_btn.Size = new System.Drawing.Size(14, 16);
            this.green_radio_btn.TabIndex = 1;
            this.green_radio_btn.Tag = "1";
            this.green_radio_btn.UseVisualStyleBackColor = true;
            this.green_radio_btn.Click += new System.EventHandler(this.color_radio_btn_Click);
            // 
            // green_label
            // 
            this.green_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.green_label.BackColor = System.Drawing.Color.Lime;
            this.green_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green_label.Location = new System.Drawing.Point(74, 4);
            this.green_label.Margin = new System.Windows.Forms.Padding(1, 4, 8, 4);
            this.green_label.Name = "green_label";
            this.green_label.Size = new System.Drawing.Size(24, 14);
            this.green_label.TabIndex = 4;
            // 
            // blue_radio_btn
            // 
            this.blue_radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.blue_radio_btn.AutoSize = true;
            this.blue_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blue_radio_btn.Location = new System.Drawing.Point(109, 3);
            this.blue_radio_btn.Name = "blue_radio_btn";
            this.blue_radio_btn.Size = new System.Drawing.Size(14, 16);
            this.blue_radio_btn.TabIndex = 2;
            this.blue_radio_btn.Tag = "2";
            this.blue_radio_btn.UseVisualStyleBackColor = true;
            this.blue_radio_btn.Click += new System.EventHandler(this.color_radio_btn_Click);
            // 
            // blue_label
            // 
            this.blue_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.blue_label.BackColor = System.Drawing.Color.Blue;
            this.blue_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blue_label.Location = new System.Drawing.Point(127, 4);
            this.blue_label.Margin = new System.Windows.Forms.Padding(1, 4, 8, 4);
            this.blue_label.Name = "blue_label";
            this.blue_label.Size = new System.Drawing.Size(24, 14);
            this.blue_label.TabIndex = 4;
            // 
            // custom_radio_btn
            // 
            this.custom_radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.custom_radio_btn.AutoSize = true;
            this.custom_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_radio_btn.Location = new System.Drawing.Point(162, 3);
            this.custom_radio_btn.Name = "custom_radio_btn";
            this.custom_radio_btn.Size = new System.Drawing.Size(14, 16);
            this.custom_radio_btn.TabIndex = 5;
            this.custom_radio_btn.Tag = "3";
            this.custom_radio_btn.UseVisualStyleBackColor = true;
            this.custom_radio_btn.Click += new System.EventHandler(this.color_radio_btn_Click);
            // 
            // custom_label
            // 
            this.custom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.custom_label.AutoSize = true;
            this.custom_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custom_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_label.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.custom_label.Location = new System.Drawing.Point(180, 4);
            this.custom_label.Margin = new System.Windows.Forms.Padding(1, 4, 8, 4);
            this.custom_label.Name = "custom_label";
            this.custom_label.Size = new System.Drawing.Size(31, 14);
            this.custom_label.TabIndex = 6;
            this.custom_label.Text = "自訂";
            this.custom_label.Click += new System.EventHandler(this.custom_label_Click);
            // 
            // color_dialog
            // 
            this.color_dialog.ShowHelp = true;
            this.color_dialog.HelpRequest += new System.EventHandler(this.color_dialog_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.color_box);
            this.Controls.Add(this.type_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "準心";
            this.type_box.ResumeLayout(false);
            this.type_panel.ResumeLayout(false);
            this.type_panel.PerformLayout();
            this.color_box.ResumeLayout(false);
            this.color_panel.ResumeLayout(false);
            this.color_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox type_box;
        private System.Windows.Forms.FlowLayoutPanel type_panel;
        private System.Windows.Forms.RadioButton cross_radio_btn;
        private System.Windows.Forms.RadioButton dot_radio_btn;
        private System.Windows.Forms.RadioButton circle_radio_btn;
        private System.Windows.Forms.GroupBox color_box;
        private System.Windows.Forms.FlowLayoutPanel color_panel;
        private System.Windows.Forms.RadioButton red_radio_btn;
        private System.Windows.Forms.RadioButton green_radio_btn;
        private System.Windows.Forms.RadioButton blue_radio_btn;
        private System.Windows.Forms.Label red_label;
        private System.Windows.Forms.Label green_label;
        private System.Windows.Forms.Label blue_label;
        private System.Windows.Forms.RadioButton custom_radio_btn;
        private System.Windows.Forms.Label custom_label;
        private System.Windows.Forms.ColorDialog color_dialog;
    }
}

