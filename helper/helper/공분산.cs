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
    public partial class 공분산 : Form
    {
        double[] list1 = new double[16]; //1번식
        double[] list1_1 = new double[16]; //1번식
        double[] list2 = new double[16]; //2번식
        double[] list2_1 = new double[16]; //2번식
        double[] result1 = new double[16]; //1번 결과
        double[] result2 = new double[16]; //2번 결과
        double[] result3 = new double[16]; //1번 결과
        double[] rhdqns1 = new double[8]; //공분산1번 결과
        double[] rhdqns2 = new double[8]; //공분산2번 결과
        double[] rhdqns3 = new double[8]; //공분산3번 결과
        double[] rhdqns4 = new double[8]; //공분산4번 결과
        double[] distance = new double[100]; //거리와 유사도
        int r = 0;
        public 공분산()
        {
            InitializeComponent();
            t1.Text = "0"; t9.Text = "0";
            t2.Text = "0"; t10.Text = "0";
            t3.Text = "0"; t11.Text = "0";
            t4.Text = "0"; t12.Text = "0";
            t5.Text = "0"; t13.Text = "0";
            t6.Text = "0"; t14.Text = "0";
            t7.Text = "0"; t15.Text = "0";
            t8.Text = "0"; t16.Text = "0";

            t21.Text = "0"; t18.Text = "0";
            t22.Text = "0"; t19.Text = "0";
            t23.Text = "0"; t20.Text = "0";
            t24.Text = "0"; t17.Text = "0";
            t25.Text = "0"; t31.Text = "0";
            t26.Text = "0"; t29.Text = "0";
            t27.Text = "0"; t30.Text = "0";
            t28.Text = "0"; t32.Text = "0";
        }

        private void rufrhk_TextChanged(object sender, EventArgs e)
        {

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

            list2[0] = Convert.ToDouble(t17.Text); list2_1[0] = Convert.ToDouble(t18.Text);
            list2[1] = Convert.ToDouble(t19.Text); list2_1[1] = Convert.ToDouble(t20.Text);
            list2[2] = Convert.ToDouble(t21.Text); list2_1[2] = Convert.ToDouble(t22.Text);
            list2[3] = Convert.ToDouble(t23.Text); list2_1[3] = Convert.ToDouble(t24.Text);
            list2[4] = Convert.ToDouble(t25.Text); list2_1[4] = Convert.ToDouble(t26.Text);
            list2[5] = Convert.ToDouble(t27.Text); list2_1[5] = Convert.ToDouble(t28.Text);
            list2[6] = Convert.ToDouble(t29.Text); list2_1[6] = Convert.ToDouble(t30.Text);
            list2[7] = Convert.ToDouble(t31.Text); list2_1[7] = Convert.ToDouble(t32.Text);


            if (qnsfb.SelectedItem.ToString() == "평균") // 평균 계산 완료
            {
                int i = 0, j = 0;
                result1[0] = 0;
                result1[1] = 0;
                result1[2] = 0;
                result1[3] = 0;


                if (list1[i] != 0 && list2[j] == 0)
                {
                    for (i = 0; list1[i] != 0 && i < 8; i++)
                    {
                        result1[0] += list1[i];
                        result1[1] += list1_1[i];                        
                    }
                    result1[0] /= i; // x합
                    result1[1] /= i; // y합

                    rufrhk.Text = "1번식의 평균벡터 : (" + result1[0]  + ", " + result1[1] + ")";

                }
                else if (list2[j] != 0 && list1[i] == 0)
                {
                    for (j = 0; list2[j] != 0 || j < 8; j++)
                    {
                        result1[2] += list2[j];
                        result1[3] += list2_1[j];
                    }
                    result1[2] /= j; // x합
                    result1[3] /= j; // y합

                    rufrhk.Text = "2번식의 평균벡터 : (" + result1[2] + ", " + result1[3] + ")";

                }
                else if (list1[i] != 0 && list2[j] != 0)
                {
                    for (i = 0; list1[i] != 0 && i < 8; i++)
                    {
                        result1[0] += list1[i];
                        result1[1] += list1_1[i];
                    }
                    for (j = 0; list2[j] != 0 && j < 8; j++)
                    {
                        result1[2] += list2[j];
                        result1[3] += list2_1[j];
                    }

                    result1[0] /= i; // x합
                    result1[1] /= i; // y합
                    result1[2] /= j; // x합
                    result1[3] /= j; // y합

                    rufrhk.Text = "1번식의 평균벡터 : (" + result1[0] + ", " + result1[1] + ")\r\n\r\n" + "2번식의 평균벡터 : (" + result1[2] + ", " + result1[3] + ")";

                }                
                else
                    rufrhk.Text = "잘못 입력되었습니다.";
            }
            else if (qnsfb.SelectedItem.ToString() == "공분산")
            {
                int i = 0, r = 0;
                double s1 = 0, s2 = 0, s3 = 0, s4 = 0;
                if (list1[i] != 0)
                {
                    for (i = 0; list1[i] != 0 && i < 8; i++)
                    {
                        result2[i] = list1[i] - result1[0];
                        result3[i] = list1_1[i] - result1[1];
                    }                    
                    for (r = 0; list1[r] != 0; r++)
                    {
                        rhdqns1[r] = result2[r] * result2[r];
                        rhdqns2[r] = result2[r] * result3[r];
                        rhdqns3[r] = result3[r] * result2[r];
                        rhdqns4[r] = result3[r] * result3[r];
                        s1 += rhdqns1[r];
                        s2 += rhdqns2[r];
                        s3 += rhdqns3[r];
                        s4 += rhdqns4[r];
                    }                    
                    s1 /= r;
                    s2 /= r;
                    s3 /= r;
                    s4 /= r;
                    if (i == 1)
                    {
                        rufrhk.Text =
                        "<1번>\r\n" + "X1의 분산 : [" + rhdqns1[0] + "  " + rhdqns2[0] + "]\r\n" + "X2의 분산 : [" + rhdqns3[0] + "  " + rhdqns4[0] + "]\r\n\r\n" +
                        "<공분산>\r\n" + "X11, X12 : [" + s1 + "  " + s2 + "]\r\n" + "X21, X22 : [" + s3 + "  " + s4 + "]";
                    }
                    else if (i == 2)
                    {
                        rufrhk.Text =
                        "<1번>\r\n" + "X1의 분산 : [" + rhdqns1[0] + "  " + rhdqns2[0] + "]\r\n" + "X2의 분산 : [" + rhdqns3[0] + "  " + rhdqns4[0] + "]\r\n\r\n" +
                        "<2번>\r\n" + "X1의 분산 : [" + rhdqns1[1] + "  " + rhdqns2[1] + "]\r\n" + "X2의 분산 : [" + rhdqns3[1] + "  " + rhdqns4[1] + "]\r\n\r\n" +
                        "<공분산>\r\n" + "X11, X12 : [" + s1 + "  " + s2 + "]\r\n" + "X21, X22 : [" + s3 + "  " + s4 + "]";
                    }
                    else if (i == 3)
                    {
                        rufrhk.Text =
                        "<1번>\r\n" + "X1의 분산 : [" + rhdqns1[0] + "  " + rhdqns2[0] + "]\r\n" + "X2의 분산 : [" + rhdqns3[0] + "  " + rhdqns4[0] + "]\r\n\r\n" +
                        "<2번>\r\n" + "X1의 분산 : [" + rhdqns1[1] + "  " + rhdqns2[1] + "]\r\n" + "X2의 분산 : [" + rhdqns3[1] + "  " + rhdqns4[1] + "]\r\n\r\n" +
                        "<3번>\r\n" + "X1의 분산 : [" + rhdqns1[2] + "  " + rhdqns2[2] + "]\r\n" + "X2의 분산 : [" + rhdqns3[2] + "  " + rhdqns4[2] + "]\r\n\r\n" +
                        "<공분산>\r\n" + "X11, X12 : [" + s1 + "  " + s2 + "]\r\n" + "X21, X22 : [" + s3 + "  " + s4 + "]";
                    }
                    else if (i == 4)
                    {
                        rufrhk.Text =
                        "<1번>\r\n" + "X1의 분산 : [" + rhdqns1[0] + "  " + rhdqns2[0] + "]\r\n" + "X2의 분산 : [" + rhdqns3[0] + "  " + rhdqns4[0] + "]\r\n\r\n" +
                        "<2번>\r\n" + "X1의 분산 : [" + rhdqns1[1] + "  " + rhdqns2[1] + "]\r\n" + "X2의 분산 : [" + rhdqns3[1] + "  " + rhdqns4[1] + "]\r\n\r\n" +
                        "<3번>\r\n" + "X1의 분산 : [" + rhdqns1[2] + "  " + rhdqns2[2] + "]\r\n" + "X2의 분산 : [" + rhdqns3[2] + "  " + rhdqns4[2] + "]\r\n\r\n" +
                        "<4번>\r\n" + "X1의 분산 : [" + rhdqns1[3] + "  " + rhdqns2[3] + "]\r\n" + "X2의 분산 : [" + rhdqns3[3] + "  " + rhdqns4[3] + "]\r\n\r\n" +
                        "<공분산>\r\n" + "X11, X12 : [" + s1 + "  " + s2 + "]\r\n" + "X21, X22 : [" + s3 + "  " + s4 + "]";
                    }
                    else if (i == 5)
                    {
                        rufrhk.Text =
                        "<1번>\r\n" + "X1의 분산 : [" + rhdqns1[0] + "  " + rhdqns2[0] + "]\r\n" + "X2의 분산 : [" + rhdqns3[0] + "  " + rhdqns4[0] + "]\r\n\r\n" +
                        "<2번>\r\n" + "X1의 분산 : [" + rhdqns1[1] + "  " + rhdqns2[1] + "]\r\n" + "X2의 분산 : [" + rhdqns3[1] + "  " + rhdqns4[1] + "]\r\n\r\n" +
                        "<3번>\r\n" + "X1의 분산 : [" + rhdqns1[2] + "  " + rhdqns2[2] + "]\r\n" + "X2의 분산 : [" + rhdqns3[2] + "  " + rhdqns4[2] + "]\r\n\r\n" +
                        "<4번>\r\n" + "X1의 분산 : [" + rhdqns1[3] + "  " + rhdqns2[3] + "]\r\n" + "X2의 분산 : [" + rhdqns3[3] + "  " + rhdqns4[3] + "]\r\n\r\n" +
                        "<5번>\r\n" + "X1의 분산 : [" + rhdqns1[4] + "  " + rhdqns2[4] + "]\r\n" + "X2의 분산 : [" + rhdqns3[4] + "  " + rhdqns4[4] + "]\r\n\r\n" +
                        "<공분산>\r\n" + "X11, X12 : [" + s1 + "  " + s2 + "]\r\n" + "X21, X22 : [" + s3 + "  " + s4 + "]";
                    }
                    else if (i == 6)
                    {
                        rufrhk.Text =
                        "<1번>\r\n" + "X1의 분산 : [" + rhdqns1[0] + "  " + rhdqns2[0] + "]\r\n" + "X2의 분산 : [" + rhdqns3[0] + "  " + rhdqns4[0] + "]\r\n\r\n" +
                        "<2번>\r\n" + "X1의 분산 : [" + rhdqns1[1] + "  " + rhdqns2[1] + "]\r\n" + "X2의 분산 : [" + rhdqns3[1] + "  " + rhdqns4[1] + "]\r\n\r\n" +
                        "<3번>\r\n" + "X1의 분산 : [" + rhdqns1[2] + "  " + rhdqns2[2] + "]\r\n" + "X2의 분산 : [" + rhdqns3[2] + "  " + rhdqns4[2] + "]\r\n\r\n" +
                        "<4번>\r\n" + "X1의 분산 : [" + rhdqns1[3] + "  " + rhdqns2[3] + "]\r\n" + "X2의 분산 : [" + rhdqns3[3] + "  " + rhdqns4[3] + "]\r\n\r\n" +
                        "<5번>\r\n" + "X1의 분산 : [" + rhdqns1[4] + "  " + rhdqns2[4] + "]\r\n" + "X2의 분산 : [" + rhdqns3[4] + "  " + rhdqns4[4] + "]\r\n\r\n" +
                        "<6번>\r\n" + "X1의 분산 : [" + rhdqns1[5] + "  " + rhdqns2[5] + "]\r\n" + "X2의 분산 : [" + rhdqns3[5] + "  " + rhdqns4[5] + "]\r\n\r\n" +
                        "<공분산>\r\n" + "X11, X12 : [" + s1 + "  " + s2 + "]\r\n" + "X21, X22 : [" + s3 + "  " + s4 + "]";
                    }
                    else if (i == 7)
                    {
                        rufrhk.Text =
                        "<1번>\r\n" + "X1의 분산 : [" + rhdqns1[0] + "  " + rhdqns2[0] + "]\r\n" + "X2의 분산 : [" + rhdqns3[0] + "  " + rhdqns4[0] + "]\r\n\r\n" +
                        "<2번>\r\n" + "X1의 분산 : [" + rhdqns1[1] + "  " + rhdqns2[1] + "]\r\n" + "X2의 분산 : [" + rhdqns3[1] + "  " + rhdqns4[1] + "]\r\n\r\n" +
                        "<3번>\r\n" + "X1의 분산 : [" + rhdqns1[2] + "  " + rhdqns2[2] + "]\r\n" + "X2의 분산 : [" + rhdqns3[2] + "  " + rhdqns4[2] + "]\r\n\r\n" +
                        "<4번>\r\n" + "X1의 분산 : [" + rhdqns1[3] + "  " + rhdqns2[3] + "]\r\n" + "X2의 분산 : [" + rhdqns3[3] + "  " + rhdqns4[3] + "]\r\n\r\n" +
                        "<5번>\r\n" + "X1의 분산 : [" + rhdqns1[4] + "  " + rhdqns2[4] + "]\r\n" + "X2의 분산 : [" + rhdqns3[4] + "  " + rhdqns4[4] + "]\r\n\r\n" +
                        "<6번>\r\n" + "X1의 분산 : [" + rhdqns1[5] + "  " + rhdqns2[5] + "]\r\n" + "X2의 분산 : [" + rhdqns3[5] + "  " + rhdqns4[5] + "]\r\n\r\n" +
                        "<7번>\r\n" + "X1의 분산 : [" + rhdqns1[6] + "  " + rhdqns2[6] + "]\r\n" + "X2의 분산 : [" + rhdqns3[6] + "  " + rhdqns4[6] + "]\r\n\r\n" +
                        "<공분산>\r\n" + "X11, X12 : [" + s1 + "  " + s2 + "]\r\n" + "X21, X22 : [" + s3 + "  " + s4 + "]";
                    }
                    else if (i == 8)
                    {
                        rufrhk.Text =
                        "<1번>\r\n" + "X1의 분산 : [" + rhdqns1[0] + "  " + rhdqns2[0] + "]\r\n" + "X2의 분산 : [" + rhdqns3[0] + "  " + rhdqns4[0] + "]\r\n\r\n" +
                        "<2번>\r\n" + "X1의 분산 : [" + rhdqns1[1] + "  " + rhdqns2[1] + "]\r\n" + "X2의 분산 : [" + rhdqns3[1] + "  " + rhdqns4[1] + "]\r\n\r\n" +
                        "<3번>\r\n" + "X1의 분산 : [" + rhdqns1[2] + "  " + rhdqns2[2] + "]\r\n" + "X2의 분산 : [" + rhdqns3[2] + "  " + rhdqns4[2] + "]\r\n\r\n" +
                        "<4번>\r\n" + "X1의 분산 : [" + rhdqns1[3] + "  " + rhdqns2[3] + "]\r\n" + "X2의 분산 : [" + rhdqns3[3] + "  " + rhdqns4[3] + "]\r\n\r\n" +
                        "<5번>\r\n" + "X1의 분산 : [" + rhdqns1[4] + "  " + rhdqns2[4] + "]\r\n" + "X2의 분산 : [" + rhdqns3[4] + "  " + rhdqns4[4] + "]\r\n\r\n" +
                        "<6번>\r\n" + "X1의 분산 : [" + rhdqns1[5] + "  " + rhdqns2[5] + "]\r\n" + "X2의 분산 : [" + rhdqns3[5] + "  " + rhdqns4[5] + "]\r\n\r\n" +
                        "<7번>\r\n" + "X1의 분산 : [" + rhdqns1[6] + "  " + rhdqns2[6] + "]\r\n" + "X2의 분산 : [" + rhdqns3[6] + "  " + rhdqns4[6] + "]\r\n\r\n" +
                        "<8번>\r\n" + "X1의 분산 : [" + rhdqns1[7] + "  " + rhdqns2[7] + "]\r\n" + "X2의 분산 : [" + rhdqns3[7] + "  " + rhdqns4[7] + "]\r\n\r\n" +
                        "<공분산>\r\n" + "X11, X12 : [" + s1 + "  " + s2 + "]\r\n" + "X21, X22 : [" + s3 + "  " + s4 + "]";
                    }
                }
                else
                    rufrhk.Text = "잘못 입력되었습니다.";                
            }
                
            else if (qnsfb.SelectedItem.ToString() == "거리")
            {
                double tp = 0, tp1 = 0, resu = 0;
                int i = 0, j = 0;
                tp = Math.Pow((list1[0] - list2[0]), 2);
                tp1 = Math.Pow((list1_1[0] - list2_1[0]), 2);

                resu = Math.Sqrt(tp + tp1);
                rufrhk.Text = "두 점 사이의 거리 : " + resu;                
            }   

            else if (qnsfb.SelectedItem.ToString() == "거리와유사도")
            {
                int i = 0, j = 0, a = 0, r = 0;

                if (list1[i] != 0)
                {
                    a = Convert.ToInt32(counter.Text);

                    for (i = a; list1[i] != 0 && i < 8; i++)
                    {
                        for (j = 0; j < a; j++)
                        {

                            result1[j] = Math.Pow((list1[j] - list1[i]), 2);
                            result2[j] = Math.Pow((list1_1[j] - list1_1[i]), 2);

                            distance[r] = Math.Sqrt(result1[j] + result2[j]);
                            r++;
                        }
                    }
                    if (r == 1)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            ;
                    }
                    else if (r == 2)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            ;
                    }
                    else if (r == 3)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            ;
                    }
                    else if (r == 4)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            ;
                    }
                    else if (r == 5)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            ;
                    }
                    else if (r == 6)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            ;
                    }
                    else if (r == 7)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[2] + ")"
                            + "\r\n(2) (" + distance[3] + ")"
                            + "\r\n(3) (" + distance[1] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            ;
                    }
                    else if (r == 8)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            ;
                    }
                    else if (r == 9)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            + "\r\n(8) (" + distance[8] + ")"
                            ;
                    }
                    else if (r == 10)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            + "\r\n(8) (" + distance[8] + ")"
                            + "\r\n(9) (" + distance[9] + ")"
                            ;
                    }
                    else if (r == 11)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            + "\r\n(8) (" + distance[8] + ")"
                            + "\r\n(9) (" + distance[9] + ")"
                            + "\r\n(10) (" + distance[10] + ")"
                            ;
                    }
                    else if (r == 12)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            + "\r\n(8) (" + distance[8] + ")"
                            + "\r\n(9) (" + distance[9] + ")"
                            + "\r\n(10) (" + distance[10] + ")"
                            + "\r\n(11) (" + distance[11] + ")"
                            ;
                    }
                    else if (r == 13)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            + "\r\n(9) (" + distance[8] + ")"
                            + "\r\n(10) (" + distance[9] + ")"
                            + "\r\n(11) (" + distance[10] + ")"
                            + "\r\n(12) (" + distance[11] + ")"
                            + "\r\n(13) (" + distance[12] + ")"
                            ;
                    }
                    else if (r == 14)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            + "\r\n(8) (" + distance[8] + ")"
                            + "\r\n(9) (" + distance[9] + ")"
                            + "\r\n(10) (" + distance[10] + ")"
                            + "\r\n(11) (" + distance[11] + ")"
                            + "\r\n(12) (" + distance[12] + ")"
                            + "\r\n(13) (" + distance[13] + ")"
                            ;
                    }
                    else if (r == 15)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            + "\r\n(8) (" + distance[8] + ")"
                            + "\r\n(9) (" + distance[9] + ")"
                            + "\r\n(10) (" + distance[10] + ")"
                            + "\r\n(11) (" + distance[11] + ")"
                            + "\r\n(12) (" + distance[12] + ")"
                            + "\r\n(13) (" + distance[13] + ")"
                            + "\r\n(14) (" + distance[14] + ")"
                            ;
                    }
                    else if (r == 16)
                    {
                        rufrhk.Text = "max, min, avg에서 사용가능\r\n거리와 유사도 :\r\n(0) (" + distance[0] + ")"
                            + "\r\n(1) (" + distance[1] + ")"
                            + "\r\n(2) (" + distance[2] + ")"
                            + "\r\n(3) (" + distance[3] + ")"
                            + "\r\n(4) (" + distance[4] + ")"
                            + "\r\n(5) (" + distance[5] + ")"
                            + "\r\n(6) (" + distance[6] + ")"
                            + "\r\n(7) (" + distance[7] + ")"
                            + "\r\n(8) (" + distance[8] + ")"
                            + "\r\n(9) (" + distance[9] + ")"
                            + "\r\n(10) (" + distance[10] + ")"
                            + "\r\n(11) (" + distance[11] + ")"
                            + "\r\n(12) (" + distance[12] + ")"
                            + "\r\n(13) (" + distance[13] + ")"
                            + "\r\n(14) (" + distance[14] + ")"
                            + "\r\n(15) (" + distance[15] + ")"
                            ;
                    }
                }
            }
        }



        private void reset_Click_1(object sender, EventArgs e)
        {
            t1.Text = "0"; t9.Text = "0";
            t2.Text = "0"; t10.Text = "0";
            t3.Text = "0"; t11.Text = "0";
            t4.Text = "0"; t12.Text = "0";
            t5.Text = "0"; t13.Text = "0";
            t6.Text = "0"; t14.Text = "0";
            t7.Text = "0"; t15.Text = "0";
            t8.Text = "0"; t16.Text = "0";

            t21.Text = "0"; t18.Text = "0";
            t22.Text = "0"; t19.Text = "0";
            t23.Text = "0"; t20.Text = "0";
            t24.Text = "0"; t17.Text = "0";
            t25.Text = "0"; t31.Text = "0";
            t26.Text = "0"; t29.Text = "0";
            t27.Text = "0"; t30.Text = "0";
            t28.Text = "0"; t32.Text = "0";

            qnsfb.SelectedItem = "선택";
            counter.Text = "";

            for (; r > 0; r--)
                distance[r] = 0;
            for (int i = 0; i < 8; i++)
            {
                list1[i] = 0;
                list1_1[i] = 0;
                list2[i] = 0;
                list2_1[i] = 0;
                result1[i] = 0;
                result2[i] = 0;
                result3[i] = 0;
                rhdqns1[i] = 0;
                rhdqns2[i] = 0;
                rhdqns3[i] = 0;
                rhdqns4[i] = 0;
            }
        }

        private void t36_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
