using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crosshairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cd = new crosshairs_display(this);
        }

        // 準心開關---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄目前準心是否開啟
        private bool crosshair_on = false;
        // 讓外部Class能夠取得是否開啟準心
        public bool get_crosshair_on() { return crosshair_on; }
        // 準心視窗
        private crosshairs_display cd = null;
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
            }
        }

        // 紀錄目前準心快捷鍵, 預設為Home鍵(值為36)
        private int keyvalue = 36;
        // 準心快捷鍵設定
        private void hot_switch_btn_Click(object sender, EventArgs e)
        {
            set_crosshairs_hotkey_dialog set_hotkey = new set_crosshairs_hotkey_dialog();
            set_hotkey.ShowDialog();
            keyvalue = set_hotkey.keyvalue;
            set_hotkey.Dispose();
            KeysConverter kc = new KeysConverter();
            hot_switch_textarea.Text = kc.ConvertToString(keyvalue);
        }
        
        // 準心種類---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄準心種類
        private string type_tag = "0";
        // 準心種類radio btn事件
        private void type_radio_btn_Click(object sender, EventArgs e)
        {
            type_tag = ((RadioButton)sender).Tag.ToString();
            Console.WriteLine("{0}", Enum.Parse(typeof(TYPE_TAG), type_tag));
        }

        // 準心顏色---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄顏色
        private string color_tag = "0";
        // 準心種類radio btn事件
        private void color_radio_btn_Click(object sender, EventArgs e)
        {
            color_tag = ((RadioButton)sender).Tag.ToString();
            Console.WriteLine("{0}", Enum.Parse(typeof(COLOR_TAG), color_tag));
        }

        // 點擊自訂顏色
        private void custom_label_Click(object sender, EventArgs e)
        {
            color_dialog.ShowDialog();
            custom_label.Text = "";
            custom_label.AutoSize = false;
            custom_label.BackColor = color_dialog.Color;
            custom_label.Width = 24;
            custom_radio_btn.Checked = true;
        }

        // 點擊自訂顏色中的"說明"按鈕
        private void color_dialog_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("你TMD只要選擇你想要的準心顏色", "說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 進階設定---------------------------------------------------------------------------------------------------------------------------------------------------

        // 紀錄線寬
        private int line_width = 3;
        public int get_line_width() { return line_width; }
        // 紀錄線長/半徑
        private int line_len = 30;
        public int get_line_len() { return line_len; }
        // 紀錄線寬
        private int line_transparency = 200;
        public int get_line_transparency() { return line_transparency; }

        // 設定Value
        private void line_width_bar_Scroll(object sender, EventArgs e)
        {
            line_width = line_width_bar.Value;
            bar_Scroll();
        }

        private void line_len_bar_Scroll(object sender, EventArgs e)
        {
            line_len = line_len_bar.Value;
            bar_Scroll();
        }

        private void line_transparency_bar_Scroll(object sender, EventArgs e)
        {
            line_transparency = line_transparency_bar.Value;
            bar_Scroll();
        }

        // 所有Bar Scroll更新準心事件都用此function處理
        private void bar_Scroll()
        {
            if (crosshair_on)   // 目前開啟狀態
            {
                Console.WriteLine("{0} {1} {2}", line_width, line_len, line_transparency);
                cd.repaint();
            }
        }

    }
}
