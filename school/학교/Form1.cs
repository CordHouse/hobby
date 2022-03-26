using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 학교
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {            
            _1학년 f1 = new _1학년();
            f1.Owner = this;
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2학년 f2 = new _2학년();
            f2.Owner = this;
            f2.Show();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            _3학년 f3 = new _3학년();
            f3.Owner = this;
            f3.Show();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            _4학년 f4 = new _4학년();
            f4.Owner = this;
            f4.Show();
        }
    }
}
