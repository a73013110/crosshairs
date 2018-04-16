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
    public partial class Set_crosshairs_hotkey_dialog : Form
    {
        public Set_crosshairs_hotkey_dialog()
        {
            InitializeComponent();
        }

        private int keyvalue = 36;
        public int get_keyvalue() { return keyvalue; }
        private void set_crosshairs_hotkey_dialog_KeyDown(object sender, KeyEventArgs e)
        {
            keyvalue = e.KeyValue;
            this.Close();
        }

        private string message = "請按下鍵盤任意鍵";
        private void timer_Tick(object sender, EventArgs e)
        {
            if(message_label.Text.Length < 11)
            {
                message_label.Text = message_label.Text + ".";
            }
            else
            {
                message_label.Text = message;
            }
        }
    }
}
