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
    public partial class SVM : Form
    {
        public SVM()
        {
            InitializeComponent();
            t1.Text = "0"; t4.Text = "0";
            t2.Text = "0"; t5.Text = "0";
            t3.Text = "0"; t6.Text = "0";
            rufrhk.Text = "샘플이 2개인 경우 조건\r\n① α1t1 - α2t2 = 0\r\n② α1 >= 0, α2 >= 0\r\n\r\n샘플이 3개인 경우 여기서 먼저 조건 찾아서 샘플 2개만을 사용\r\n① α1=0, α2≠0, α3≠0\r\n② α1≠0, α2=0, α3≠0\r\n③ α1≠0, α2≠0, α3=0\r\n④ α1≠0, α2≠0, α3≠0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] x = new double[3];
            double[] y = new double[3];
            double[] t = new double[3];
            double[] result = new double[5]; // [0][1] = L(a) / [2][3] = W / [4] = b
            double[] num = new double[10];

            x[0] = Convert.ToDouble(t1.Text);
            x[1] = Convert.ToDouble(t4.Text);

            y[0] = Convert.ToDouble(t2.Text);
            y[1] = Convert.ToDouble(t5.Text);

            t[0] = Convert.ToDouble(t3.Text);
            t[1] = Convert.ToDouble(t6.Text);

            num[0] = (t[0] * t[0]) * ((x[0] * x[0]) + (y[0] * y[0]));

            num[1] = (t[0] * t[1]) * ((x[0] * x[1]) + (y[0] * y[1]));

            num[2] = (t[1] * t[1]) * ((x[1] * x[1]) + (y[1] * y[1]));

            num[3] = (num[0] + num[1] + num[1] + num[2]) / (-1 * 2);

            num[4] = num[3] * 2; // 미분

            num[5] = -1 * (2 / num[4]); // 알파1 == 알파2 값 

            rufrhk.Text = "2α1 - (1/2) ( " + (t[0] * t[0]) + "α1^2 * ( " + x[0] + ", " + y[0] + " )" + "( " + x[0] + ", " + y[0] + " )T + (" +
                (t[0] * t[1]) + "α1^2 * ( " + x[0] + ", " + y[0] + " )" + "( " + x[1] + ", " + y[1] + " )T) + (" +
                (t[1] * t[0]) + "α1^2 * ( " + x[1] + ", " + y[1] + " )" + "( " + x[0] + ", " + y[0] + " )T) + (" +
                (t[1] * t[1]) + "α1^2 * ( " + x[1] + ", " + y[1] + " )" + "( " + x[1] + ", " + y[1] + " )T)" +

                "\r\n\r\n => " + "2α1 - (1/2)*( " + num[0] + "α1^2 + " + num[1] + "α1^2 + " + num[1] + "α1^2 + " + num[2] + "α1^2 )" +
                "\r\n => " + "2α1 + ( " + num[3] + "α1^2 )" +
                "\r\n => " + "2 + " + num[4] + "α1" +
                "\r\n α1 = " + num[5] +

                "\r\n\r\n W => " + (num[5] * t[0]) + "( " + x[0] + ", " + y[0] + " )T + " + (num[5] * t[1]) + "( " + x[1] + ", " + y[1] + " )T" +
                "\r\n => " + num[5] + "* ( " + ((x[0] * t[0]) + (x[1] * t[1])) + ", " + ((y[0] * t[0]) + (y[1] * t[1])) + " )T" +
                "\r\n W = " + "( " + (num[5] * ((x[0] * t[0]) + (x[1] * t[1]))) + ", " + (num[5] * ((y[0] * t[0]) + (y[1] * t[1]))) + " )T" +

                "\r\n\r\n b => " + num[5] + "( " + t[0] + "*( " + (num[5] * ((x[0] * t[0]) + (x[1] * t[1]))) + ", " + (num[5] * ((y[0] * t[0]) + (y[1] * t[1]))) + " ) (" + x[0] + ", " + y[0] + " )T + b ) - 1)" + 
                "\r\n => " + ((num[5] * ((x[0] * t[0]) + (x[1] * t[1]))) * x[0]) + " + " + ((num[5] * ((y[0] * t[0]) + (y[1] * t[1]))) * y[0]) + " + b - 1 = 0" +
                "\r\n b = " + (-1 * (((num[5] * ((x[0] * t[0]) + (x[1] * t[1]))) * x[0]) + ((num[5] * ((y[0] * t[0]) + (y[1] * t[1]))) * y[0]) - 1)) +
                "\r\n\r\n 결정직선 = " + (num[5] * ((x[0] * t[0]) + (x[1] * t[1]))) + "X1 + " + (num[5] * ((y[0] * t[0]) + (y[1] * t[1]))) + "X2 + " + (-1 * (((num[5] * ((x[0] * t[0]) + (x[1] * t[1]))) * x[0]) + ((num[5] * ((y[0] * t[0]) + (y[1] * t[1]))) * y[0]) - 1))
                ;
        }
    }
}
