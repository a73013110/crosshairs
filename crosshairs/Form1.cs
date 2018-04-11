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
        }

        // 紀錄目前準心是否開啟
        private bool crosshair_on = false;
        // 準心開關點擊事件
        private void switch_btn_Click(object sender, EventArgs e)
        {
            if (crosshair_on)   // 目前開啟狀態
            {
                crosshair_on = false;
                switch_btn.BackgroundImage = Properties.Resources.switch_off_icon;
            }
            else    // 目前關閉狀態
            {
                crosshair_on = true;
                switch_btn.BackgroundImage = Properties.Resources.switch_on_icon;
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

        // 紀錄準心種類
        private string type_tag = "0";
        // 準心種類radio btn事件
        private void type_radio_btn_Click(object sender, EventArgs e)
        {
            type_tag = ((RadioButton)sender).Tag.ToString();
            Console.WriteLine("{0}", Enum.Parse(typeof(TYPE_TAG), type_tag));
        }

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
    }
}
