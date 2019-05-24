using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyu0524
{
    public partial class Form1 : Form
    {
        int vx = -5;
        int vy = -5;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
                vx = -vx;
            else if (label1.Left > this.Width - 50)  
                vx=-vx;

            if (label1.Top < 0)
                vy = -vy;
            else if (label1.Top > this.Height - 50) 
                vy = -vy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //開始時のlabel1の右端、下端の座標を表示する
            //MessageBox.Show("" + label1.Right);
            //MessageBox.Show("" + label1.Bottom);
        }
    }
}
