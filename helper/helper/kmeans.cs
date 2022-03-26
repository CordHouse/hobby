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
    public partial class kmeans : Form
    {
        double[] list1 = new double[10]; //1번식 x
        double[] list1_1 = new double[10]; //1번식 y
        double[] list2 = new double[10]; //2번식 x
        double[] list2_1 = new double[10]; //2번식 y        

        public kmeans()
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

            t21.Text = "0"; 
            t22.Text = "0"; 
            t23.Text = "0"; 
            t24.Text = "0"; 
            t25.Text = "0"; 
            t26.Text = "0"; 
            t27.Text = "0";
            t28.Text = "0"; 
            t29.Text = "0"; 
            t30.Text = "0"; 
        }

        private void button1_Click(object sender, EventArgs e)
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


            int i = 0, j = 0, k = 0, count = 0;
            int n = 0;

            double[] z = new double[35];
            double[] z1 = new double[35];
            double[] z2 = new double[35];
            double[] z3 = new double[35];
            double[] z4 = new double[35];
            double[] co = new double[4];

            while (list1[count] != 0)
                ++count;

            for (i = 0; list2[i] != 0; i++)
            {
                for(j = 0; list1[j] != 0; j++)
                {                   
                    z[k] = Math.Sqrt(Math.Pow((list2[i] - list1[j]), 2) + Math.Pow((list2_1[i] - list1_1[j]), 2));
                    k++;
                }
            }
            if (list2[0] != 0 && list2_1[0] != 0 && list2[1] != 0 && list2_1[1] != 0 && list2[2] != 0 && list2_1[2] != 0 && list2[3] == 0 && list2_1[3] == 0 && list2[4] == 0 && list2_1[4] == 0)
            {
                for (n = 0; n < count; n++)
                {
                    if (z[n] < z[n + count] && z[n] < z[n + count + count])
                    {
                        z1[n] = n + 1;
                        z1[33] += list1[n];
                        z1[34] += list1_1[n];
                        ++co[0];
                    }
                    else if (z[n + count] < z[n] && z[n + count] < z[n + count + count])
                    {
                        z2[n] = n + 1;
                        z2[33] += list1[n];
                        z2[34] += list1_1[n];
                        ++co[1];
                    }
                    else if (z[n + count + count] < z[n] && z[n + count + count] < z[n + count])
                    {
                        z3[n] = n + 1;
                        z3[33] += list1[n];
                        z3[34] += list1_1[n];
                        ++co[2];
                    }
                }
                z1[33] /= co[0];
                z1[34] /= co[0];
                z2[33] /= co[1];
                z2[34] /= co[1];
                z3[33] /= co[2];
                z3[34] /= co[2];

                t21.Text = Convert.ToString(z1[33]);
                t22.Text = Convert.ToString(z1[34]);
                t23.Text = Convert.ToString(z2[33]);
                t24.Text = Convert.ToString(z2[34]);
                t25.Text = Convert.ToString(z3[33]);
                t26.Text = Convert.ToString(z3[34]);

                if (count == 1)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\n z1 : " + z1[0]
                        + "\r\n\r\n z2 : " + z2[0]
                        + "\r\n\r\n z3 : " + z3[0]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 2)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 3)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 4)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 5)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 6)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 7)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count]
                        + "\r\n\r\nx7\r\n(1) " + z[6] + "\r\n(2) " + z[6 + count] + "\r\n(3) " + z[6 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 8)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count]
                        + "\r\n\r\nx7\r\n(1) " + z[6] + "\r\n(2) " + z[6 + count] + "\r\n(3) " + z[6 + count + count]
                        + "\r\n\r\nx8\r\n(1) " + z[7] + "\r\n(2) " + z[7 + count] + "\r\n(3) " + z[7 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 9)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count]
                        + "\r\n\r\nx7\r\n(1) " + z[6] + "\r\n(2) " + z[6 + count] + "\r\n(3) " + z[6 + count + count]
                        + "\r\n\r\nx8\r\n(1) " + z[7] + "\r\n(2) " + z[7 + count] + "\r\n(3) " + z[7 + count + count]
                        + "\r\n\r\nx9\r\n(1) " + z[8] + "\r\n(2) " + z[8 + count] + "\r\n(3) " + z[8 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }
                else if (count == 10)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] 
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] 
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count] 
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count] 
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count] 
                        + "\r\n\r\nx7\r\n(1) " + z[6] + "\r\n(2) " + z[6 + count] + "\r\n(3) " + z[6 + count + count] 
                        + "\r\n\r\nx8\r\n(1) " + z[7] + "\r\n(2) " + z[7 + count] + "\r\n(3) " + z[7 + count + count] 
                        + "\r\n\r\nx9\r\n(1) " + z[8] + "\r\n(2) " + z[8 + count] + "\r\n(3) " + z[8 + count + count] 
                        + "\r\n\r\nx10\r\n(1) " + z[9] + "\r\n(2) " + z[9 + count] + "\r\n(3) " + z[9 + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8] + ", " + z1[9]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8] + ", " + z2[9]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8] + ", " + z3[9]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        ;
                }                
            }

            else if (list2[0] != 0 && list2_1[0] != 0 && list2[1] != 0 && list2_1[1] != 0 && list2[2] != 0 && list2_1[2] != 0 && list2[3] != 0 && list2_1[3] != 0 && list2[4] == 0 && list2_1[4] == 0)
            {
                for (n = 0; n < count; n++)
                {
                    if (z[n] < z[n + count] && z[n] < z[n + count + count] && z[n] < z[n + count + count + count])
                    {
                        z1[n] = n + 1;
                        z1[33] += list1[n];
                        z1[34] += list1_1[n];
                        ++co[0];
                    }
                    else if (z[n + count] < z[n] && z[n + count] < z[n + count + count] && z[n+count] < z[n + count + count + count])
                    {
                        z2[n] = n + 1;
                        z2[33] += list1[n];
                        z2[34] += list1_1[n];
                        ++co[1];
                    }
                    else if (z[n + count + count] < z[n] && z[n + count + count] < z[n + count] && z[n+count+count] < z[n + count + count + count])
                    {
                        z3[n] = n + 1;
                        z3[33] += list1[n];
                        z3[34] += list1_1[n];
                        ++co[2];
                    }
                    else if (z[n + count + count + count] < z[n] && z[n + count + count + count] < z[n + count] && z[n + count + count + count] < z[n + count + count])
                    {
                        z4[n] = n + 1;
                        z4[33] += list1[n];
                        z4[34] += list1_1[n];
                        ++co[3];
                    }
                }
                z1[33] /= co[0];
                z1[34] /= co[0];
                z2[33] /= co[1];
                z2[34] /= co[1];
                z3[33] /= co[2];
                z3[34] /= co[2];
                z4[33] /= co[3];
                z4[34] /= co[3];

                t21.Text = Convert.ToString(z1[33]);
                t22.Text = Convert.ToString(z1[34]);
                t23.Text = Convert.ToString(z2[33]);
                t24.Text = Convert.ToString(z2[34]);
                t25.Text = Convert.ToString(z3[33]);
                t26.Text = Convert.ToString(z3[34]);
                t27.Text = Convert.ToString(z4[33]);
                t28.Text = Convert.ToString(z4[34]);

                if (count == 1)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\n z1 : " + z1[0]
                        + "\r\n\r\n z2 : " + z2[0]
                        + "\r\n\r\n z3 : " + z3[0]
                        + "\r\n\r\n z4 : " + z4[0]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 2)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 3)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] + "\r\n(4) " + z[2 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 4)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] + "\r\n(4) " + z[2 + count + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count] + "\r\n(4) " + z[3 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 5)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] + "\r\n(4) " + z[2 + count + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count] + "\r\n(4) " + z[3 + count + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count] + "\r\n(4) " + z[4 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 6)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] + "\r\n(4) " + z[2 + count + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count] + "\r\n(4) " + z[3 + count + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count] + "\r\n(4) " + z[4 + count + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count] + "\r\n(4) " + z[5 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 7)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] + "\r\n(4) " + z[2 + count + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count] + "\r\n(4) " + z[3 + count + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count] + "\r\n(4) " + z[4 + count + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count] + "\r\n(4) " + z[5 + count + count + count]
                        + "\r\n\r\nx7\r\n(1) " + z[6] + "\r\n(2) " + z[6 + count] + "\r\n(3) " + z[6 + count + count] + "\r\n(4) " + z[6 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 8)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] + "\r\n(4) " + z[2 + count + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count] + "\r\n(4) " + z[3 + count + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count] + "\r\n(4) " + z[4 + count + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count] + "\r\n(4) " + z[5 + count + count + count]
                        + "\r\n\r\nx7\r\n(1) " + z[6] + "\r\n(2) " + z[6 + count] + "\r\n(3) " + z[6 + count + count] + "\r\n(4) " + z[6 + count + count + count]
                        + "\r\n\r\nx8\r\n(1) " + z[7] + "\r\n(2) " + z[7 + count] + "\r\n(3) " + z[7 + count + count] + "\r\n(4) " + z[7 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 9)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] + "\r\n(4) " + z[2 + count + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count] + "\r\n(4) " + z[3 + count + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count] + "\r\n(4) " + z[4 + count + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count] + "\r\n(4) " + z[5 + count + count + count]
                        + "\r\n\r\nx7\r\n(1) " + z[6] + "\r\n(2) " + z[6 + count] + "\r\n(3) " + z[6 + count + count] + "\r\n(4) " + z[6 + count + count + count]
                        + "\r\n\r\nx8\r\n(1) " + z[7] + "\r\n(2) " + z[7 + count] + "\r\n(3) " + z[7 + count + count] + "\r\n(4) " + z[7 + count + count + count]
                        + "\r\n\r\nx9\r\n(1) " + z[8] + "\r\n(2) " + z[8 + count] + "\r\n(3) " + z[8 + count + count] + "\r\n(4) " + z[8 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7] + ", " + z4[8]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }
                else if (count == 10)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)는 Z순서로 반복된 거리값 입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[count] + "\r\n(3) " + z[count + count] + "\r\n(4) " + z[count + count + count]
                        + "\r\n\r\nx2\r\n(1) " + z[1] + "\r\n(2) " + z[1 + count] + "\r\n(3) " + z[1 + count + count] + "\r\n(4) " + z[1 + count + count + count]
                        + "\r\n\r\nx3\r\n(1) " + z[2] + "\r\n(2) " + z[2 + count] + "\r\n(3) " + z[2 + count + count] + "\r\n(4) " + z[2 + count + count + count]
                        + "\r\n\r\nx4\r\n(1) " + z[3] + "\r\n(2) " + z[3 + count] + "\r\n(3) " + z[3 + count + count] + "\r\n(4) " + z[3 + count + count + count]
                        + "\r\n\r\nx5\r\n(1) " + z[4] + "\r\n(2) " + z[4 + count] + "\r\n(3) " + z[4 + count + count] + "\r\n(4) " + z[4 + count + count + count]
                        + "\r\n\r\nx6\r\n(1) " + z[5] + "\r\n(2) " + z[5 + count] + "\r\n(3) " + z[5 + count + count] + "\r\n(4) " + z[5 + count + count + count]
                        + "\r\n\r\nx7\r\n(1) " + z[6] + "\r\n(2) " + z[6 + count] + "\r\n(3) " + z[6 + count + count] + "\r\n(4) " + z[6 + count + count + count]
                        + "\r\n\r\nx8\r\n(1) " + z[7] + "\r\n(2) " + z[7 + count] + "\r\n(3) " + z[7 + count + count] + "\r\n(4) " + z[7 + count + count + count]
                        + "\r\n\r\nx9\r\n(1) " + z[8] + "\r\n(2) " + z[8 + count] + "\r\n(3) " + z[8 + count + count] + "\r\n(4) " + z[8 + count + count + count]
                        + "\r\n\r\nx10\r\n(1) " + z[9] + "\r\n(2) " + z[9 + count] + "\r\n(3) " + z[9 + count + count] + "\r\n(4) " + z[9 + count + count + count]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8] + ", " + z1[9]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8] + ", " + z2[9]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8] + ", " + z3[9]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7] + ", " + z4[8] + ", " + z4[9]
                        + "\r\n\r\n z1 평균벡터 : ( " + z1[33] + ", " + z1[34] + " )T"
                        + "\r\n\r\n z2 평균벡터 : ( " + z2[33] + ", " + z2[34] + " )T"
                        + "\r\n\r\n z3 평균벡터 : ( " + z3[33] + ", " + z3[34] + " )T"
                        + "\r\n\r\n z4 평균벡터 : ( " + z4[33] + ", " + z4[34] + " )T"
                        ;
                }                
            }
        }
    }
}
