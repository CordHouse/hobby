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
    public partial class 베이시언 : Form
    {
        double[] x = new double[3];
        double[] y = new double[3];
        double[] pw = new double[2];
        double[] rhdqns = new double[4];
        double[] result = new double[6];

        public 베이시언()
        {
            InitializeComponent();
            t1.Text = "0"; t6.Text = "0";
            t2.Text = "0"; t7.Text = "0";
            t3.Text = "0"; t8.Text = "0";
            t4.Text = "0"; t11.Text = "0";
            t5.Text = "0"; t12.Text = "0";
            t9.Text = " "; t10.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (t9.Text != " " && t10.Text != " ")
            {
                x[0] = Convert.ToDouble(t1.Text);
                x[1] = Convert.ToDouble(t3.Text);
                x[2] = Convert.ToDouble(t11.Text);

                y[0] = Convert.ToDouble(t2.Text);
                y[1] = Convert.ToDouble(t4.Text);
                y[2] = Convert.ToDouble(t12.Text);

                pw[0] = Convert.ToDouble(t9.Text);
                pw[1] = Convert.ToDouble(t10.Text);

                rhdqns[0] = Convert.ToDouble(t5.Text);
                rhdqns[1] = Convert.ToDouble(t6.Text);
                rhdqns[2] = Convert.ToDouble(t7.Text);
                rhdqns[3] = Convert.ToDouble(t8.Text);

                result[0] = (rhdqns[0] * (x[0] - x[1])) + (rhdqns[1] * (y[0] - y[1]));
                result[1] = (rhdqns[2] * (x[0] - x[1])) + (rhdqns[3] * (y[0] - y[1]));

                result[2] = -0.5 * ((x[0] * x[0] * rhdqns[0]) + (y[0] * y[0] * rhdqns[1]));
                result[3] = -0.5 * ((x[0] * x[0] * rhdqns[2]) + (y[0] * y[0] * rhdqns[3]));

                result[4] = 0.5 * ((x[1] * x[1] * rhdqns[0]) + (y[1] * y[1] * rhdqns[1]));
                result[5] = 0.5 * ((x[1] * x[1] * rhdqns[2]) + (y[1] * y[1] * rhdqns[3]));

                rufrhk.Text = "g12(x) = <( " + rhdqns[0] + ", " + rhdqns[1] + " ) ( " + rhdqns[2] + ", " + rhdqns[3] + " )> * ( " + (x[0] - x[1]) + ", " + (y[0] - y[1]) + " )T " +
                    "* ( X1, X2 )T \r\n\r\n + " + " ( " + pw[0] + " - " + pw[1] + "- 1/2 * " + "( " + x[0] + ", " + y[0] + " ) * < (" + rhdqns[0] + ", " + rhdqns[1] + ")(" + rhdqns[2] + ", " + rhdqns[3] + ") > * (" + x[0] + ", " + y[0] + " )T" +
                    "\r\n\r\n + 1/2 * " + "( " + x[1] + ", " + y[1] + " ) * < (" + rhdqns[0] + ", " + rhdqns[1] + ")(" + rhdqns[2] + ", " + rhdqns[3] + ") > * (" + x[1] + ", " + y[1] + " )T" +

                    "\r\n\r\ng12(x) => " + result[0] + "X1 + " + result[1] + "X2 + " + (((pw[0] - pw[1]) + (result[2] + result[4]) + (result[3] + result[5])));
            }
            else
            {
                x[0] = Convert.ToDouble(t1.Text);
                x[1] = Convert.ToDouble(t3.Text);
                x[2] = Convert.ToDouble(t11.Text);

                y[0] = Convert.ToDouble(t2.Text);
                y[1] = Convert.ToDouble(t4.Text);
                y[2] = Convert.ToDouble(t12.Text);                                

                rhdqns[0] = Convert.ToDouble(t5.Text);
                rhdqns[1] = Convert.ToDouble(t6.Text);
                rhdqns[2] = Convert.ToDouble(t7.Text);
                rhdqns[3] = Convert.ToDouble(t8.Text);

                result[0] = (rhdqns[0] * (x[0] - x[1])) + (rhdqns[1] * (y[0] - y[1]));
                result[1] = (rhdqns[2] * (x[0] - x[1])) + (rhdqns[3] * (y[0] - y[1]));

                result[2] = -0.5 * ((x[0] * x[0] * rhdqns[0]) + (y[0] * y[0] * rhdqns[1]));
                result[3] = -0.5 * ((x[0] * x[0] * rhdqns[2]) + (y[0] * y[0] * rhdqns[3]));

                result[4] = 0.5 * ((x[1] * x[1] * rhdqns[0]) + (y[1] * y[1] * rhdqns[1]));
                result[5] = 0.5 * ((x[1] * x[1] * rhdqns[2]) + (y[1] * y[1] * rhdqns[3]));

                rufrhk.Text = "g12(x) = <( " + rhdqns[0] + ", " + rhdqns[1] + " ) ( " + rhdqns[2] + ", " + rhdqns[3] + " )> * ( " + (x[0] - x[1]) + ", " + (y[0] - y[1]) + " )T " +
                "* ( X1, X2 )T \r\n\r\n +" + " ( lnp(w1) - lnp(w2) " + "- 1/2 * " + "( " + x[0] + ", " + y[0] + " ) * < (" + rhdqns[0] + ", " + rhdqns[1] + ")(" + rhdqns[2] + ", " + rhdqns[3] + ") > * (" + x[0] + ", " + y[0] + " )T" +
                "\r\n\r\n + 1/2 * " + "( " + x[1] + ", " + y[1] + " ) * < (" + rhdqns[0] + ", " + rhdqns[1] + ")(" + rhdqns[2] + ", " + rhdqns[3] + ") > * (" + x[1] + ", " + y[1] + " )T" +

                "\r\n\r\ng12(x) => " + result[0] + "X1 + " + result[1] + "X2 + " + "lnp(w1) - lnp(w2) + " + ((result[2] + result[4]) + (result[3] + result[5]));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x[0] = Convert.ToDouble(t1.Text);
            x[1] = Convert.ToDouble(t3.Text);
            x[2] = Convert.ToDouble(t11.Text);

            y[0] = Convert.ToDouble(t2.Text);
            y[1] = Convert.ToDouble(t4.Text);
            y[2] = Convert.ToDouble(t12.Text);

            pw[0] = Convert.ToDouble(t9.Text);
            pw[1] = Convert.ToDouble(t10.Text);

            rhdqns[0] = Convert.ToDouble(t5.Text);
            rhdqns[1] = Convert.ToDouble(t6.Text);
            rhdqns[2] = Convert.ToDouble(t7.Text);
            rhdqns[3] = Convert.ToDouble(t8.Text);

            result[0] = (rhdqns[0] * (x[0] - x[1])) + (rhdqns[1] * (y[0] - y[1]));
            result[1] = (rhdqns[2] * (x[0] - x[1])) + (rhdqns[3] * (y[0] - y[1]));

            result[2] = -0.5 * ((x[0] * x[0] * rhdqns[0]) + (y[0] * y[0] * rhdqns[1]));
            result[3] = -0.5 * ((x[0] * x[0] * rhdqns[2]) + (y[0] * y[0] * rhdqns[3]));

            result[4] = 0.5 * ((x[1] * x[1] * rhdqns[0]) + (y[1] * y[1] * rhdqns[1]));
            result[5] = 0.5 * ((x[1] * x[1] * rhdqns[2]) + (y[1] * y[1] * rhdqns[3]));

            rufrhk.Text = "g12(x) => " + ((result[0]*x[2]) + (result[1] * y[2]) + (((pw[0] - pw[1]) + (result[2] + result[4]) + (result[3] + result[5]))));
        }
    }
}
