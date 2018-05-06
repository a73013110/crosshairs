using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Gma.System.MouseKeyHook;

namespace crosshairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cd = new Crosshairs_display(this);
        }

        // 組態檔案
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private void Form1_Load(object sender, EventArgs e)
        {
            // 若組態檔遺失, 則使用預設值
            try
            {
                KEY_VALUE = int.Parse(ConfigurationManager.AppSettings["KEY_VALUE"]);
                set_key_value();
                SubcribeHook(); // 掛載鍵盤滑鼠Hook
                TYPE_TAG = ConfigurationManager.AppSettings["TYPE_TAG"];
                set_type_tag();
                COLOR_TAG = ConfigurationManager.AppSettings["COLOR_TAG"];
                set_color_tag();
                CUSTOM_IMAGE = ConfigurationManager.AppSettings["CUSTOM_IMAGE"];
                set_custom_image();
                CUSTOM_COLOR = string_to_rgb(ConfigurationManager.AppSettings["CUSTOM_COLOR"]);
                set_custom_color();
                LOCATION_HORIZONTAL = int.Parse(ConfigurationManager.AppSettings["LOCATION_HORIZONTAL"]);
                set_location_horizontal();
                LOCATION_VERTICAL = int.Parse(ConfigurationManager.AppSettings["LOCATION_VERTICAL"]);
                set_location_vertical();
                LINE_WIDTH = int.Parse(ConfigurationManager.AppSettings["LINE_WIDTH"]);
                set_line_width();
                LINE_LEN = int.Parse(ConfigurationManager.AppSettings["LINE_LEN"]);
                set_line_len();
                LINE_TRANSPARENCY = int.Parse(ConfigurationManager.AppSettings["LINE_TRANSPARENCY"]);
                set_line_transparency();
            }
            catch (Exception) { }
        }

        // 當程式關閉時, 保存組態
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 後面註解為該值在程式裡的型別(先移除再新增)
            config.AppSettings.Settings.Remove("KEY_VALUE");    // 鍵盤快捷鍵
            config.AppSettings.Settings.Add("KEY_VALUE", KEY_VALUE.ToString()); // int
            Unsubscribe();  // 解除鍵盤滑鼠Hook
            config.AppSettings.Settings.Remove("TYPE_TAG"); // 準心種類
            config.AppSettings.Settings.Add("TYPE_TAG", TYPE_TAG); // string
            config.AppSettings.Settings.Remove("CUSTOM_IMAGE"); // 自訂準心
            config.AppSettings.Settings.Add("CUSTOM_IMAGE", CUSTOM_IMAGE); // string
            config.AppSettings.Settings.Remove("COLOR_TAG");    // 準心顏色
            config.AppSettings.Settings.Add("COLOR_TAG", COLOR_TAG); // string
            config.AppSettings.Settings.Remove("CUSTOM_COLOR"); // 自訂顏色
            config.AppSettings.Settings.Add("CUSTOM_COLOR", CUSTOM_COLOR.R + "," + CUSTOM_COLOR.G + "," + CUSTOM_COLOR.B); // COLOR
            config.AppSettings.Settings.Remove("LOCATION_HORIZONTAL");  // 準心水平位置
            config.AppSettings.Settings.Add("LOCATION_HORIZONTAL", LOCATION_HORIZONTAL.ToString()); // int
            config.AppSettings.Settings.Remove("LOCATION_VERTICAL");    // 準心垂直位置
            config.AppSettings.Settings.Add("LOCATION_VERTICAL", LOCATION_VERTICAL.ToString()); // int
            config.AppSettings.Settings.Remove("LINE_WIDTH");   // 準心線寬
            config.AppSettings.Settings.Add("LINE_WIDTH", LINE_WIDTH.ToString()); // int
            config.AppSettings.Settings.Remove("LINE_LEN"); // 準心線長
            config.AppSettings.Settings.Add("LINE_LEN", LINE_LEN.ToString()); // int
            config.AppSettings.Settings.Remove("LINE_TRANSPARENCY");    // 準心透明度
            config.AppSettings.Settings.Add("LINE_TRANSPARENCY", LINE_TRANSPARENCY.ToString()); // int

            config.Save(ConfigurationSaveMode.Modified);
        }

        private Color string_to_rgb(string rgb)
        {
            string[] split = rgb.Split(',');
            return Color.FromArgb(int.Parse(split[0]), int.Parse(split[1]), int.Parse(split[2]));
        }

        // 快捷鍵----------------------------------------------------------------------------------------------------------------------------------------------------
        private IKeyboardMouseEvents global_hook;
        private void SubcribeHook()
        {
            global_hook = Hook.GlobalEvents();
            global_hook.MouseDownExt += GlobalHookMouseDownExt;
            global_hook.KeyDown += GlobalHookKeyDown;
        }
        private void Unsubscribe()
        {
            global_hook.MouseDownExt -= GlobalHookMouseDownExt;
            global_hook.KeyDown -= GlobalHookKeyDown;
            global_hook.Dispose();
        }
        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == MouseButtons.XButton2)
            {
                this.switch_btn_Click(this, null);
            }
        }
        private void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == KEY_VALUE)
            {
                this.switch_btn_Click(this, null);
            }
        }

        // 準心開關---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄目前準心是否開啟
        private bool crosshair_on = false;        
        public bool get_crosshair_on() { return crosshair_on; }// 讓外部Class能夠取得是否開啟準心
        // 準心視窗
        private Crosshairs_display cd = null;
        // 準心開關點擊事件
        private void switch_btn_Click(object sender, EventArgs e)
        {
            if (crosshair_on)   // 目前開啟狀態
            {
                crosshair_on = false;
                switch_btn.BackgroundImage = Properties.Resources.switch_off_icon;

                // 關閉準心視窗
                cd.Hide();
            }
            else    // 目前關閉狀態
            {
                crosshair_on = true;
                switch_btn.BackgroundImage = Properties.Resources.switch_on_icon;

                cd.repaint();
                // 開啟準心視窗
                cd.Show();
                // 將這個視窗移到最前面
                this.BringToFront();
            }
        }

        // 紀錄目前準心快捷鍵, 預設為Home鍵(值為36)
        private int KEY_VALUE = 36;
        private void set_key_value() { hot_switch_textarea.Text = new KeysConverter().ConvertToString(KEY_VALUE); } // 以KEY_VALUE更新介面顯示
        // 準心快捷鍵設定
        private void hot_switch_btn_Click(object sender, EventArgs e)
        {
            Set_crosshairs_hotkey_dialog set_hotkey = new Set_crosshairs_hotkey_dialog();
            set_hotkey.ShowDialog();
            KEY_VALUE = set_hotkey.get_keyvalue();
            set_hotkey.Dispose();
            hot_switch_textarea.Text = new KeysConverter().ConvertToString(KEY_VALUE);
        }
        
        // 準心種類---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄準心種類
        private string TYPE_TAG = "0";
        public string get_type_tag() { return TYPE_TAG; }
        private void set_type_tag() { ((RadioButton)type_panel.Controls[int.Parse(TYPE_TAG)]).Checked = true; } // 以TYPE_TAG更新介面顯示
        // 準心種類radio btn事件
        private void type_radio_btn_Click(object sender, EventArgs e)
        {
            TYPE_TAG = ((RadioButton)sender).Tag.ToString();
            Console.WriteLine("{0}", Enum.Parse(typeof(TYPE_TAG), TYPE_TAG));
            cd.repaint();
        }

        // 紀錄準心圖片
        private string CUSTOM_IMAGE = "";
        public string get_custom_image() { return CUSTOM_IMAGE; }
        private void set_custom_image() // 以CUSTOM_IMAGE更新介面顯示
        {
            if (File.Exists(CUSTOM_IMAGE))
            {
                Bitmap image = new Bitmap(CUSTOM_IMAGE);
                Console.WriteLine(image.ToString());
                image = new Bitmap(image, custom_type_label.Height * image.Width / image.Height, custom_type_label.Height);
                custom_type_label.Image = image;
                custom_type_label.Text = "";
            }
        }
        // 開啟準心圖片
        private void custom_type_label_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            CUSTOM_IMAGE = openFileDialog.FileName;
            set_custom_image();
            custom_type_radio_btn.Checked = true;
            this.type_radio_btn_Click(custom_type_radio_btn, e);   // 透過此觸發Radio Btn事件
        }

        // 準心顏色---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄顏色
        private string COLOR_TAG = "0";
        private void set_color_tag() // 以COLOR_TAG更新介面顯示
        {
            foreach(var btn in color_panel.Controls)
            {
                if (btn.GetType().Equals(typeof(RadioButton)) && ((RadioButton)btn).Tag.Equals(COLOR_TAG))
                {
                    ((RadioButton)btn).Checked = true;
                    break;
                }
            }
        }
        // 準心種類radio btn事件
        private void color_radio_btn_Click(object sender, EventArgs e)
        {
            COLOR_TAG = ((RadioButton)sender).Tag.ToString();
            Console.WriteLine("{0}", Enum.Parse(typeof(COLOR_TAG), COLOR_TAG));
            cd.repaint();
        }

        // 紀錄自訂顏色
        private Color CUSTOM_COLOR = Color.FromArgb(0, 0, 0);
        private void set_custom_color() { custom_color_label.BackColor = CUSTOM_COLOR; } // 以CUSTOM_COLOR更新介面顯示
        // 點擊自訂顏色
        private void custom_color_label_Click(object sender, EventArgs e)
        {
            color_dialog.ShowDialog();
            custom_color_label.BackColor = color_dialog.Color;
            custom_color_radio_btn.Checked = true;
            CUSTOM_COLOR = color_dialog.Color;
            if (CUSTOM_COLOR.Equals(Color.White)) MessageBox.Show("不支援白色準心\r\n欲使用白色, 請隨機選擇顏色後, 再將透明度調至最左", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.color_radio_btn_Click(custom_type_radio_btn, e);   // 透過此觸發Radio Btn事件
        }

        // 點擊自訂顏色中的"說明"按鈕
        private void color_dialog_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("你TMD只要選擇你想要的準心顏色", "說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //供外部class取得目前準心顏色
        public Color get_color()
        {
            if (int.Parse(COLOR_TAG) < 3)
            {
                string[] rgb = { "0", "0", "0" };   // 先創建字串陣列表示RGB
                rgb[int.Parse(COLOR_TAG)] = "255";  // 將Color Tag的顏色值設滿
                return string_to_rgb(string.Join(",", rgb));    // 先將RGB陣列結合後, 再將String轉為Color
            }
            else    // 自訂顏色
            {
                return CUSTOM_COLOR;
            }
        }

        // 準心位置---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄準心位移值
        private int LOCATION_HORIZONTAL = 0;
        public int get_location_horizontal() { return LOCATION_HORIZONTAL; }
        private void set_location_horizontal() { location_horizontal_bar.Value = LOCATION_HORIZONTAL; }    // 以LOCATION_HORIZONTAL更新介面顯示
        private int LOCATION_VERTICAL = 0;
        public int get_location_vertical() { return LOCATION_VERTICAL; }
        private void set_location_vertical() { location_vertical_bar.Value = LOCATION_VERTICAL; }    // 以LOCATION_VERTICAL更新介面顯示

        private void location_horizontal_bar_Scroll(object sender, EventArgs e)
        {
            LOCATION_HORIZONTAL = location_horizontal_bar.Value;
            location_bar_scroll();
        }

        private void location_vertical_bar_Scroll(object sender, EventArgs e)
        {
            LOCATION_VERTICAL = location_vertical_bar.Value;
            location_bar_scroll();
        }

        private void location_bar_scroll()
        {
            if (crosshair_on)   // 目前開啟狀態
            {
                cd.repaint();
            }
        }

        // 進階設定---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄線寬
        private int LINE_WIDTH = 3;
        public int get_line_width() { return LINE_WIDTH; }
        private void set_line_width() { line_width_bar.Value = LINE_WIDTH; }    // 以LINE_WIDTH更新介面顯示
        // 紀錄線長/半徑
        private int LINE_LEN = 30;
        public int get_line_len() { return LINE_LEN; }
        private void set_line_len() { line_len_bar.Value = LINE_LEN; }    // 以LINE_LEN更新介面顯示
        // 紀錄線寬
        private int LINE_TRANSPARENCY = 200;
        public int get_line_transparency() { return LINE_TRANSPARENCY; }
        private void set_line_transparency() { line_transparency_bar.Value = LINE_TRANSPARENCY; }    // 以LINE_TRANSPARENCY更新介面顯示

        // 設定Value
        private void line_width_bar_Scroll(object sender, EventArgs e)
        {
            LINE_WIDTH = line_width_bar.Value;
            advance_bar_Scroll();
        }

        private void line_len_bar_Scroll(object sender, EventArgs e)
        {
            LINE_LEN = line_len_bar.Value;
            advance_bar_Scroll();
        }

        private void line_transparency_bar_Scroll(object sender, EventArgs e)
        {
            LINE_TRANSPARENCY = line_transparency_bar.Value;
            advance_bar_Scroll();
        }

        // 所有Bar Scroll更新準心事件都用此function處理
        private void advance_bar_Scroll()
        {
            if (crosshair_on)   // 目前開啟狀態
            {
                //Console.WriteLine("{0} {1} {2}", LINE_WIDTH, LINE_LEN, LINE_TRANSPARENCY);
                cd.repaint();
            }
        }
    }
}
