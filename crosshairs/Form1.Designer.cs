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
            this.custom_type_radio_btn = new System.Windows.Forms.RadioButton();
            this.custom_type_label = new System.Windows.Forms.Label();
            this.color_box = new System.Windows.Forms.GroupBox();
            this.color_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.red_radio_btn = new System.Windows.Forms.RadioButton();
            this.red_label = new System.Windows.Forms.Label();
            this.green_radio_btn = new System.Windows.Forms.RadioButton();
            this.green_label = new System.Windows.Forms.Label();
            this.blue_radio_btn = new System.Windows.Forms.RadioButton();
            this.blue_label = new System.Windows.Forms.Label();
            this.custom_color_radio_btn = new System.Windows.Forms.RadioButton();
            this.custom_color_label = new System.Windows.Forms.Label();
            this.color_dialog = new System.Windows.Forms.ColorDialog();
            this.switch_box = new System.Windows.Forms.GroupBox();
            this.switch_btn = new System.Windows.Forms.Button();
            this.hot_switch_box = new System.Windows.Forms.GroupBox();
            this.hot_switch_textarea = new System.Windows.Forms.TextBox();
            this.hot_switch_label = new System.Windows.Forms.Label();
            this.hot_switch_btn = new System.Windows.Forms.Button();
            this.advance_box = new System.Windows.Forms.GroupBox();
            this.advance_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.line_width_bar = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.line_len_bar = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.line_transparency_bar = new System.Windows.Forms.TrackBar();
            this.location_box = new System.Windows.Forms.GroupBox();
            this.location_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.location_horizontal_bar = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.location_vertical_bar = new System.Windows.Forms.TrackBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.type_box.SuspendLayout();
            this.type_panel.SuspendLayout();
            this.color_box.SuspendLayout();
            this.color_panel.SuspendLayout();
            this.switch_box.SuspendLayout();
            this.hot_switch_box.SuspendLayout();
            this.advance_box.SuspendLayout();
            this.advance_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_width_bar)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_len_bar)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_transparency_bar)).BeginInit();
            this.location_box.SuspendLayout();
            this.location_panel.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.location_horizontal_bar)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.location_vertical_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // type_box
            // 
            this.type_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type_box.Controls.Add(this.type_panel);
            this.type_box.Location = new System.Drawing.Point(14, 103);
            this.type_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.type_box.Name = "type_box";
            this.type_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.type_box.Size = new System.Drawing.Size(420, 51);
            this.type_box.TabIndex = 0;
            this.type_box.TabStop = false;
            this.type_box.Text = "準心種類";
            // 
            // type_panel
            // 
            this.type_panel.AutoSize = true;
            this.type_panel.Controls.Add(this.cross_radio_btn);
            this.type_panel.Controls.Add(this.dot_radio_btn);
            this.type_panel.Controls.Add(this.circle_radio_btn);
            this.type_panel.Controls.Add(this.custom_type_radio_btn);
            this.type_panel.Controls.Add(this.custom_type_label);
            this.type_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_panel.Location = new System.Drawing.Point(3, 20);
            this.type_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.type_panel.Name = "type_panel";
            this.type_panel.Size = new System.Drawing.Size(414, 27);
            this.type_panel.TabIndex = 0;
            // 
            // cross_radio_btn
            // 
            this.cross_radio_btn.AutoSize = true;
            this.cross_radio_btn.Checked = true;
            this.cross_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cross_radio_btn.Location = new System.Drawing.Point(3, 4);
            this.cross_radio_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cross_radio_btn.Name = "cross_radio_btn";
            this.cross_radio_btn.Size = new System.Drawing.Size(50, 20);
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
            this.dot_radio_btn.Location = new System.Drawing.Point(59, 4);
            this.dot_radio_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dot_radio_btn.Name = "dot_radio_btn";
            this.dot_radio_btn.Size = new System.Drawing.Size(50, 20);
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
            this.circle_radio_btn.Location = new System.Drawing.Point(115, 4);
            this.circle_radio_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.circle_radio_btn.Name = "circle_radio_btn";
            this.circle_radio_btn.Size = new System.Drawing.Size(50, 20);
            this.circle_radio_btn.TabIndex = 2;
            this.circle_radio_btn.Tag = "2";
            this.circle_radio_btn.Text = "全息";
            this.circle_radio_btn.UseVisualStyleBackColor = true;
            this.circle_radio_btn.Click += new System.EventHandler(this.type_radio_btn_Click);
            // 
            // custom_type_radio_btn
            // 
            this.custom_type_radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.custom_type_radio_btn.AutoSize = true;
            this.custom_type_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_type_radio_btn.Location = new System.Drawing.Point(171, 4);
            this.custom_type_radio_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom_type_radio_btn.Name = "custom_type_radio_btn";
            this.custom_type_radio_btn.Size = new System.Drawing.Size(14, 20);
            this.custom_type_radio_btn.TabIndex = 3;
            this.custom_type_radio_btn.Tag = "3";
            this.custom_type_radio_btn.UseVisualStyleBackColor = true;
            this.custom_type_radio_btn.Click += new System.EventHandler(this.type_radio_btn_Click);
            // 
            // custom_type_label
            // 
            this.custom_type_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.custom_type_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.custom_type_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_type_label.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.custom_type_label.Location = new System.Drawing.Point(189, 5);
            this.custom_type_label.Margin = new System.Windows.Forms.Padding(1, 5, 9, 5);
            this.custom_type_label.MinimumSize = new System.Drawing.Size(0, 17);
            this.custom_type_label.Name = "custom_type_label";
            this.custom_type_label.Size = new System.Drawing.Size(34, 18);
            this.custom_type_label.TabIndex = 7;
            this.custom_type_label.Text = "自訂";
            this.custom_type_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.custom_type_label.Click += new System.EventHandler(this.custom_type_label_Click);
            // 
            // color_box
            // 
            this.color_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color_box.Controls.Add(this.color_panel);
            this.color_box.Location = new System.Drawing.Point(14, 158);
            this.color_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color_box.Name = "color_box";
            this.color_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color_box.Size = new System.Drawing.Size(420, 51);
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
            this.color_panel.Controls.Add(this.custom_color_radio_btn);
            this.color_panel.Controls.Add(this.custom_color_label);
            this.color_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_panel.Location = new System.Drawing.Point(3, 20);
            this.color_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(414, 27);
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
            this.red_radio_btn.Location = new System.Drawing.Point(3, 4);
            this.red_radio_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.red_radio_btn.Name = "red_radio_btn";
            this.red_radio_btn.Size = new System.Drawing.Size(14, 19);
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
            this.red_label.Location = new System.Drawing.Point(21, 5);
            this.red_label.Margin = new System.Windows.Forms.Padding(1, 5, 9, 5);
            this.red_label.MinimumSize = new System.Drawing.Size(2, 17);
            this.red_label.Name = "red_label";
            this.red_label.Size = new System.Drawing.Size(28, 17);
            this.red_label.TabIndex = 3;
            // 
            // green_radio_btn
            // 
            this.green_radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.green_radio_btn.AutoSize = true;
            this.green_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.green_radio_btn.Location = new System.Drawing.Point(61, 4);
            this.green_radio_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.green_radio_btn.Name = "green_radio_btn";
            this.green_radio_btn.Size = new System.Drawing.Size(14, 19);
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
            this.green_label.Location = new System.Drawing.Point(79, 5);
            this.green_label.Margin = new System.Windows.Forms.Padding(1, 5, 9, 5);
            this.green_label.MinimumSize = new System.Drawing.Size(2, 17);
            this.green_label.Name = "green_label";
            this.green_label.Size = new System.Drawing.Size(28, 17);
            this.green_label.TabIndex = 4;
            // 
            // blue_radio_btn
            // 
            this.blue_radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.blue_radio_btn.AutoSize = true;
            this.blue_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blue_radio_btn.Location = new System.Drawing.Point(119, 4);
            this.blue_radio_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blue_radio_btn.Name = "blue_radio_btn";
            this.blue_radio_btn.Size = new System.Drawing.Size(14, 19);
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
            this.blue_label.Location = new System.Drawing.Point(137, 5);
            this.blue_label.Margin = new System.Windows.Forms.Padding(1, 5, 9, 5);
            this.blue_label.MinimumSize = new System.Drawing.Size(2, 17);
            this.blue_label.Name = "blue_label";
            this.blue_label.Size = new System.Drawing.Size(28, 17);
            this.blue_label.TabIndex = 4;
            // 
            // custom_color_radio_btn
            // 
            this.custom_color_radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.custom_color_radio_btn.AutoSize = true;
            this.custom_color_radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_color_radio_btn.Location = new System.Drawing.Point(177, 4);
            this.custom_color_radio_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom_color_radio_btn.Name = "custom_color_radio_btn";
            this.custom_color_radio_btn.Size = new System.Drawing.Size(14, 19);
            this.custom_color_radio_btn.TabIndex = 5;
            this.custom_color_radio_btn.Tag = "3";
            this.custom_color_radio_btn.UseVisualStyleBackColor = true;
            this.custom_color_radio_btn.Click += new System.EventHandler(this.color_radio_btn_Click);
            // 
            // custom_color_label
            // 
            this.custom_color_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.custom_color_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.custom_color_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_color_label.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.custom_color_label.Location = new System.Drawing.Point(195, 5);
            this.custom_color_label.Margin = new System.Windows.Forms.Padding(1, 5, 9, 5);
            this.custom_color_label.MinimumSize = new System.Drawing.Size(0, 17);
            this.custom_color_label.Name = "custom_color_label";
            this.custom_color_label.Size = new System.Drawing.Size(34, 17);
            this.custom_color_label.TabIndex = 6;
            this.custom_color_label.Text = "自訂";
            this.custom_color_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.custom_color_label.Click += new System.EventHandler(this.custom_color_label_Click);
            // 
            // color_dialog
            // 
            this.color_dialog.ShowHelp = true;
            this.color_dialog.HelpRequest += new System.EventHandler(this.color_dialog_HelpRequest);
            // 
            // switch_box
            // 
            this.switch_box.Controls.Add(this.switch_btn);
            this.switch_box.Location = new System.Drawing.Point(14, 16);
            this.switch_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.switch_box.Name = "switch_box";
            this.switch_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.switch_box.Size = new System.Drawing.Size(93, 79);
            this.switch_box.TabIndex = 2;
            this.switch_box.TabStop = false;
            this.switch_box.Text = "準心開關";
            // 
            // switch_btn
            // 
            this.switch_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switch_btn.BackgroundImage")));
            this.switch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_btn.FlatAppearance.BorderSize = 0;
            this.switch_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.switch_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.switch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_btn.Location = new System.Drawing.Point(7, 16);
            this.switch_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.switch_btn.Name = "switch_btn";
            this.switch_btn.Size = new System.Drawing.Size(78, 60);
            this.switch_btn.TabIndex = 0;
            this.switch_btn.UseVisualStyleBackColor = true;
            this.switch_btn.Click += new System.EventHandler(this.switch_btn_Click);
            // 
            // hot_switch_box
            // 
            this.hot_switch_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hot_switch_box.Controls.Add(this.hot_switch_textarea);
            this.hot_switch_box.Controls.Add(this.hot_switch_label);
            this.hot_switch_box.Controls.Add(this.hot_switch_btn);
            this.hot_switch_box.Location = new System.Drawing.Point(115, 16);
            this.hot_switch_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hot_switch_box.Name = "hot_switch_box";
            this.hot_switch_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hot_switch_box.Size = new System.Drawing.Size(318, 79);
            this.hot_switch_box.TabIndex = 3;
            this.hot_switch_box.TabStop = false;
            this.hot_switch_box.Text = "準心開關快捷鍵";
            // 
            // hot_switch_textarea
            // 
            this.hot_switch_textarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hot_switch_textarea.Location = new System.Drawing.Point(111, 44);
            this.hot_switch_textarea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hot_switch_textarea.Multiline = true;
            this.hot_switch_textarea.Name = "hot_switch_textarea";
            this.hot_switch_textarea.ReadOnly = true;
            this.hot_switch_textarea.Size = new System.Drawing.Size(200, 23);
            this.hot_switch_textarea.TabIndex = 4;
            this.hot_switch_textarea.Text = "Home";
            // 
            // hot_switch_label
            // 
            this.hot_switch_label.Location = new System.Drawing.Point(108, 21);
            this.hot_switch_label.Name = "hot_switch_label";
            this.hot_switch_label.Size = new System.Drawing.Size(203, 16);
            this.hot_switch_label.TabIndex = 3;
            this.hot_switch_label.Text = "目前快捷鍵：";
            // 
            // hot_switch_btn
            // 
            this.hot_switch_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hot_switch_btn.BackgroundImage")));
            this.hot_switch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hot_switch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hot_switch_btn.FlatAppearance.BorderSize = 0;
            this.hot_switch_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hot_switch_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hot_switch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hot_switch_btn.Location = new System.Drawing.Point(9, 21);
            this.hot_switch_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hot_switch_btn.Name = "hot_switch_btn";
            this.hot_switch_btn.Size = new System.Drawing.Size(97, 55);
            this.hot_switch_btn.TabIndex = 1;
            this.hot_switch_btn.UseVisualStyleBackColor = true;
            this.hot_switch_btn.Click += new System.EventHandler(this.hot_switch_btn_Click);
            // 
            // advance_box
            // 
            this.advance_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advance_box.Controls.Add(this.advance_panel);
            this.advance_box.Location = new System.Drawing.Point(14, 289);
            this.advance_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advance_box.Name = "advance_box";
            this.advance_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advance_box.Size = new System.Drawing.Size(420, 116);
            this.advance_box.TabIndex = 2;
            this.advance_box.TabStop = false;
            this.advance_box.Text = "進階設定";
            // 
            // advance_panel
            // 
            this.advance_panel.Controls.Add(this.flowLayoutPanel1);
            this.advance_panel.Controls.Add(this.flowLayoutPanel2);
            this.advance_panel.Controls.Add(this.flowLayoutPanel3);
            this.advance_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advance_panel.Location = new System.Drawing.Point(3, 20);
            this.advance_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advance_panel.Name = "advance_panel";
            this.advance_panel.Size = new System.Drawing.Size(414, 92);
            this.advance_panel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.line_width_bar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 40);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "粗細";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line_width_bar
            // 
            this.line_width_bar.AutoSize = false;
            this.line_width_bar.Location = new System.Drawing.Point(44, 3);
            this.line_width_bar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.line_width_bar.Minimum = 1;
            this.line_width_bar.Name = "line_width_bar";
            this.line_width_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.line_width_bar.Size = new System.Drawing.Size(97, 30);
            this.line_width_bar.TabIndex = 0;
            this.line_width_bar.Value = 3;
            this.line_width_bar.Scroll += new System.EventHandler(this.line_width_bar_Scroll);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.line_len_bar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(157, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(254, 40);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "長度/半徑";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line_len_bar
            // 
            this.line_len_bar.AutoSize = false;
            this.line_len_bar.Location = new System.Drawing.Point(75, 3);
            this.line_len_bar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.line_len_bar.Maximum = 50;
            this.line_len_bar.Minimum = 1;
            this.line_len_bar.Name = "line_len_bar";
            this.line_len_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.line_len_bar.Size = new System.Drawing.Size(172, 30);
            this.line_len_bar.TabIndex = 0;
            this.line_len_bar.Value = 30;
            this.line_len_bar.Scroll += new System.EventHandler(this.line_len_bar_Scroll);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.line_transparency_bar);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 49);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(408, 40);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "透明度";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line_transparency_bar
            // 
            this.line_transparency_bar.AutoSize = false;
            this.line_transparency_bar.Location = new System.Drawing.Point(58, 3);
            this.line_transparency_bar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.line_transparency_bar.Maximum = 255;
            this.line_transparency_bar.Minimum = 1;
            this.line_transparency_bar.Name = "line_transparency_bar";
            this.line_transparency_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.line_transparency_bar.Size = new System.Drawing.Size(343, 30);
            this.line_transparency_bar.TabIndex = 0;
            this.line_transparency_bar.Value = 200;
            this.line_transparency_bar.Scroll += new System.EventHandler(this.line_transparency_bar_Scroll);
            // 
            // location_box
            // 
            this.location_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.location_box.Controls.Add(this.location_panel);
            this.location_box.Location = new System.Drawing.Point(14, 213);
            this.location_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.location_box.Name = "location_box";
            this.location_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.location_box.Size = new System.Drawing.Size(420, 72);
            this.location_box.TabIndex = 4;
            this.location_box.TabStop = false;
            this.location_box.Text = "準心位置";
            // 
            // location_panel
            // 
            this.location_panel.Controls.Add(this.flowLayoutPanel6);
            this.location_panel.Controls.Add(this.flowLayoutPanel5);
            this.location_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.location_panel.Location = new System.Drawing.Point(3, 20);
            this.location_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.location_panel.Name = "location_panel";
            this.location_panel.Size = new System.Drawing.Size(414, 48);
            this.location_panel.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel6.Controls.Add(this.label5);
            this.flowLayoutPanel6.Controls.Add(this.location_horizontal_bar);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(201, 40);
            this.flowLayoutPanel6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "水平";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // location_horizontal_bar
            // 
            this.location_horizontal_bar.AutoSize = false;
            this.location_horizontal_bar.Location = new System.Drawing.Point(44, 3);
            this.location_horizontal_bar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.location_horizontal_bar.Maximum = 100;
            this.location_horizontal_bar.Minimum = -100;
            this.location_horizontal_bar.Name = "location_horizontal_bar";
            this.location_horizontal_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.location_horizontal_bar.Size = new System.Drawing.Size(150, 30);
            this.location_horizontal_bar.TabIndex = 0;
            this.location_horizontal_bar.Scroll += new System.EventHandler(this.location_horizontal_bar_Scroll);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel5.Controls.Add(this.label4);
            this.flowLayoutPanel5.Controls.Add(this.location_vertical_bar);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(210, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(201, 40);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "垂直";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // location_vertical_bar
            // 
            this.location_vertical_bar.AutoSize = false;
            this.location_vertical_bar.Location = new System.Drawing.Point(44, 3);
            this.location_vertical_bar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.location_vertical_bar.Maximum = 100;
            this.location_vertical_bar.Minimum = -100;
            this.location_vertical_bar.Name = "location_vertical_bar";
            this.location_vertical_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.location_vertical_bar.Size = new System.Drawing.Size(150, 30);
            this.location_vertical_bar.TabIndex = 0;
            this.location_vertical_bar.Scroll += new System.EventHandler(this.location_vertical_bar_Scroll);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "圖片檔 (*.jpg;*.png)|*.jpg;*.png";
            this.openFileDialog.Title = "開啟客製化準心圖片";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 414);
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.advance_box);
            this.Controls.Add(this.hot_switch_box);
            this.Controls.Add(this.switch_box);
            this.Controls.Add(this.color_box);
            this.Controls.Add(this.type_box);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "準心";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.type_box.ResumeLayout(false);
            this.type_box.PerformLayout();
            this.type_panel.ResumeLayout(false);
            this.type_panel.PerformLayout();
            this.color_box.ResumeLayout(false);
            this.color_panel.ResumeLayout(false);
            this.color_panel.PerformLayout();
            this.switch_box.ResumeLayout(false);
            this.hot_switch_box.ResumeLayout(false);
            this.hot_switch_box.PerformLayout();
            this.advance_box.ResumeLayout(false);
            this.advance_panel.ResumeLayout(false);
            this.advance_panel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.line_width_bar)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.line_len_bar)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.line_transparency_bar)).EndInit();
            this.location_box.ResumeLayout(false);
            this.location_panel.ResumeLayout(false);
            this.location_panel.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.location_horizontal_bar)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.location_vertical_bar)).EndInit();
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
        private System.Windows.Forms.RadioButton custom_color_radio_btn;
        private System.Windows.Forms.Label custom_color_label;
        private System.Windows.Forms.ColorDialog color_dialog;
        private System.Windows.Forms.GroupBox switch_box;
        private System.Windows.Forms.Button switch_btn;
        private System.Windows.Forms.GroupBox hot_switch_box;
        private System.Windows.Forms.Button hot_switch_btn;
        private System.Windows.Forms.Label hot_switch_label;
        private System.Windows.Forms.TextBox hot_switch_textarea;
        private System.Windows.Forms.GroupBox advance_box;
        private System.Windows.Forms.FlowLayoutPanel advance_panel;
        private System.Windows.Forms.TrackBar line_width_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar line_len_bar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar line_transparency_bar;
        private System.Windows.Forms.GroupBox location_box;
        private System.Windows.Forms.FlowLayoutPanel location_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar location_horizontal_bar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar location_vertical_bar;
        private System.Windows.Forms.RadioButton custom_type_radio_btn;
        private System.Windows.Forms.Label custom_type_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

