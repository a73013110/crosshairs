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
        }

        // 點擊自訂顏色中的"說明"按鈕
        private void color_dialog_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("你TMD只要選擇你想要的準心顏色", "說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
