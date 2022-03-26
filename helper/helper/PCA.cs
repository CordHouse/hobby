using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helper
{
    public partial class PCA : Form
    {
        public PCA()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // 람다 계산
        {
            double[] list = new double[4];
            double[] result = new double [4] ;
            list[0] = Convert.ToDouble(t1.Text); list[1] = Convert.ToDouble(t2.Text);
            list[2] = Convert.ToDouble(t3.Text); list[3] = Convert.ToDouble(t4.Text);

            result[0] = 1;
            result[1] = (list[0] * -1) + (list[3] * -1);
            result[2] = list[0] * list[3];
            result[3] = list[1] * list[2];

            fkaek.Text = result[0] + "λ^2 + " + result[1] + "λ + " + (result[2] - result[3]) + " = 0";
        }

        private void button2_Click(object sender, EventArgs e) // 근의 공식
        {
            double[] list = new double[4];
            double[] result = new double[5];
            list[0] = Convert.ToDouble(t5.Text); list[1] = Convert.ToDouble(t6.Text);
            list[2] = Convert.ToDouble(t7.Text);     

            result[0] = ((-1 * list[1]) + Math.Sqrt(Math.Pow(list[1], 2) - (4 * list[0] * list[2]))) / (2 * list[0]);
            result[1] = ((-1 * list[1]) - Math.Sqrt(Math.Pow(list[1], 2) - (4 * list[0] * list[2]))) / (2 * list[0]);

            rmsrhdtlr.Text = "λ1 = (" + "(-1 *" + list[1] + ")" + " + 루트(" + (Math.Sqrt(Math.Pow(list[1], 2) - (4 * list[0] * list[3]))) + "))" + " / " + (2 * list[0]) + " = " + result[0] + "\r\n\r\n" +
                "λ2 = (" + "(-1 *" + list[1] + ")" + " - 루트(" + (Math.Sqrt(Math.Pow(list[1], 2) - (4 * list[0] * list[3]))) + "))" + " / " + (2 * list[0]) + " = " + result[1];
        }

        private void button3_Click(object sender, EventArgs e) // U1, U2 벡터구하기
        {
            double[] list = new double[4]; // 공분산 배열
            double[] list1 = new double[2]; // 람다 배열

            double[] result = new double[6];
            double[] result1 = new double[6];

            double[] result2 = new double[6];
            double[] result3 = new double[6];
            list[0] = Convert.ToDouble(t1.Text); list[1] = Convert.ToDouble(t2.Text);
            list[2] = Convert.ToDouble(t3.Text); list[3] = Convert.ToDouble(t4.Text);
            list1[0] = Convert.ToDouble(t8.Text); list1[1] = Convert.ToDouble(t9.Text); // 람다 값
            //두 식을 계산하기 위해서 같은 값으로 만듬
            //1번째 람다 경우
            result[0] = list[0] * list[2] * -1; 
            result[1] = list[1] * list[2] * -1;
            result[2] = list1[0] * list[2] * -1; // 1번식 끝

            result[3] = list[2] * list[0];
            result[4] = list[3] * list[0];
            result[5] = list1[0] * list[0]; // 2번식 끝

            result1[0] = result[1] + result[4];
            result1[1] = result1[0] + (result[5] * -1);
            result1[2] = result[2] / result1[1]; // u12를 구함

            result1[3] = 1 + Math.Pow(result1[2], 2); // u11을 구하기 위함
            result1[4] = 1 / result1[3]; // u11^2을 구함
            result1[5] = Math.Sqrt(result1[4]); // u11로 구함

            //2번째 람다 경우
            result2[0] = list[0] * list[2] * -1;
            result2[1] = list[1] * list[2] * -1;
            result2[2] = list1[1] * list[2] * -1;

            result2[3] = list[2] * list[0];
            result2[4] = list[3] * list[0];
            result2[5] = list1[1] * list[0];

            result3[0] = result2[1] + result2[4];
            result3[1] = result3[0] + (result2[5] * -1);
            result3[2] = result2[2] / result3[1]; // u12를 구함

            result3[3] = 1 + Math.Pow(result3[2], 2); // u11을 구하기 위함
            result3[4] = 1 / result3[3]; // u11^2을 구함
            result3[5] = Math.Sqrt(result3[4]); // u11로 구함
          
            qprxj.Text = "u1 = (" + result1[5] + ", " + (result1[2] * result1[5]) + ")T\r\n\r\n" + "u2 = (" + result3[5] + ", " + (result3[2] * result3[5]) + ")T";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t6.Text = "";
            t7.Text = "";
            t8.Text = "";
            t9.Text = "";
        }
    }
}
