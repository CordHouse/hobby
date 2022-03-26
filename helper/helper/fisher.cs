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
    public partial class fisher : Form
    {
        double[] list1 = new double[10]; //1번식 x
        double[] list1_1 = new double[10]; //1번식 y
        double[] list2 = new double[10]; //2번식 x
        double[] list2_1 = new double[10]; //2번식 y
        double[] m1 = new double[3];
        double[] m2 = new double[3];
        double[] rhdqns1 = new double[10]; //공분산1번 결과
        double[] rhdqns2 = new double[10]; //공분산2번 결과
        double[] rhdqns3 = new double[10]; //공분산3번 결과
        double[] rhdqns4 = new double[10]; //공분산4번 결과
        double[] rhdqnsrufrhk1 = new double[11]; //s1 공분산1번 결과
        double[] rhdqnsrufrhk2 = new double[11]; //s1 공분산2번 결과
        double[] rhdqnsrufrhk3 = new double[11]; //s1 공분산3번 결과
        double[] rhdqnsrufrhk4 = new double[11]; //s1 공분산4번 결과
        double[] rhdqnsrufrhk5 = new double[11]; //sw2 공분산1번 결과
        double[] rhdqnsrufrhk6 = new double[11]; //sw2 공분산2번 결과
        double[] rhdqnsrufrhk7 = new double[11]; //sw2 공분산3번 결과
        double[] rhdqnsrufrhk8 = new double[11]; //sw2 공분산4번 결과
        double[] Swinverse = new double[9]; // sw-1

        public fisher()
        {
            InitializeComponent();
            t1.Text = "0"; t11.Text = "0";
            t2.Text = "0"; t12.Text = "0";
            t3.Text = "0"; t13.Text = "0";
            t4.Text = "0"; t14.Text = "0";
            t5.Text = "0"; t15.Text = "0";
            t6.Text = "0"; t16.Text = "0";
            t7.Text = "0"; t17.Text = "0";
            t8.Text = "0"; t18.Text = "0";
            t9.Text = "0"; t19.Text = "0";
            t10.Text = "0"; t20.Text = "0";

            t21.Text = "0"; t31.Text = "0";
            t22.Text = "0"; t32.Text = "0";
            t23.Text = "0"; t33.Text = "0";
            t24.Text = "0"; t34.Text = "0";
            t25.Text = "0"; t35.Text = "0";
            t26.Text = "0"; t36.Text = "0";
            t27.Text = "0"; t37.Text = "0";
            t28.Text = "0"; t38.Text = "0";
            t29.Text = "0"; t39.Text = "0";
            t30.Text = "0"; t40.Text = "0";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // W 벡터
        {            
            list1[0] = Convert.ToDouble(t1.Text); list1_1[0] = Convert.ToDouble(t2.Text);
            list1[1] = Convert.ToDouble(t3.Text); list1_1[1] = Convert.ToDouble(t4.Text);
            list1[2] = Convert.ToDouble(t5.Text); list1_1[2] = Convert.ToDouble(t6.Text);
            list1[3] = Convert.ToDouble(t7.Text); list1_1[3] = Convert.ToDouble(t8.Text);
            list1[4] = Convert.ToDouble(t9.Text); list1_1[4] = Convert.ToDouble(t10.Text);
            list1[5] = Convert.ToDouble(t11.Text); list1_1[5] = Convert.ToDouble(t12.Text);
            list1[6] = Convert.ToDouble(t13.Text); list1_1[6] = Convert.ToDouble(t14.Text);
            list1[7] = Convert.ToDouble(t15.Text); list1_1[7] = Convert.ToDouble(t16.Text);
            list1[8] = Convert.ToDouble(t17.Text); list1_1[8] = Convert.ToDouble(t18.Text);
            list1[9] = Convert.ToDouble(t19.Text); list1_1[9] = Convert.ToDouble(t20.Text);

            list2[0] = Convert.ToDouble(t21.Text); list2_1[0] = Convert.ToDouble(t22.Text);
            list2[1] = Convert.ToDouble(t23.Text); list2_1[1] = Convert.ToDouble(t24.Text);
            list2[2] = Convert.ToDouble(t25.Text); list2_1[2] = Convert.ToDouble(t26.Text);
            list2[3] = Convert.ToDouble(t27.Text); list2_1[3] = Convert.ToDouble(t28.Text);
            list2[4] = Convert.ToDouble(t29.Text); list2_1[4] = Convert.ToDouble(t30.Text);
            list2[5] = Convert.ToDouble(t31.Text); list2_1[5] = Convert.ToDouble(t32.Text);
            list2[6] = Convert.ToDouble(t33.Text); list2_1[6] = Convert.ToDouble(t34.Text);
            list2[7] = Convert.ToDouble(t35.Text); list2_1[7] = Convert.ToDouble(t35.Text);
            list2[8] = Convert.ToDouble(t37.Text); list2_1[8] = Convert.ToDouble(t38.Text);
            list2[9] = Convert.ToDouble(t39.Text); list2_1[9] = Convert.ToDouble(t40.Text);

            int i = 0, r =0;
            double result1 = 0.0, result2 = 0.0, result3 = 0.0, result4 = 0.0, Sw = 0.0;
            for (i = 0; list1[i] != 0 && i < 10; i++)
            {
                result1 += list1[i];
                result2 += list1_1[i];                
            }
            for (r = 0; list2[r] != 0 && r < 10; r++)
            {
                result3 += list2[r];
                result4 += list2_1[r];
            }
            
            result1 /= i;
            result2 /= i;
            result3 /= r;
            result4 /= r;

            m1[0] = result1;
            m1[1] = result2;
            m2[0] = result3;
            m2[1] = result4;

            for (int k = 0; k < i; k++)
            {
                rhdqns1[k] = list1[k] - m1[0];
                rhdqns2[k] = list1_1[k] - m1[1];
            }
            for(int k1= 0; k1 < r; k1++)
            { 
                rhdqns3[k1] = list2[k1] - m2[0];
                rhdqns4[k1] = list2_1[k1] - m2[1];
            }
            for (int j = 0; j < 10; j++)
            {
                rhdqnsrufrhk1[j] = rhdqns1[j] * rhdqns1[j];
                rhdqnsrufrhk1[10] += rhdqnsrufrhk1[j]; // 마지막 결과 누적
                rhdqnsrufrhk2[j] = rhdqns1[j] * rhdqns2[j];
                rhdqnsrufrhk2[10] += rhdqnsrufrhk2[j]; // 마지막 결과 누적
                rhdqnsrufrhk3[j] = rhdqns2[j] * rhdqns1[j];
                rhdqnsrufrhk3[10] += rhdqnsrufrhk3[j]; // 마지막 결과 누적 
                rhdqnsrufrhk4[j] = rhdqns2[j] * rhdqns2[j];
                rhdqnsrufrhk4[10] += rhdqnsrufrhk4[j]; // 마지막 결과 누적
            }
            for (int j1 = 0; j1 < 10; j1++)
            {
                rhdqnsrufrhk5[j1] = rhdqns3[j1] * rhdqns3[j1];
                rhdqnsrufrhk5[10] += rhdqnsrufrhk5[j1]; // 마지막 결과 누적
                rhdqnsrufrhk6[j1] = rhdqns3[j1] * rhdqns4[j1];
                rhdqnsrufrhk6[10] += rhdqnsrufrhk6[j1]; // 마지막 결과 누적
                rhdqnsrufrhk7[j1] = rhdqns4[j1] * rhdqns3[j1];
                rhdqnsrufrhk7[10] += rhdqnsrufrhk7[j1]; // 마지막 결과 누적 
                rhdqnsrufrhk8[j1] = rhdqns4[j1] * rhdqns4[j1];
                rhdqnsrufrhk8[10] += rhdqnsrufrhk8[j1]; // 마지막 결과 누적
            }

            Sw = 1 / (((rhdqnsrufrhk1[10] + rhdqnsrufrhk5[10]) * (rhdqnsrufrhk4[10] + rhdqnsrufrhk8[10])) - ((rhdqnsrufrhk2[10] + rhdqnsrufrhk6[10]) * (rhdqnsrufrhk3[10] + rhdqnsrufrhk7[10])));

            Swinverse[0] = ((rhdqnsrufrhk1[10] + rhdqnsrufrhk5[10]) * Sw); //x11
            Swinverse[1] = ((rhdqnsrufrhk2[10] + rhdqnsrufrhk6[10]) * Sw * -1); //x12
            Swinverse[2] = ((rhdqnsrufrhk3[10] + rhdqnsrufrhk7[10]) * Sw * -1); //x21
            Swinverse[3] = ((rhdqnsrufrhk4[10] + rhdqnsrufrhk8[10]) * Sw); //x22 여기까지 Sw-1
            

            m1[2] = m1[0] - m2[0]; // m1-m2 (x값)
            m2[2] = m1[1] - m2[1]; // m1-m2 (y값)

            Swinverse[4] = ((Swinverse[3] * m1[2]) + (Swinverse[2] * m2[2])); // x11, x12
            Swinverse[5] = ((Swinverse[1] * m1[2]) + (Swinverse[0] * m2[2])); // x21, x22

            Swinverse[6] = 1 / (Math.Sqrt(Math.Pow(Swinverse[4], 2) + Math.Pow(Swinverse[5], 2))); // α값

            Swinverse[7] = Swinverse[6] * Swinverse[4]; // W벡터의 x값
            Swinverse[8] = Swinverse[6] * Swinverse[5]; // W벡터의 y값

            rufrhk.Text = "<m1, m2>\r\n" + 
                "m1 평균벡터 : " + list1[0] + " + " + list1[1] + " + " + list1[2] + " + " + list1[3] + " + " + list1[4] + " + " + list1[5] + " + " + list1[6] + " + " + list1[7] + " + " + list1[8] + " + " + list1[9] + " = " + result1 + "\r\n\r\n" +
                list1_1[0] + " + " + list1_1[1] + " + " + list1_1[2] + " + " + list1_1[3] + " + " + list1_1[4] + " + " + list1_1[5] + " + " + list1_1[6] + " + " + list1_1[7] + " + " + list1_1[8] + " + " + list1_1[9] + " = " + result2 + "\r\n\r\nm1 = (" + result1 + ", " + result2 + ")\r\n\r\n" +
                "m2 평균벡터 : " + list2[0] + " + " + list2[1] + " + " + list2[2] + " + " + list2[3] + " + " + list2[4] + " + " + list2[5] + " + " + list2[6] + " + " + list2[7] + " + " + list2[7] + " + " + list2[8] + " + " + list2[9] + " = " + result3 + "\r\n\r\n" +
                list2_1[0] + " + " + list2_1[1] + " + " + list2_1[2] + " + " + list2_1[3] + " + " + list2_1[4] + " + " + list2_1[5] + " + " + list2_1[6] + " + " + list2_1[7] + " + " + list2_1[7] + " + " + list2_1[8] + " + " + list2_1[9] + " = " + result4 + "\r\n\r\nm2 = (" + result3 + ", " + result4 + ")\r\n\r\n" +
                
                "<Sw = S1 + S2>\r\n" +
                "S1 : (" + rhdqns1[0] + ", " + rhdqns2[0] + ") (" + rhdqns1[0] + ", " + rhdqns2[0] + ")T + (" + rhdqns1[1] + ", " + rhdqns2[1] + ") (" + rhdqns1[1] + ", " + rhdqns2[1] + ")T +" + "\r\n" +
                "(" + rhdqns1[2] + ", " + rhdqns2[2] + ") (" + rhdqns1[2] + ", " + rhdqns2[2] + ")T + (" + rhdqns1[3] + ", " + rhdqns2[3] + ") (" + rhdqns1[3] + ", " + rhdqns2[3] + ")T +" + "\r\n" +
                "(" + rhdqns1[4] + ", " + rhdqns2[4] + ") (" + rhdqns1[4] + ", " + rhdqns2[4] + ")T + (" + rhdqns1[5] + ", " + rhdqns2[5] + ") (" + rhdqns1[5] + ", " + rhdqns2[5] + ")T +" + "\r\n" +
                "(" + rhdqns1[6] + ", " + rhdqns2[6] + ") (" + rhdqns1[6] + ", " + rhdqns2[6] + ")T + (" + rhdqns1[7] + ", " + rhdqns2[7] + ") (" + rhdqns1[7] + ", " + rhdqns2[7] + ")T +" + "\r\n" +
                "(" + rhdqns1[8] + ", " + rhdqns2[8] + ") (" + rhdqns1[8] + ", " + rhdqns2[8] + ")T + (" + rhdqns1[9] + ", " + rhdqns2[9] + ") (" + rhdqns1[9] + ", " + rhdqns2[9] + ")T " + "\r\n\r\n" +
                "S2 : (" + rhdqns3[0] + ", " + rhdqns4[0] + ") (" + rhdqns3[0] + ", " + rhdqns4[0] + ")T + (" + rhdqns3[1] + ", " + rhdqns4[1] + ") (" + rhdqns3[1] + ", " + rhdqns4[1] + ")T +" + "\r\n" +
                "(" + rhdqns3[2] + ", " + rhdqns4[2] + ") (" + rhdqns3[2] + ", " + rhdqns4[2] + ")T + (" + rhdqns3[3] + ", " + rhdqns4[3] + ") (" + rhdqns3[3] + ", " + rhdqns4[3] + ")T +" + "\r\n" +
                "(" + rhdqns3[4] + ", " + rhdqns4[4] + ") (" + rhdqns3[4] + ", " + rhdqns4[4] + ")T + (" + rhdqns3[5] + ", " + rhdqns4[5] + ") (" + rhdqns3[5] + ", " + rhdqns4[5] + ")T +" + "\r\n" +
                "(" + rhdqns3[6] + ", " + rhdqns4[6] + ") (" + rhdqns3[6] + ", " + rhdqns4[6] + ")T + (" + rhdqns3[7] + ", " + rhdqns4[7] + ") (" + rhdqns3[7] + ", " + rhdqns4[7] + ")T +" + "\r\n" +
                "(" + rhdqns3[8] + ", " + rhdqns4[8] + ") (" + rhdqns3[8] + ", " + rhdqns4[8] + ")T + (" + rhdqns3[9] + ", " + rhdqns4[9] + ") (" + rhdqns3[9] + ", " + rhdqns4[9] + ")T " + "\r\n\r\nSw1 = (" + (rhdqnsrufrhk1[10] + rhdqnsrufrhk5[10]) + ", " + (rhdqnsrufrhk2[10] + rhdqnsrufrhk6[10]) + ")" + "\r\nSw2 = (" + (rhdqnsrufrhk3[10] + rhdqnsrufrhk7[10]) + ", " + (rhdqnsrufrhk4[10] + rhdqnsrufrhk8[10]) + ")\r\n\r\n" +
                "1/ad-bc = " + Sw +
                "\r\n\r\n<Sw-1>" + "\r\nSw1 = (" + Swinverse[3] + ", " + Swinverse[2] + ")" + "\r\n       = (" + Swinverse[1] + ", " + Swinverse[0] + ")\r\n\r\n" +
                "α* ( " + Swinverse[4] + " )\r\n     ( " + Swinverse[5] + " )\r\n\r\n" + "α = " + Swinverse[6] + "\r\n\r\nW = (" + Swinverse[7] + ", " + Swinverse[8] + ")T";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = "0"; t9.Text = "0";
            t2.Text = "0"; t10.Text = "0";
            t3.Text = "0"; t11.Text = "0";
            t4.Text = "0"; t12.Text = "0";
            t5.Text = "0"; t13.Text = "0";
            t6.Text = "0"; t14.Text = "0";
            t7.Text = "0"; t15.Text = "0";
            t8.Text = "0"; t16.Text = "0";

            t21.Text = "0"; t29.Text = "0";
            t22.Text = "0"; t30.Text = "0";
            t23.Text = "0"; t31.Text = "0";
            t24.Text = "0"; t32.Text = "0";
            t25.Text = "0"; t33.Text = "0";
            t26.Text = "0"; t34.Text = "0";
            t27.Text = "0"; t35.Text = "0";
            t28.Text = "0"; t36.Text = "0";

            t37.Text = "0"; t39.Text = "0";
            t38.Text = "0"; t40.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e) // J(W)
        {
            double[] x = new double[10];
            double[] y = new double[10];
            double[] x1 = new double[10];
            double[] y1 = new double[10];
            int i = 0, j = 0, k = 0, k1 = 0;
            double m1 = 0.0, m2 = 0.0;
            list1[0] = Convert.ToDouble(t1.Text); list1_1[0] = Convert.ToDouble(t2.Text);
            list1[1] = Convert.ToDouble(t3.Text); list1_1[1] = Convert.ToDouble(t4.Text);
            list1[2] = Convert.ToDouble(t5.Text); list1_1[2] = Convert.ToDouble(t6.Text);
            list1[3] = Convert.ToDouble(t7.Text); list1_1[3] = Convert.ToDouble(t8.Text);
            list1[4] = Convert.ToDouble(t9.Text); list1_1[4] = Convert.ToDouble(t10.Text);
            list1[5] = Convert.ToDouble(t11.Text); list1_1[5] = Convert.ToDouble(t12.Text);
            list1[6] = Convert.ToDouble(t13.Text); list1_1[6] = Convert.ToDouble(t14.Text);
            list1[7] = Convert.ToDouble(t15.Text); list1_1[7] = Convert.ToDouble(t16.Text);
            list1[8] = Convert.ToDouble(t17.Text); list1_1[8] = Convert.ToDouble(t18.Text);
            list1[9] = Convert.ToDouble(t19.Text); list1_1[9] = Convert.ToDouble(t20.Text);

            list2[0] = Convert.ToDouble(t21.Text); list2_1[0] = Convert.ToDouble(t22.Text);
            list2[1] = Convert.ToDouble(t23.Text); list2_1[1] = Convert.ToDouble(t24.Text);
            list2[2] = Convert.ToDouble(t25.Text); list2_1[2] = Convert.ToDouble(t26.Text);
            list2[3] = Convert.ToDouble(t27.Text); list2_1[3] = Convert.ToDouble(t28.Text);
            list2[4] = Convert.ToDouble(t29.Text); list2_1[4] = Convert.ToDouble(t30.Text);
            list2[5] = Convert.ToDouble(t31.Text); list2_1[5] = Convert.ToDouble(t32.Text);
            list2[6] = Convert.ToDouble(t33.Text); list2_1[6] = Convert.ToDouble(t34.Text);
            list2[7] = Convert.ToDouble(t35.Text); list2_1[7] = Convert.ToDouble(t35.Text);
            list2[8] = Convert.ToDouble(t37.Text); list2_1[8] = Convert.ToDouble(t38.Text);
            list2[9] = Convert.ToDouble(t39.Text); list2_1[9] = Convert.ToDouble(t40.Text);

            for(i=0; list1[i] != 0; i++)
            {
                x[i] = (Convert.ToDouble(j1.Text) * list1[i]) + (Convert.ToDouble(j2.Text) * list1_1[i]);
                m1 += x[i];
            }
            m1 /= i;
            for (j = 0; list2[j] != 0; j++)
            {
                y[j] = (Convert.ToDouble(j1.Text) * list2[j]) + (Convert.ToDouble(j2.Text) * list2_1[j]);
                m2 += y[j];
            }
            m2 /= j;

            double s1 = 0.0, s2 = 0.0, w = 0.0;

            for(k = 0, k1 = 0; k < i || k1 < j;)
            {
                if(k < i)
                {
                    s1 += Math.Pow((x[k] - m1), 2);
                    x1[k] = (x[k] - m1);
                    k++;
                }
                if (k1 < j)
                {
                    s2 += Math.Pow((y[k1] - m2), 2);
                    y1[k1] = (y[k1] - m2);
                    k1++;
                }
            }

            w = (Math.Pow(Math.Abs(m1 - m2), 2)) / (s1 + s2);

            rufrhk.Text ="m1` = " + x[0] + " + " + x[1] + " + " + x[2] + " + " + x[3] + " + " + x[4] + " + " + x[5] + " + " + x[6] + " + " + x[7] + " + " + x[8] + " + " + x[9] + " = " + m1 + 
                "\r\nm2` = " + y[0] + " + " + y[1] + " + " + y[2] + " + " + y[3] + " + " + y[4] + " + " + y[5] + " + " + y[6] + " + " + y[7] + " + " + y[8] + " + " + y[9] + " = " + m2 + 
                "\r\n\r\ns1^2 = (" + x1[0] + ")^2 + (" +  x1[1]  + ")^2 + (" + x1[2] + ")^2 + (" + x1[3] + ")^2 + (" + x1[4] + ")^2 + (" + x1[5] + ")^2 + (" + x1[6] + ")^2 + (" + x1[7] + ")^2 + (" + x1[8] + ")^2 + (" + x1[9] + ")^2 = " + s1 + 
                "\r\n\r\ns2^2 = (" + y1[0] + ")^2 + (" + y1[1] + ")^2 + (" + y1[2] + ")^2 + (" + y1[3] + ")^2 + (" + y1[4] + ")^2 + (" + y1[5] + ")^2 + (" + y1[6] + ")^2 + (" + y1[7] + ")^2 + (" + y1[8] + ")^2 + (" + y1[9] + ")^2 = " + s2 + "\r\n\r\nJ(w) = " + w;
        }
    }
}

