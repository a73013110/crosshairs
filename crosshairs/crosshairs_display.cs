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
using System.IO;

namespace crosshairs
{
    public partial class Crosshairs_display : Form
    {
        public Crosshairs_display(Form1 main_form)
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.main_form = main_form;
        }

        private Form1 main_form = null;
        // 參數設定
        private int TYPE;
        private int LINE_WIDTH;
        private int LINE_LEN;
        private int LINE_TRANSPARENCY;

        // 定義畫筆
        private Pen pen;

        // 定義畫面中心點
        private int CENTER_X;
        private int CENTER_Y;

        // 重新上色, 讓外部Class使用
        public void repaint()
        {
            this.Invalidate();
        }

        // Paint事件
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
      
            // 若開啟準心開關
            if (main_form.get_crosshair_on())
            {
                // 取得使用者參數
                set_parameter();

                if (TYPE == (int)TYPE_TAG.CROSS)    // 畫十字準心
                {
                    draw_cross(e);
                }
                else if (TYPE == (int)TYPE_TAG.DOT) // 畫紅點準心
                {
                    draw_dot(e);
                }
                else if (TYPE == (int)TYPE_TAG.CIRCLE) // 畫全息準心
                {
                    draw_circle(e);
                }
                else if (TYPE == (int)TYPE_TAG.CUSTOM) // 畫客製準心
                {
                    draw_custom(e);
                }
            }
        }

        // 取得使用者設定的參數
        private void set_parameter()
        {
            TYPE = int.Parse(main_form.get_type_tag()); // 這邊將TYPE轉成int
            LINE_WIDTH = main_form.get_line_width();
            LINE_LEN = main_form.get_line_len();
            LINE_TRANSPARENCY = main_form.get_line_transparency();
            pen = new Pen(Color.FromArgb(LINE_TRANSPARENCY, main_form.get_color()), LINE_WIDTH);
            CENTER_X = Width / 2 + main_form.get_location_horizontal();
            CENTER_Y = Height / 2 + main_form.get_location_vertical();
        }

        // 畫十字準心
        private void draw_cross(PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, CENTER_X, CENTER_Y - LINE_LEN, CENTER_X, CENTER_Y + LINE_LEN);
            e.Graphics.DrawLine(pen, CENTER_X - LINE_LEN, CENTER_Y, CENTER_X + LINE_LEN, CENTER_Y);
        }

        // 畫圓點準心
        private void draw_dot(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, CENTER_X - LINE_LEN / 2, CENTER_Y - LINE_LEN / 2, LINE_LEN, LINE_LEN);
        }

        // 畫全息準心
        private void draw_circle(PaintEventArgs e)
        {

        }

        // 畫客製準心
        private void draw_custom(PaintEventArgs e)
        {
            if (File.Exists(main_form.get_custom_image()))
            {
                Image img = Image.FromFile(main_form.get_custom_image());
                int resize_time = Math.Max(img.Width / LINE_LEN, img.Height / LINE_LEN);
                int width = img.Width / resize_time;
                int height = img.Height / resize_time;
                e.Graphics.DrawImage(img, CENTER_X - width / 2, CENTER_Y - height / 2, width, height);
            }
        }
    }
}
