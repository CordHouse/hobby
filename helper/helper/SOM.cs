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
    public partial class SOM : Form
    {
        double[] list1 = new double[11]; //1번식 x
        double[] list1_1 = new double[11]; //1번식 y
        double[] list2 = new double[10]; //2번식 x
        double[] list2_1 = new double[10]; //2번식 y      
        public SOM()
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
            list1[10] = Convert.ToDouble(0); list1_1[10] = Convert.ToDouble(0);

            list2[0] = Convert.ToDouble(t21.Text); list2_1[0] = Convert.ToDouble(t22.Text);
            list2[1] = Convert.ToDouble(t23.Text); list2_1[1] = Convert.ToDouble(t24.Text);
            list2[2] = Convert.ToDouble(t25.Text); list2_1[2] = Convert.ToDouble(t26.Text);
            list2[3] = Convert.ToDouble(t27.Text); list2_1[3] = Convert.ToDouble(t28.Text);
            list2[4] = Convert.ToDouble(t29.Text); list2_1[4] = Convert.ToDouble(t30.Text);


            int i = 0, j = 0, k = 0, count = 0;
            int c =0;

            double[] z = new double[35];
            double[] z1 = new double[35];
            double[] z2 = new double[35];
            double[] z3 = new double[35];
            double[] z4 = new double[35];
            double[] z5 = new double[35];
            double[] co = new double[3];

            while (list1[count] != 0)
                ++count;

            if (list2[0] != 0 && list2_1[0] != 0 && list2[1] == 0 && list2_1[1] == 0 && list2[2] == 0 && list2_1[2] == 0 && list2[3] == 0 && list2_1[3] == 0 && list2[4] == 0 && list2_1[4] == 0) // 가중치 1
            {
                for (i = 0; list1[i] != 0; i++)
                {
                    for (j = 0; j < 1; j++)
                    {
                        z[k] = Math.Sqrt(Math.Pow((list1[i] - list2[j]), 2) + Math.Pow((list1_1[i] - list2_1[j]), 2));
                        k++;
                    }

                    z1[c] = c + 1;
                    list2[0] = list2[0] + (0.6 * (list1[i] - list2[0]));
                    list2_1[0] = list2_1[0] + (0.6 * (list1_1[i] - list2_1[0]));
                    t21.Text = Convert.ToString(list2[0]);
                    t22.Text = Convert.ToString(list2_1[0]);
                    c++;
                }


                if (count == 1)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\n z1 : " + z1[0]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 2)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 3)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\nx3\r\n(1) " + z[2]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 4)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\nx3\r\n(1) " + z[2]
                        + "\r\n\r\nx4\r\n(1) " + z[3]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 5)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\nx3\r\n(1) " + z[2]
                        + "\r\n\r\nx4\r\n(1) " + z[3]
                        + "\r\n\r\nx5\r\n(1) " + z[4]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 6)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\nx3\r\n(1) " + z[2]
                        + "\r\n\r\nx4\r\n(1) " + z[3]
                        + "\r\n\r\nx5\r\n(1) " + z[4]
                        + "\r\n\r\nx6\r\n(1) " + z[5]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 7)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\nx3\r\n(1) " + z[2]
                        + "\r\n\r\nx4\r\n(1) " + z[3]
                        + "\r\n\r\nx5\r\n(1) " + z[4]
                        + "\r\n\r\nx6\r\n(1) " + z[5]
                        + "\r\n\r\nx7\r\n(1) " + z[6]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 8)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\nx3\r\n(1) " + z[2]
                        + "\r\n\r\nx4\r\n(1) " + z[3]
                        + "\r\n\r\nx5\r\n(1) " + z[4]
                        + "\r\n\r\nx6\r\n(1) " + z[5]
                        + "\r\n\r\nx7\r\n(1) " + z[6]
                        + "\r\n\r\nx8\r\n(1) " + z[7]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 9)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\nx3\r\n(1) " + z[2]
                        + "\r\n\r\nx4\r\n(1) " + z[3]
                        + "\r\n\r\nx5\r\n(1) " + z[4]
                        + "\r\n\r\nx6\r\n(1) " + z[5]
                        + "\r\n\r\nx7\r\n(1) " + z[6]
                        + "\r\n\r\nx8\r\n(1) " + z[7]
                        + "\r\n\r\nx9\r\n(1) " + z[8]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
                else if (count == 10)
                {
                    rufrhk.Text = "<거리> (1)는 Z1 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0]
                        + "\r\n\r\nx2\r\n(1) " + z[1]
                        + "\r\n\r\nx3\r\n(1) " + z[2]
                        + "\r\n\r\nx4\r\n(1) " + z[3]
                        + "\r\n\r\nx5\r\n(1) " + z[4]
                        + "\r\n\r\nx6\r\n(1) " + z[5]
                        + "\r\n\r\nx7\r\n(1) " + z[6]
                        + "\r\n\r\nx8\r\n(1) " + z[7]
                        + "\r\n\r\nx9\r\n(1) " + z[8]
                        + "\r\n\r\nx10\r\n(1) " + z[9]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8] + ", " + z1[9]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        ;
                }
            }

            else if (list2[0] != 0 && list2_1[0] != 0 && list2[1] != 0 && list2_1[1] != 0 && list2[2] == 0 && list2_1[2] == 0 && list2[3] == 0 && list2_1[3] == 0 && list2[4] == 0 && list2_1[4] == 0) // 가중치 2
            {
                for (i = 0; list1[i] != 0; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        z[k] = Math.Sqrt(Math.Pow((list1[i] - list2[j]), 2) + Math.Pow((list1_1[i] - list2_1[j]), 2));
                        k++;
                    }

                    if (z[(i * 2)] < z[(i * 2) + 1])
                    {
                        z1[c] = c + 1;
                        list2[0] = list2[0] + (0.6 * (list1[i] - list2[0]));
                        list2_1[0] = list2_1[0] + (0.6 * (list1_1[i] - list2_1[0]));
                        t21.Text = Convert.ToString(list2[0]);
                        t22.Text = Convert.ToString(list2_1[0]);
                    }
                    else if (z[(i * 2) + 1] < z[(i * 2)])
                    {
                        z2[c] = c + 1;
                        list2[1] = list2[1] + (0.6 * (list1[i] - list2[1]));
                        list2_1[1] = list2_1[1] + (0.6 * (list1_1[i] - list2_1[1]));
                        t23.Text = Convert.ToString(list2[1]);
                        t24.Text = Convert.ToString(list2_1[1]);
                    }
                    c++;
                }

                if (count == 1)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\n z1 : " + z1[0]
                        + "\r\n\r\n z2 : " + z2[0]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 2)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 3)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\nx3\r\n(1) " + z[4] + "\r\n(2) " + z[5]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 4)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\nx3\r\n(1) " + z[4] + "\r\n(2) " + z[5]
                        + "\r\n\r\nx4\r\n(1) " + z[6] + "\r\n(2) " + z[7]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 5)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\nx3\r\n(1) " + z[4] + "\r\n(2) " + z[5]
                        + "\r\n\r\nx4\r\n(1) " + z[6] + "\r\n(2) " + z[7]
                        + "\r\n\r\nx5\r\n(1) " + z[8] + "\r\n(2) " + z[9]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 6)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\nx3\r\n(1) " + z[4] + "\r\n(2) " + z[5]
                        + "\r\n\r\nx4\r\n(1) " + z[6] + "\r\n(2) " + z[7]
                        + "\r\n\r\nx5\r\n(1) " + z[8] + "\r\n(2) " + z[9]
                        + "\r\n\r\nx6\r\n(1) " + z[10] + "\r\n(2) " + z[11]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 7)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\nx3\r\n(1) " + z[4] + "\r\n(2) " + z[5]
                        + "\r\n\r\nx4\r\n(1) " + z[6] + "\r\n(2) " + z[7]
                        + "\r\n\r\nx5\r\n(1) " + z[8] + "\r\n(2) " + z[9]
                        + "\r\n\r\nx6\r\n(1) " + z[10] + "\r\n(2) " + z[11]
                        + "\r\n\r\nx7\r\n(1) " + z[12] + "\r\n(2) " + z[13]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 8)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\nx3\r\n(1) " + z[4] + "\r\n(2) " + z[5]
                        + "\r\n\r\nx4\r\n(1) " + z[6] + "\r\n(2) " + z[7]
                        + "\r\n\r\nx5\r\n(1) " + z[8] + "\r\n(2) " + z[9]
                        + "\r\n\r\nx6\r\n(1) " + z[10] + "\r\n(2) " + z[11]
                        + "\r\n\r\nx7\r\n(1) " + z[12] + "\r\n(2) " + z[13]
                        + "\r\n\r\nx8\r\n(1) " + z[14] + "\r\n(2) " + z[15]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 9)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\nx3\r\n(1) " + z[4] + "\r\n(2) " + z[5]
                        + "\r\n\r\nx4\r\n(1) " + z[6] + "\r\n(2) " + z[7]
                        + "\r\n\r\nx5\r\n(1) " + z[8] + "\r\n(2) " + z[9]
                        + "\r\n\r\nx6\r\n(1) " + z[10] + "\r\n(2) " + z[11]
                        + "\r\n\r\nx7\r\n(1) " + z[12] + "\r\n(2) " + z[13]
                        + "\r\n\r\nx8\r\n(1) " + z[14] + "\r\n(2) " + z[15]
                        + "\r\n\r\nx9\r\n(1) " + z[16] + "\r\n(2) " + z[17]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
                else if (count == 10)
                {
                    rufrhk.Text = "<거리> (1) (2)는 Z1 Z2 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1]
                        + "\r\n\r\nx2\r\n(1) " + z[2] + "\r\n(2) " + z[3]
                        + "\r\n\r\nx3\r\n(1) " + z[4] + "\r\n(2) " + z[5]
                        + "\r\n\r\nx4\r\n(1) " + z[6] + "\r\n(2) " + z[7]
                        + "\r\n\r\nx5\r\n(1) " + z[8] + "\r\n(2) " + z[9]
                        + "\r\n\r\nx6\r\n(1) " + z[10] + "\r\n(2) " + z[11]
                        + "\r\n\r\nx7\r\n(1) " + z[12] + "\r\n(2) " + z[13]
                        + "\r\n\r\nx8\r\n(1) " + z[14] + "\r\n(2) " + z[15]
                        + "\r\n\r\nx9\r\n(1) " + z[16] + "\r\n(2) " + z[17]
                        + "\r\n\r\nx10\r\n(1) " + z[18] + "\r\n(2) " + z[19]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8] + ", " + z1[9]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8] + ", " + z2[9]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        ;
                }
            }

            else if (list2[0] != 0 && list2_1[0] != 0 && list2[1] != 0 && list2_1[1] != 0 && list2[2] != 0 && list2_1[2] != 0 && list2[3] == 0 && list2_1[3] == 0 && list2[4] == 0 && list2_1[4] == 0) // 가중치 3
            {
                for (i = 0; list1[i] != 0; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        z[k] = Math.Sqrt(Math.Pow((list1[i] - list2[j]), 2) + Math.Pow((list1_1[i] - list2_1[j]), 2));
                        k++;
                    }

                    if (z[(i * 3)] < z[(i * 3) + 1] && z[(i * 3)] < z[(i * 3) + 2])
                    {
                        z1[c] = c + 1;
                        list2[0] = list2[0] + (0.6 * (list1[i] - list2[0]));
                        list2_1[0] = list2_1[0] + (0.6 * (list1_1[i] - list2_1[0]));
                        t21.Text = Convert.ToString(list2[0]);
                        t22.Text = Convert.ToString(list2_1[0]);
                    }
                    else if (z[(i * 3) + 1] < z[(i * 3)] && z[(i * 3) + 1] < z[(i * 3) + 2])
                    {
                        z2[c] = c + 1;
                        list2[1] = list2[1] + (0.6 * (list1[i] - list2[1]));
                        list2_1[1] = list2_1[1] + (0.6 * (list1_1[i] - list2_1[1]));
                        t23.Text = Convert.ToString(list2[1]);
                        t24.Text = Convert.ToString(list2_1[1]);
                    }
                    else if (z[(i * 3) + 2] < z[(i * 3)] && z[(i * 3) + 2] < z[(i * 3) + 1])
                    {
                        z3[c] = c + 1;
                        list2[2] = list2[2] + (0.6 * (list1[i] - list2[2]));
                        list2_1[2] = list2_1[2] + (0.6 * (list1_1[i] - list2_1[2]));
                        t25.Text = Convert.ToString(list2[2]);
                        t26.Text = Convert.ToString(list2_1[2]);
                    }
                    c++;
                }

                if (count == 1)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\n z1 : " + z1[0]
                        + "\r\n\r\n z2 : " + z2[0]
                        + "\r\n\r\n z3 : " + z3[0]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 2)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 3)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\nx3\r\n(1) " + z[6] + "\r\n(2) " + z[7] + "\r\n(3) " + z[8]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 4)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\nx3\r\n(1) " + z[6] + "\r\n(2) " + z[7] + "\r\n(3) " + z[8]
                        + "\r\n\r\nx4\r\n(1) " + z[9] + "\r\n(2) " + z[10] + "\r\n(3) " + z[11]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 5)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\nx3\r\n(1) " + z[6] + "\r\n(2) " + z[7] + "\r\n(3) " + z[8]
                        + "\r\n\r\nx4\r\n(1) " + z[9] + "\r\n(2) " + z[10] + "\r\n(3) " + z[11]
                        + "\r\n\r\nx5\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 6)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\nx3\r\n(1) " + z[6] + "\r\n(2) " + z[7] + "\r\n(3) " + z[8]
                        + "\r\n\r\nx4\r\n(1) " + z[9] + "\r\n(2) " + z[10] + "\r\n(3) " + z[11]
                        + "\r\n\r\nx5\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14]
                        + "\r\n\r\nx6\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 7)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\nx3\r\n(1) " + z[6] + "\r\n(2) " + z[7] + "\r\n(3) " + z[8]
                        + "\r\n\r\nx4\r\n(1) " + z[9] + "\r\n(2) " + z[10] + "\r\n(3) " + z[11]
                        + "\r\n\r\nx5\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14]
                        + "\r\n\r\nx6\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17]
                        + "\r\n\r\nx7\r\n(1) " + z[18] + "\r\n(2) " + z[19] + "\r\n(3) " + z[20]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 8)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\nx3\r\n(1) " + z[6] + "\r\n(2) " + z[7] + "\r\n(3) " + z[8]
                        + "\r\n\r\nx4\r\n(1) " + z[9] + "\r\n(2) " + z[10] + "\r\n(3) " + z[11]
                        + "\r\n\r\nx5\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14]
                        + "\r\n\r\nx6\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17]
                        + "\r\n\r\nx7\r\n(1) " + z[18] + "\r\n(2) " + z[19] + "\r\n(3) " + z[20]
                        + "\r\n\r\nx8\r\n(1) " + z[21] + "\r\n(2) " + z[22] + "\r\n(3) " + z[23]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 9)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\nx3\r\n(1) " + z[6] + "\r\n(2) " + z[7] + "\r\n(3) " + z[8]
                        + "\r\n\r\nx4\r\n(1) " + z[9] + "\r\n(2) " + z[10] + "\r\n(3) " + z[11]
                        + "\r\n\r\nx5\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14]
                        + "\r\n\r\nx6\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17]
                        + "\r\n\r\nx7\r\n(1) " + z[18] + "\r\n(2) " + z[19] + "\r\n(3) " + z[20]
                        + "\r\n\r\nx8\r\n(1) " + z[21] + "\r\n(2) " + z[22] + "\r\n(3) " + z[23]
                        + "\r\n\r\nx9\r\n(1) " + z[24] + "\r\n(2) " + z[25] + "\r\n(3) " + z[26]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
                else if (count == 10)
                {
                    rufrhk.Text = "<거리> (1) (2) (3)은 Z1 Z2 Z3 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2]
                        + "\r\n\r\nx2\r\n(1) " + z[3] + "\r\n(2) " + z[4] + "\r\n(3) " + z[5]
                        + "\r\n\r\nx3\r\n(1) " + z[6] + "\r\n(2) " + z[7] + "\r\n(3) " + z[8]
                        + "\r\n\r\nx4\r\n(1) " + z[9] + "\r\n(2) " + z[10] + "\r\n(3) " + z[11]
                        + "\r\n\r\nx5\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14]
                        + "\r\n\r\nx6\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17]
                        + "\r\n\r\nx7\r\n(1) " + z[18] + "\r\n(2) " + z[19] + "\r\n(3) " + z[20]
                        + "\r\n\r\nx8\r\n(1) " + z[21] + "\r\n(2) " + z[22] + "\r\n(3) " + z[23]
                        + "\r\n\r\nx9\r\n(1) " + z[24] + "\r\n(2) " + z[25] + "\r\n(3) " + z[26]
                        + "\r\n\r\nx10\r\n(1) " + z[27] + "\r\n(2) " + z[28] + "\r\n(3) " + z[29]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8] + ", " + z1[9]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8] + ", " + z2[9]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8] + ", " + z3[9]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        ;
                }
            }

            else if (list2[0] != 0 && list2_1[0] != 0 && list2[1] != 0 && list2_1[1] != 0 && list2[2] != 0 && list2_1[2] != 0 && list2[3] != 0 && list2_1[3] != 0 && list2[4] == 0 && list2_1[4] == 0) // 가중치 4
            {
                for (i = 0; list1[i] != 0; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        z[k] = Math.Sqrt(Math.Pow((list1[i] - list2[j]), 2) + Math.Pow((list1_1[i] - list2_1[j]), 2));
                        k++;
                    }

                    if (z[(i * 4)] < z[(i * 4) + 1] && z[(i * 4)] < z[(i * 4) + 2] && z[(i * 4)] < z[(i * 4) + 3])
                    {
                        z1[c] = c + 1;
                        list2[0] = list2[0] + (0.6 * (list1[i] - list2[0]));
                        list2_1[0] = list2_1[0] + (0.6 * (list1_1[i] - list2_1[0]));
                        t21.Text = Convert.ToString(list2[0]);
                        t22.Text = Convert.ToString(list2_1[0]);
                    }
                    else if (z[(i * 4) + 1] < z[(i * 4)] && z[(i * 4) + 1] < z[(i * 4) + 2] && z[(i * 4) + 1] < z[(i * 4) + 3])
                    {
                        z2[c] = c + 1;
                        list2[1] = list2[1] + (0.6 * (list1[i] - list2[1]));
                        list2_1[1] = list2_1[1] + (0.6 * (list1_1[i] - list2_1[1]));
                        t23.Text = Convert.ToString(list2[1]);
                        t24.Text = Convert.ToString(list2_1[1]);
                    }
                    else if (z[(i * 4) + 2] < z[(i * 4)] && z[(i * 4) + 2] < z[(i * 4) + 1] && z[(i * 4) + 2] < z[(i * 4) + 3])
                    {
                        z3[c] = c + 1;
                        list2[2] = list2[2] + (0.6 * (list1[i] - list2[2]));
                        list2_1[2] = list2_1[2] + (0.6 * (list1_1[i] - list2_1[2]));
                        t25.Text = Convert.ToString(list2[2]);
                        t26.Text = Convert.ToString(list2_1[2]);
                    }
                    else if (z[(i * 4) + 3] < z[(i * 4)] && z[(i * 4) + 3] < z[(i * 4) + 1] && z[(i * 4) + 3] < z[(i * 4) + 2])
                    {
                        z4[c] = c + 1;
                        list2[3] = list2[3] + (0.6 * (list1[i] - list2[3]));
                        list2_1[3] = list2_1[3] + (0.6 * (list1_1[i] - list2_1[3]));
                        t27.Text = Convert.ToString(list2[3]);
                        t28.Text = Convert.ToString(list2_1[3]);
                    }
                    c++;
                }


                if (count == 1)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\n z1 : " + z1[0]
                        + "\r\n\r\n z2 : " + z2[0]
                        + "\r\n\r\n z3 : " + z3[0]
                        + "\r\n\r\n z4 : " + z4[0]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 2)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 3)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\nx3\r\n(1) " + z[8] + "\r\n(2) " + z[9] + "\r\n(3) " + z[10] + "\r\n(4) " + z[11]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 4)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\nx3\r\n(1) " + z[8] + "\r\n(2) " + z[9] + "\r\n(3) " + z[10] + "\r\n(4) " + z[11]
                        + "\r\n\r\nx4\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14] + "\r\n(4) " + z[15]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 5)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\nx3\r\n(1) " + z[8] + "\r\n(2) " + z[9] + "\r\n(3) " + z[10] + "\r\n(4) " + z[11]
                        + "\r\n\r\nx4\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14] + "\r\n(4) " + z[15]
                        + "\r\n\r\nx5\r\n(1) " + z[16] + "\r\n(2) " + z[17] + "\r\n(3) " + z[18] + "\r\n(4) " + z[19]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 6)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\nx3\r\n(1) " + z[8] + "\r\n(2) " + z[9] + "\r\n(3) " + z[10] + "\r\n(4) " + z[11]
                        + "\r\n\r\nx4\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14] + "\r\n(4) " + z[15]
                        + "\r\n\r\nx5\r\n(1) " + z[16] + "\r\n(2) " + z[17] + "\r\n(3) " + z[18] + "\r\n(4) " + z[19]
                        + "\r\n\r\nx6\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 7)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\nx3\r\n(1) " + z[8] + "\r\n(2) " + z[9] + "\r\n(3) " + z[10] + "\r\n(4) " + z[11]
                        + "\r\n\r\nx4\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14] + "\r\n(4) " + z[15]
                        + "\r\n\r\nx5\r\n(1) " + z[16] + "\r\n(2) " + z[17] + "\r\n(3) " + z[18] + "\r\n(4) " + z[19]
                        + "\r\n\r\nx6\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23]
                        + "\r\n\r\nx7\r\n(1) " + z[24] + "\r\n(2) " + z[25] + "\r\n(3) " + z[26] + "\r\n(4) " + z[27]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 8)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\nx3\r\n(1) " + z[8] + "\r\n(2) " + z[9] + "\r\n(3) " + z[10] + "\r\n(4) " + z[11]
                        + "\r\n\r\nx4\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14] + "\r\n(4) " + z[15]
                        + "\r\n\r\nx5\r\n(1) " + z[16] + "\r\n(2) " + z[17] + "\r\n(3) " + z[18] + "\r\n(4) " + z[19]
                        + "\r\n\r\nx6\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23]
                        + "\r\n\r\nx7\r\n(1) " + z[24] + "\r\n(2) " + z[25] + "\r\n(3) " + z[26] + "\r\n(4) " + z[27]
                        + "\r\n\r\nx8\r\n(1) " + z[28] + "\r\n(2) " + z[29] + "\r\n(3) " + z[30] + "\r\n(4) " + z[31]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 9)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\nx3\r\n(1) " + z[8] + "\r\n(2) " + z[9] + "\r\n(3) " + z[10] + "\r\n(4) " + z[11]
                        + "\r\n\r\nx4\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14] + "\r\n(4) " + z[15]
                        + "\r\n\r\nx5\r\n(1) " + z[16] + "\r\n(2) " + z[17] + "\r\n(3) " + z[18] + "\r\n(4) " + z[19]
                        + "\r\n\r\nx6\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23]
                        + "\r\n\r\nx7\r\n(1) " + z[24] + "\r\n(2) " + z[25] + "\r\n(3) " + z[26] + "\r\n(4) " + z[27]
                        + "\r\n\r\nx8\r\n(1) " + z[28] + "\r\n(2) " + z[29] + "\r\n(3) " + z[30] + "\r\n(4) " + z[31]
                        + "\r\n\r\nx9\r\n(1) " + z[32] + "\r\n(2) " + z[33] + "\r\n(3) " + z[34] + "\r\n(4) " + z[35]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7] + ", " + z4[8]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
                else if (count == 10)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4)은 Z1 Z2 Z3 Z4 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3]
                        + "\r\n\r\nx2\r\n(1) " + z[4] + "\r\n(2) " + z[5] + "\r\n(3) " + z[6] + "\r\n(4) " + z[7]
                        + "\r\n\r\nx3\r\n(1) " + z[8] + "\r\n(2) " + z[9] + "\r\n(3) " + z[10] + "\r\n(4) " + z[11]
                        + "\r\n\r\nx4\r\n(1) " + z[12] + "\r\n(2) " + z[13] + "\r\n(3) " + z[14] + "\r\n(4) " + z[15]
                        + "\r\n\r\nx5\r\n(1) " + z[16] + "\r\n(2) " + z[17] + "\r\n(3) " + z[18] + "\r\n(4) " + z[19]
                        + "\r\n\r\nx6\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23]
                        + "\r\n\r\nx7\r\n(1) " + z[24] + "\r\n(2) " + z[25] + "\r\n(3) " + z[26] + "\r\n(4) " + z[27]
                        + "\r\n\r\nx8\r\n(1) " + z[28] + "\r\n(2) " + z[29] + "\r\n(3) " + z[30] + "\r\n(4) " + z[31]
                        + "\r\n\r\nx9\r\n(1) " + z[32] + "\r\n(2) " + z[33] + "\r\n(3) " + z[34] + "\r\n(4) " + z[35]
                        + "\r\n\r\nx10\r\n(1) " + z[36] + "\r\n(2) " + z[37] + "\r\n(3) " + z[38] + "\r\n(4) " + z[39]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8] + ", " + z1[9]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8] + ", " + z2[9]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8] + ", " + z3[9]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7] + ", " + z4[8] + ", " + z4[9]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        ;
                }
            }

            else if (list2[0] != 0 && list2_1[0] != 0 && list2[1] != 0 && list2_1[1] != 0 && list2[2] != 0 && list2_1[2] != 0 && list2[3] != 0 && list2_1[3] != 0 && list2[4] != 0 && list2_1[4] != 0) // 가중치 5
            {
                for (i = 0; list1[i] != 0; i++)
                {
                    for (j = 0; j < 5; j++)
                    {
                        z[k] = Math.Sqrt(Math.Pow((list1[i] - list2[j]), 2) + Math.Pow((list1_1[i] - list2_1[j]), 2));
                        k++;
                    }

                    if (z[(i * 5)] < z[(i * 5) + 1] && z[(i * 5)] < z[(i * 5) + 2] && z[(i * 5)] < z[(i * 5) + 3] && z[(i * 5)] < z[(i * 5) + 4])
                    {
                        z1[c] = c + 1;
                        list2[0] = list2[0] + (0.6 * (list1[i] - list2[0]));
                        list2_1[0] = list2_1[0] + (0.6 * (list1_1[i] - list2_1[0]));
                        t21.Text = Convert.ToString(list2[0]);
                        t22.Text = Convert.ToString(list2_1[0]);
                    }
                    else if (z[(i * 5) + 1] < z[(i * 5)] && z[(i * 5) + 1] < z[(i * 5) + 2] && z[(i * 5) + 1] < z[(i * 5) + 3] && z[(i * 5) + 1] < z[(i * 5) + 4])
                    {
                        z2[c] = c + 1;
                        list2[1] = list2[1] + (0.6 * (list1[i] - list2[1]));
                        list2_1[1] = list2_1[1] + (0.6 * (list1_1[i] - list2_1[1]));
                        t23.Text = Convert.ToString(list2[1]);
                        t24.Text = Convert.ToString(list2_1[1]);
                    }
                    else if (z[(i * 5) + 2] < z[(i * 5)] && z[(i * 5) + 2] < z[(i * 5) + 1] && z[(i * 5) + 2] < z[(i * 5) + 3] && z[(i * 5) + 2] < z[(i * 5) + 4])
                    {
                        z3[c] = c + 1;
                        list2[2] = list2[2] + (0.6 * (list1[i] - list2[2]));
                        list2_1[2] = list2_1[2] + (0.6 * (list1_1[i] - list2_1[2]));
                        t25.Text = Convert.ToString(list2[2]);
                        t26.Text = Convert.ToString(list2_1[2]);
                    }
                    else if (z[(i * 5) + 3] < z[(i * 5)] && z[(i * 5) + 3] < z[(i * 5) + 1] && z[(i * 5) + 3] < z[(i * 5) + 2] && z[(i * 5) + 3] < z[(i * 5) + 4])
                    {
                        z4[c] = c + 1;
                        list2[3] = list2[3] + (0.6 * (list1[i] - list2[3]));
                        list2_1[3] = list2_1[3] + (0.6 * (list1_1[i] - list2_1[3]));
                        t27.Text = Convert.ToString(list2[3]);
                        t28.Text = Convert.ToString(list2_1[3]);
                    }
                    else if (z[(i * 5) + 4] < z[(i * 5)] && z[(i * 5) + 4] < z[(i * 5) + 1] && z[(i * 5) + 4] < z[(i * 5) + 2] && z[(i * 5) + 4] < z[(i * 5) + 3])
                    {
                        z5[c] = c + 1;
                        list2[4] = list2[4] + (0.6 * (list1[i] - list2[4]));
                        list2_1[4] = list2_1[4] + (0.6 * (list1_1[i] - list2_1[4]));
                        t29.Text = Convert.ToString(list2[4]);
                        t30.Text = Convert.ToString(list2_1[4]);
                    }
                    c++;
                }

                if (count == 1)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\n z1 : " + z1[0]
                        + "\r\n\r\n z2 : " + z2[0]
                        + "\r\n\r\n z3 : " + z3[0]
                        + "\r\n\r\n z4 : " + z4[0]
                        + "\r\n\r\n z5 : " + z5[0]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 2)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 3)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\nx3\r\n(1) " + z[10] + "\r\n(2) " + z[11] + "\r\n(3) " + z[12] + "\r\n(4) " + z[13] + "\r\n(5) " + z[14]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1] + ", " + z5[2]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 4)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\nx3\r\n(1) " + z[10] + "\r\n(2) " + z[11] + "\r\n(3) " + z[12] + "\r\n(4) " + z[13] + "\r\n(5) " + z[14]
                        + "\r\n\r\nx4\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17] + "\r\n(4) " + z[18] + "\r\n(5) " + z[19]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1] + ", " + z5[2] + ", " + z5[3]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 5)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\nx3\r\n(1) " + z[10] + "\r\n(2) " + z[11] + "\r\n(3) " + z[12] + "\r\n(4) " + z[13] + "\r\n(5) " + z[14]
                        + "\r\n\r\nx4\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17] + "\r\n(4) " + z[18] + "\r\n(5) " + z[19]
                        + "\r\n\r\nx5\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23] + "\r\n(5) " + z[24]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1] + ", " + z5[2] + ", " + z5[3] + ", " + z5[4]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 6)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\nx3\r\n(1) " + z[10] + "\r\n(2) " + z[11] + "\r\n(3) " + z[12] + "\r\n(4) " + z[13] + "\r\n(5) " + z[14]
                        + "\r\n\r\nx4\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17] + "\r\n(4) " + z[18] + "\r\n(5) " + z[19]
                        + "\r\n\r\nx5\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23] + "\r\n(5) " + z[24]
                        + "\r\n\r\nx6\r\n(1) " + z[25] + "\r\n(2) " + z[26] + "\r\n(3) " + z[27] + "\r\n(4) " + z[28] + "\r\n(5) " + z[29]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1] + ", " + z5[2] + ", " + z5[3] + ", " + z5[4] + ", " + z5[5]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 7)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\nx3\r\n(1) " + z[10] + "\r\n(2) " + z[11] + "\r\n(3) " + z[12] + "\r\n(4) " + z[13] + "\r\n(5) " + z[14]
                        + "\r\n\r\nx4\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17] + "\r\n(4) " + z[18] + "\r\n(5) " + z[19]
                        + "\r\n\r\nx5\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23] + "\r\n(5) " + z[24]
                        + "\r\n\r\nx6\r\n(1) " + z[25] + "\r\n(2) " + z[26] + "\r\n(3) " + z[27] + "\r\n(4) " + z[28] + "\r\n(5) " + z[29]
                        + "\r\n\r\nx7\r\n(1) " + z[30] + "\r\n(2) " + z[31] + "\r\n(3) " + z[32] + "\r\n(4) " + z[33] + "\r\n(5) " + z[32]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1] + ", " + z5[2] + ", " + z5[3] + ", " + z5[4] + ", " + z5[5] + ", " + z5[6]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 8)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\nx3\r\n(1) " + z[10] + "\r\n(2) " + z[11] + "\r\n(3) " + z[12] + "\r\n(4) " + z[13] + "\r\n(5) " + z[14]
                        + "\r\n\r\nx4\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17] + "\r\n(4) " + z[18] + "\r\n(5) " + z[19]
                        + "\r\n\r\nx5\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23] + "\r\n(5) " + z[24]
                        + "\r\n\r\nx6\r\n(1) " + z[25] + "\r\n(2) " + z[26] + "\r\n(3) " + z[27] + "\r\n(4) " + z[28] + "\r\n(5) " + z[29]
                        + "\r\n\r\nx7\r\n(1) " + z[30] + "\r\n(2) " + z[31] + "\r\n(3) " + z[32] + "\r\n(4) " + z[33] + "\r\n(5) " + z[32]
                        + "\r\n\r\nx8\r\n(1) " + z[35] + "\r\n(2) " + z[36] + "\r\n(3) " + z[37] + "\r\n(4) " + z[38] + "\r\n(5) " + z[37]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1] + ", " + z5[2] + ", " + z5[3] + ", " + z5[4] + ", " + z5[5] + ", " + z5[6] + ", " + z5[7]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 9)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\nx3\r\n(1) " + z[10] + "\r\n(2) " + z[11] + "\r\n(3) " + z[12] + "\r\n(4) " + z[13] + "\r\n(5) " + z[14]
                        + "\r\n\r\nx4\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17] + "\r\n(4) " + z[18] + "\r\n(5) " + z[19]
                        + "\r\n\r\nx5\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23] + "\r\n(5) " + z[24]
                        + "\r\n\r\nx6\r\n(1) " + z[25] + "\r\n(2) " + z[26] + "\r\n(3) " + z[27] + "\r\n(4) " + z[28] + "\r\n(5) " + z[29]
                        + "\r\n\r\nx7\r\n(1) " + z[30] + "\r\n(2) " + z[31] + "\r\n(3) " + z[32] + "\r\n(4) " + z[33] + "\r\n(5) " + z[32]
                        + "\r\n\r\nx8\r\n(1) " + z[35] + "\r\n(2) " + z[36] + "\r\n(3) " + z[37] + "\r\n(4) " + z[38] + "\r\n(5) " + z[37]
                        + "\r\n\r\nx9\r\n(1) " + z[40] + "\r\n(2) " + z[41] + "\r\n(3) " + z[42] + "\r\n(4) " + z[43] + "\r\n(5) " + z[44]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7] + ", " + z4[8]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1] + ", " + z5[2] + ", " + z5[3] + ", " + z5[4] + ", " + z5[5] + ", " + z5[6] + ", " + z5[7] + ", " + z5[8]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
                else if (count == 10)
                {
                    rufrhk.Text = "<거리> (1) (2) (3) (4) (5)은 Z1 Z2 Z3 Z4 Z5 군집이 반복되어 갱신 된 거리 값입니다.\r\nx1\r\n(1) " + z[0] + "\r\n(2) " + z[1] + "\r\n(3) " + z[2] + "\r\n(4) " + z[3] + "\r\n(5) " + z[4]
                        + "\r\n\r\nx2\r\n(1) " + z[5] + "\r\n(2) " + z[6] + "\r\n(3) " + z[7] + "\r\n(4) " + z[8] + "\r\n(5) " + z[9]
                        + "\r\n\r\nx3\r\n(1) " + z[10] + "\r\n(2) " + z[11] + "\r\n(3) " + z[12] + "\r\n(4) " + z[13] + "\r\n(5) " + z[14]
                        + "\r\n\r\nx4\r\n(1) " + z[15] + "\r\n(2) " + z[16] + "\r\n(3) " + z[17] + "\r\n(4) " + z[18] + "\r\n(5) " + z[19]
                        + "\r\n\r\nx5\r\n(1) " + z[20] + "\r\n(2) " + z[21] + "\r\n(3) " + z[22] + "\r\n(4) " + z[23] + "\r\n(5) " + z[24]
                        + "\r\n\r\nx6\r\n(1) " + z[25] + "\r\n(2) " + z[26] + "\r\n(3) " + z[27] + "\r\n(4) " + z[28] + "\r\n(5) " + z[29]
                        + "\r\n\r\nx7\r\n(1) " + z[30] + "\r\n(2) " + z[31] + "\r\n(3) " + z[32] + "\r\n(4) " + z[33] + "\r\n(5) " + z[32]
                        + "\r\n\r\nx8\r\n(1) " + z[35] + "\r\n(2) " + z[36] + "\r\n(3) " + z[37] + "\r\n(4) " + z[38] + "\r\n(5) " + z[37]
                        + "\r\n\r\nx9\r\n(1) " + z[40] + "\r\n(2) " + z[41] + "\r\n(3) " + z[42] + "\r\n(4) " + z[43] + "\r\n(5) " + z[44]
                        + "\r\n\r\nx10\r\n(1) " + z[45] + "\r\n(2) " + z[46] + "\r\n(3) " + z[47] + "\r\n(4) " + z[48] + "\r\n(5) " + z[49]
                        + "\r\n\r\n z1 : " + z1[0] + ", " + z1[1] + ", " + z1[2] + ", " + z1[3] + ", " + z1[4] + ", " + z1[5] + ", " + z1[6] + ", " + z1[7] + ", " + z1[8] + ", " + z1[9]
                        + "\r\n\r\n z2 : " + z2[0] + ", " + z2[1] + ", " + z2[2] + ", " + z2[3] + ", " + z2[4] + ", " + z2[5] + ", " + z2[6] + ", " + z2[7] + ", " + z2[8] + ", " + z2[9]
                        + "\r\n\r\n z3 : " + z3[0] + ", " + z3[1] + ", " + z3[2] + ", " + z3[3] + ", " + z3[4] + ", " + z3[5] + ", " + z3[6] + ", " + z3[7] + ", " + z3[8] + ", " + z3[9]
                        + "\r\n\r\n z4 : " + z4[0] + ", " + z4[1] + ", " + z4[2] + ", " + z4[3] + ", " + z4[4] + ", " + z4[5] + ", " + z4[6] + ", " + z4[7] + ", " + z4[8] + ", " + z4[9]
                        + "\r\n\r\n z5 : " + z5[0] + ", " + z5[1] + ", " + z5[2] + ", " + z5[3] + ", " + z5[4] + ", " + z5[5] + ", " + z5[6] + ", " + z5[7] + ", " + z5[8] + ", " + z5[9]
                        + "\r\n\r\n z1 가중치 : ( " + Convert.ToString(t21.Text) + ", " + Convert.ToString(t22.Text) + " )T"
                        + "\r\n\r\n z2 가중치 : ( " + Convert.ToString(t23.Text) + ", " + Convert.ToString(t24.Text) + " )T"
                        + "\r\n\r\n z3 가중치 : ( " + Convert.ToString(t25.Text) + ", " + Convert.ToString(t26.Text) + " )T"
                        + "\r\n\r\n z4 가중치 : ( " + Convert.ToString(t27.Text) + ", " + Convert.ToString(t28.Text) + " )T"
                        + "\r\n\r\n z5 가중치 : ( " + Convert.ToString(t29.Text) + ", " + Convert.ToString(t30.Text) + " )T"
                        ;
                }
            }
        }        
    }
}