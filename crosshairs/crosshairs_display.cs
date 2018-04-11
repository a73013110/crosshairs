using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace crosshairs
{
    public partial class crosshairs_display : Form
    {
        public crosshairs_display(Form1 main_form)
        {
            InitializeComponent();
            this.main_form = main_form;
        }

        private Form1 main_form = null;
        private int LINE_WIDTH = 3;
        private int LINE_LEN = 30;
        private int LINE_TRANSPARENCY = 200;

        // Paint事件
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            LINE_WIDTH = main_form.get_line_width();
            LINE_LEN = main_form.get_line_len();
            LINE_TRANSPARENCY = main_form.get_line_transparency();

            if (main_form.get_crosshair_on())
            {
                draw_cross(e);
            }
        }

        // 重新上色, 讓外部Class使用
        public void repaint()
        {
            this.Invalidate();
        }

        // 畫十字準心
        private void draw_cross(PaintEventArgs e)
        {
            int CENTER_X = Width / 2;
            int CENTER_Y = Height / 2;
            Pen pen = new Pen(Color.FromArgb(LINE_TRANSPARENCY, 255, 0, 0), LINE_WIDTH);
            e.Graphics.DrawLine(pen, CENTER_X, CENTER_Y - LINE_LEN, CENTER_X, CENTER_Y + LINE_LEN);
            e.Graphics.DrawLine(pen, CENTER_X - LINE_LEN, CENTER_Y, CENTER_X + LINE_LEN, CENTER_Y);
        }
    }
}
