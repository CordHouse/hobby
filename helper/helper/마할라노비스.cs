using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace helper
{
    public partial class 마할라노비스 : Form
    {
        public 마할라노비스()
        {
            InitializeComponent();
            t1.Text = "0"; t6.Text = "0";
            t2.Text = "0"; t7.Text = "0";
            t3.Text = "0"; t8.Text = "0";
            t4.Text = "0"; 
            t5.Text = "0"; 
            t9.Text = "0"; t10.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] x = new double[3];
            double[] y = new double[3];
            double[] pw = new double[2];
            double[] rhdqns = new double[4];
            double[] result = new double[8];

            x[0] = Convert.ToDouble(t1.Text);
            x[1] = Convert.ToDouble(t3.Text);

            y[0] = Convert.ToDouble(t2.Text);
            y[1] = Convert.ToDouble(t4.Text);

            pw[0] = Convert.ToDouble(t9.Text);
            pw[1] = Convert.ToDouble(t10.Text);

            rhdqns[0] = Convert.ToDouble(t5.Text);
            rhdqns[1] = Convert.ToDouble(t6.Text);
            rhdqns[2] = Convert.ToDouble(t7.Text);
            rhdqns[3] = Convert.ToDouble(t8.Text);

            result[0] = (pw[0] - x[0]);
            result[1] = (pw[1] - y[0]);

            result[2] = ((result[0] * result[0] * rhdqns[0]) + (result[1] * result[1] * rhdqns[1]));
            result[3] = ((result[0] * result[0] * rhdqns[2]) + (result[1] * result[1] * rhdqns[3]));

            result[4] = (pw[0] - x[1]);
            result[5] = (pw[1] - y[1]);

            result[6] = ((result[4] * result[4] * rhdqns[0]) + (result[5] * result[5] * rhdqns[1]));
            result[7] = ((result[4] * result[4] * rhdqns[2]) + (result[5] * result[5] * rhdqns[3]));

            rufrhk.Text = "u1에 대한 마할라노비스 거리 = " + Math.Sqrt((result[2] + result[3]))
                + "\r\n\r\nu2에 대한 마할라노비스 거리 = " + Math.Sqrt((result[6] + result[7]));

        }
    }
}
