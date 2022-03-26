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

namespace test2
{
    public partial class 골드문방탄계산기 : Form
    {
        int aa, bb, cc, dd, ee, ab, ba;
        string[] line = new string[4];
        string[] qkd = new string[16];
        
        int sum = 0, sum1 = 0;
        public 골드문방탄계산기()
        {
            InitializeComponent();
            Plus.Enabled = false;
            Plus1.Enabled = false;
            Plus2.Enabled = false;
            tnwjd1.Enabled = false;
            tnwjd2.Enabled = false;
            total.Text = "최초 실행시 빨간버튼으로 리셋시켜주세요.\r\n\r\n🌙골드문 ➰ 판매물품🌙 | 🧥방탄복🧥 | 🧨신호탄🧨 | 🏭가공공장이용권🏭 | 🛴신속배달📦";
            
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (job.SelectedItem.ToString() == "시민")
            {
                
                Plus1.Enabled = true;
                
            }
            else if (job.SelectedItem.ToString() == "범서")
            {
                
                Plus1.Enabled = true;
                
            }
            else if (job.SelectedItem.ToString() == "신의")
            {                
                
                Plus1.Enabled = true;
                
            }
            else if (job.SelectedItem.ToString() == "칠성")
            {
                
                Plus1.Enabled = true;
                
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String enteredblink1 = blink1.Text.Trim();
            double num1 = 0;
            if (!double.TryParse(enteredblink1, out num1))
                return;
            int sum = 0, sum1 = 0;
            double result1 = 0, result2 = 0, result3 = 0;
            double sell0 = 0;
            double sell2 = 0;

            StreamReader sr = new StreamReader("방탄가격.txt", false);
            for (int i = 0; i < 16; i++)
            {
                if (i != 0 || i != 3 || i != 6 || i != 9)
                    qkd[i]= sr.ReadLine();
            }
            sr.Close();
            

            if (job.SelectedItem.ToString() == "시민" && num1 <= Convert.ToInt32(qkd[13]))
            {                
                result1 = Convert.ToInt32(qkd[1]) * num1;
                result2 = (Convert.ToInt32(qkd[1]) - 730000) * num1;
                result3 = ((Convert.ToInt32(qkd[1]) - 730000) * num1) * 0.3;                
                sell2 += num1;
                sell0 += num1;
            }
            else if (job.SelectedItem.ToString() == "시민" && num1 >= Convert.ToInt32(qkd[14]))
            {
                result1 = Convert.ToInt32(qkd[2]) * num1;
                result2 = (Convert.ToInt32(qkd[2]) - 730000) * num1;
                result3 = ((Convert.ToInt32(qkd[2]) - 730000) * num1) * 0.3;
                sell2 += num1;
                sell0 += num1;
            }
            else if (job.SelectedItem.ToString() == "범서" && num1 <= Convert.ToInt32(qkd[13]))
            {
                result1 = Convert.ToInt32(qkd[4]) * num1;
                result2 = (Convert.ToInt32(qkd[4]) - 730000) * num1;
                result3 = ((Convert.ToInt32(qkd[4]) - 730000) * num1) * 0.3;
                sell2 += num1;
                sell0 += num1;
            }
            else if (job.SelectedItem.ToString() == "범서" && num1 >= Convert.ToInt32(qkd[14]))
            {
                result1 = Convert.ToInt32(qkd[5]) * num1;
                result2 = (Convert.ToInt32(qkd[5]) - 730000) * num1;
                result3 = ((Convert.ToInt32(qkd[5]) - 730000) * num1) * 0.3;
                sell2 += num1;
                sell0 += num1;
            }
            else if (job.SelectedItem.ToString() == "신의" && num1 <= Convert.ToInt32(qkd[13]))
            {
                result1 = Convert.ToInt32(qkd[7]) * num1;
                result2 = (Convert.ToInt32(qkd[7]) - 730000) * num1;
                result3 = ((Convert.ToInt32(qkd[7]) - 730000) * num1) * 0.3;
                sell2 += num1;
                sell0 += num1;
            }
            else if (job.SelectedItem.ToString() == "신의" && num1 >= Convert.ToInt32(qkd[14]))
            {
                result1 = Convert.ToInt32(qkd[8]) * num1;
                result2 = (Convert.ToInt32(qkd[8]) - 730000) * num1;
                result3 = ((Convert.ToInt32(qkd[8]) - 730000) * num1) * 0.3;
                sell2 += num1;
                sell0 += num1;
            }
            else if (job.SelectedItem.ToString() == "칠성" && num1 <= Convert.ToInt32(qkd[13]))
            {
                result1 = Convert.ToInt32(qkd[10]) * num1;
                result2 = (Convert.ToInt32(qkd[10]) - 730000) * num1;
                result3 = ((Convert.ToInt32(qkd[10]) - 730000) * num1) * 0.3;
                sell2 += num1;
                sell0 += num1;
            }
            else if (job.SelectedItem.ToString() == "칠성" && num1 >= Convert.ToInt32(qkd[14]))
            {
                result1 = Convert.ToInt32(qkd[11]) * num1;
                result2 = (Convert.ToInt32(qkd[11]) - 730000) * num1;
                result3 = ((Convert.ToInt32(qkd[11]) - 730000) * num1) * 0.3;
                sell2 += num1;
                sell0 += num1;
            }
            
            if (result3 <= 0)
                total.Text = "구매금액보다 낮은 방탄금액이 설정되어있습니다.\r\n\r\n방탄가격을 다시 입력해주세요.";
            else if (result3 > 0)
            {
                sum = Convert.ToInt32(chdsnwjr.Text) + Convert.ToInt32(blink1.Text);
                sum1 = Convert.ToInt32(snwjr.Text) + Convert.ToInt32(blink1.Text);
                total.Text = "```\r\n닉네임 : " + "\r\n" + "구분 : " + job.Text + "\r\n" + "방탄 개수 : " + num1 + "장" + "\r\n" + result1.ToString("판매금액 : " + "#,##0" + "원\r\n") + result2.ToString("순이익 : " + "#,##0" + "원\r\n") + result3.ToString("상납금 : " + "#,##0" + "원\r\n") + "누적 판매 개수 : " + sum1 + "\r\n" + "총 판매 개수 : " + sum + "\r\n\r\n" + "공금 입금 전 금액 : \r\n" + "공금 입금 후 금액 : \r\n```";
            }
        }


        private void Plus_Click(object sender, EventArgs e)
        {
            Plus1.Enabled = false;
            qkdxks.ReadOnly = true;
            tnwjd1.Enabled = true;
            tnwjd2.Enabled = true;
            button1.Enabled = false;
            
            if (job.SelectedItem.ToString() == "시민" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                if (tnwjd1.Text != "" && tnwjd2.Text != "")
                {
                    qkd[1] = tnwjd1.Text;
                    qkd[2] = tnwjd2.Text;
                }
                else if (tnwjd1.Text != "")
                {
                    qkd[1] = tnwjd1.Text;                    
                }
                else if (tnwjd2.Text != "")
                {
                    qkd[1] = tnwjd2.Text;
                }
            }
            else if (job.SelectedItem.ToString() == "범서" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                if (tnwjd1.Text != "" && tnwjd2.Text != "")
                {
                    qkd[4] = tnwjd1.Text;
                    qkd[5] = tnwjd2.Text;
                }
                else if (tnwjd1.Text != "")
                {
                    qkd[4] = tnwjd1.Text;
                }
                else if (tnwjd2.Text != "")
                {
                    qkd[5] = tnwjd2.Text;
                }
            }
            else if (job.SelectedItem.ToString() == "신의" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                if (tnwjd1.Text != "" && tnwjd2.Text != "")
                {
                    qkd[7] = tnwjd1.Text;
                    qkd[8] = tnwjd2.Text;
                }
                else if (tnwjd1.Text != "")
                {
                    qkd[7] = tnwjd1.Text;
                }
                else if (tnwjd2.Text != "")
                {
                    qkd[8] = tnwjd2.Text;
                }
            }
            else if (job.SelectedItem.ToString() == "칠성" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                if (tnwjd1.Text != "" && tnwjd2.Text != "")
                {
                    qkd[10] = tnwjd1.Text;
                    qkd[11] = tnwjd2.Text;
                }
                else if (tnwjd1.Text != "")
                {
                    qkd[10] = tnwjd1.Text;
                }
                else if (tnwjd2.Text != "")
                {
                    qkd[11] = tnwjd2.Text;
                }
            }
            else if (tjsxor.SelectedItem.ToString() == "구간1 수정")
            {
                if (tnwjd1.Text != "" && tnwjd2.Text != "")
                {
                    qkd[12] = tnwjd1.Text;
                    qkd[13] = tnwjd2.Text;
                }
                else if (tnwjd1.Text != "")
                {
                    qkd[12] = tnwjd1.Text;
                }
                else if (tnwjd2.Text != "")
                {
                    qkd[13] = tnwjd2.Text;
                }
            }
            else if (tjsxor.SelectedItem.ToString() == "구간2 수정")
            {
                if (tnwjd1.Text != "" && tnwjd2.Text != "")
                {
                    qkd[14] = tnwjd1.Text;
                    qkd[15] = tnwjd2.Text;
                }
                else if (tnwjd1.Text != "")
                {
                    qkd[14] = tnwjd1.Text;
                }
                else if (tnwjd2.Text != "")
                {
                    qkd[15] = tnwjd2.Text;
                }
            }

            StreamWriter sw = new StreamWriter("방탄가격.txt", false);
            for (int i = 0; i < 16; i++)
            {
                if (i != 0 || i != 3 || i != 6 || i != 9)
                    sw.WriteLine(qkd[i]);
            }
            sw.Close();            
            qkdxks.Text = "수정하고\r\n저장을 눌러주세요.";            

        }

        private void tlsgh_Click(object sender, EventArgs e)
        {
            String enteredblink1 = blink1.Text.Trim();
            double number = 0;
            if(!double.TryParse(enteredblink1, out number))
                return;

            double sum = 0, sum1 = 0;
            if (body.Checked == true)
            {
                sum = 385000 * number;
                sum1 = (385000 - 85000) * number;
                total.Text = "```\r\n닉네임 : " + "\r\n" + "구분 : " + job.Text + "\r\n" + "신호탄 총신 개수 : " + number + "개" + "\r\n" + sum.ToString("판매가 : " + "#,##0" + "원\r\n") + sum1.ToString("순이익 : " + "#,##0" + "원\r\n```");
            }
            else if (blout.Checked == true)
            {
                sum = 10000 * number;
                sum1 = (10000 - 1000) * number;
                total.Text = "```\r\n닉네임 : " + "\r\n" + "구분 : " + job.Text + "\r\n" + "신호탄 탄약 개수 : " + number + "개" + "\r\n" + sum.ToString("판매가 : " + "#,##0" + "원\r\n") + sum1.ToString("순이익 : " + "#,##0" + "원\r\n```");
            }
            else
                return;
           
        }

        private void rjadms_Click(object sender, EventArgs e)
        {
            
            String enteredtlscjd = tlscjd.Text.Trim();
            
            double tlscjd1 = 0, ghkswjs1 = 0;
            if (!double.TryParse(enteredtlscjd, out tlscjd1))
                return;
            double tndlr=0;

            tndlr = tlscjd1 * 0.1;
            ghkswjs1 = tlscjd1 - tndlr;

            total.Text = "```\r\n닉네임 : " + "\r\n" + "구분 : " + job.Text + "\r\n" + "종류 : 훔친돈 환전"  + "\r\n" + tlscjd1.ToString("신청금액 : " + "#,##0" + "원\r\n") + ghkswjs1.ToString("환전금액 : " + "#,##0" + "원\r\n") + "환전수익(10%) : " + tndlr.ToString("#,##0" + "원\r\n") + "\r\n아이템 : 훔친돈 \r\n주는분 : \r\n받는분 : \r\n금액 : " + tlscjd1.ToString() + "개\r\n```";

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            qkdxks.ReadOnly = true;
            int sum, sum1;
            StreamReader sr = new StreamReader("방탄가격.txt", true);
            for(int i=0; i < 16; i++)
            {
                if(i != 0 || i != 3 || i != 6 || i != 9)
                    qkd[i] = sr.ReadLine();
            }
            sr.Close();
            if (job.SelectedItem.ToString() == "시민")
            {
                sum = Convert.ToInt32(qkd[1]);
                sum1 = Convert.ToInt32(qkd[2]);
                qkdxks.Text = "시민 가격\r\n" + qkd[12] + "~" + qkd[13] + "개\r\n" + sum.ToString("#,##0") + "원\r\n" + qkd[14] + "~" + qkd[15] + "개\r\n" + sum1.ToString("#,##0") + "원";
            }
            else if (job.SelectedItem.ToString() == "범서")
            {
                sum = Convert.ToInt32(qkd[4]);
                sum1 = Convert.ToInt32(qkd[5]);
                qkdxks.Text = "범서 가격\r\n" + qkd[12] + "~" + qkd[13] + "개\r\n" + sum.ToString("#,##0") + "원\r\n" + qkd[14] + "~" + qkd[15] + "개\r\n" + sum1.ToString("#,##0") + "원";
            }
            else if (job.SelectedItem.ToString() == "신의")
            {
                sum = Convert.ToInt32(qkd[7]);
                sum1 = Convert.ToInt32(qkd[8]);
                qkdxks.Text = "신의 가격\r\n" + qkd[12] + "~" + qkd[13] + "개\r\n" + sum.ToString("#,##0") + "원\r\n" + qkd[14] + "~" + qkd[15] + "개\r\n" + sum1.ToString("#,##0") + "원";
            }
            else if (job.SelectedItem.ToString() == "칠성")
            {
                sum = Convert.ToInt32(qkd[10]);
                sum1 = Convert.ToInt32(qkd[11]);
                qkdxks.Text = "칠성 가격\r\n" + qkd[12] + "~" + qkd[13] + "개\r\n" + sum.ToString("#,##0") + "원\r\n" + qkd[14] + "~" + qkd[15] + "개\r\n" + sum1.ToString("#,##0") + "원";
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = 0, result1 = 0;
            if(wjrcnf.Checked==true)
            {
                if (wkdrl.SelectedItem.ToString() == "소장")
                {
                    result = 28000000 - (28000000 * 0.3);
                    result1 = 28000000 - (28000000 * 0.7);
                }
                else if (wkdrl.SelectedItem.ToString() == "안구")
                {
                    result = 17000000 - (17000000 * 0.3);
                    result1 = 17000000 - (17000000 * 0.7);
                }
                else if (wkdrl.SelectedItem.ToString() == "쓸개")
                {
                    result = 13700000 - (13700000 * 0.3);
                    result1 = 13700000 - (13700000 * 0.7);
                }
                else if (wkdrl.SelectedItem.ToString() == "위")
                {
                    result = 5700000 - (5700000 * 0.3);
                    result1 = 5700000 - (5700000 * 0.7);
                }
                total.Text = "```\r\n닉네임 : " + "\r\n" + "적출장기부위 : " + wkdrl.SelectedItem.ToString() + "\r\n" + result.ToString("판매가 :" + " #,##0" + "원") + " (70%)\r\n" + "순이익(30%) : " + result1.ToString("#,##0" + "원\r\n```");
            }
            else if(dlsrhd.Checked==true)
            {
                if(wkdrl.SelectedItem.ToString()=="소장")
                {
                    result = (8988000 * 0.3) + 8988000;
                    result1 = result - 8988000;
                }
                else if (wkdrl.SelectedItem.ToString() == "안구")
                {
                    result = (5457000 * 0.3) + 5457000;
                    result1 = result - 5457000;
                }
                else if (wkdrl.SelectedItem.ToString() == "쓸개")
                {
                    result = (4397700 * 0.3) + 4397700;
                    result1 = result - 4397700;
                }
                else if (wkdrl.SelectedItem.ToString() == "위")
                {
                    result = (1829700 * 0.3) + 1829700;
                    result1 = result - 1829700;
                }
                total.Text = "```\r\n닉네임 : " + "\r\n" + "적출장기부위 : " + wkdrl.SelectedItem.ToString() + " (인공)" + "\r\n" + result.ToString("판매가 :" + " #,##0" + "원") + " (30%)\r\n" + "순이익(30%) : " + result1.ToString("#,##0" + "원\r\n```");
            }
        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void wkdrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Tmrl_Click(object sender, EventArgs e)
        {
            int sum = 0, sum1 = 0;
            StreamWriter sw = new StreamWriter("방탄누적.txt", false);
            sum = Convert.ToInt32(snwjr.Text) + Convert.ToInt32(blink1.Text);
            sw.WriteLine(sum);
            sw.Close();
            StreamWriter rw = new StreamWriter("방탄총누적.txt", false);
            sum1 = Convert.ToInt32(chdsnwjr.Text) + Convert.ToInt32(blink1.Text);
            rw.WriteLine(sum1);
            rw.Close();


        }

        private void snwjr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chdsnwjr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void rodtls_Click(object sender, EventArgs e)
        {
            int ab = 0, ab1 = 0;
        
            ab = Convert.ToInt32(snwjr.Text) * ab1;
            snwjr.Text = ab.ToString();
            blink1.Text = ab.ToString();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            StreamReader sw = new StreamReader("방탄총누적.txt", false);
            
            chdsnwjr.Text = sw.ReadToEnd();
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            StreamReader sr = new StreamReader("방탄누적.txt", false);
            
            snwjr.Text = sr.ReadLine();
            sr.Close();
        }

        private void tlwkr_Click(object sender, EventArgs e)
        {
            String enteredsnwjrtlrks = snwjrtlrks.Text.Trim();
            String enteredsnwjrqns = snwjrqns.Text.Trim();
            int num1 = 0, num2 = 0;
            if (!int.TryParse(enteredsnwjrtlrks, out num1) || !int.TryParse(enteredsnwjrqns, out num2))
                return;

            DateTime time1 = DateTime.Now;
            tlwkr1.Text = time1.ToString();
            tlwkr1.Text = System.DateTime.Now.ToString("tt hh시mm분");

            ab = time1.Day;
            aa = time1.Hour;
            bb = time1.Minute;
            
            snwjrtlrks.Text = num1.ToString();
            snwjrqns.Text = num2.ToString();
            if (snwjrtlrks.Text != "" && snwjrqns.Text != "")
            {
                snwjrtlrks.ReadOnly = true;
                snwjrqns.ReadOnly = true;
            }


            if (snwjrtlrks.ReadOnly == true && snwjrqns.ReadOnly == true)
            {
                tlwkr.Enabled = false;
                
                StreamReader sr2 = new StreamReader("시간값.txt", true);
                for (int i = 0; i < 4; i++)
                    line[i] = sr2.ReadLine();
                sr2.Close();

                StreamWriter sw2 = new StreamWriter("시간값.txt", false);
                sw2.WriteLine(Convert.ToInt32(snwjrtlrks.Text));
                sw2.WriteLine(Convert.ToInt32(snwjrqns.Text));
                sw2.WriteLine(Convert.ToInt32(line[2]));
                sw2.WriteLine(Convert.ToInt32(line[3]));
                sw2.Close();
                
                StreamWriter sw = new StreamWriter("날짜.txt", true);
                sw.WriteLine("접속 날짜 : " + System.DateTime.Now.ToString("MM월 dd일"));
                sw.WriteLine("접속 시간 : " + tlwkr1.Text);
                sw.Close();
                ee = 1;
            }
            /*
            StreamReader sr3 = new StreamReader("시간값.txt", true);
            for (int i = 2; i < 4; i++)
                line[i] = sr3.ReadLine();
            sr3.Close();*/
        }

        private void snwjrtlrks_TextChanged(object sender, EventArgs e)
        {

        }

        private void chrlghk_Click(object sender, EventArgs e)
        {
            StreamWriter sw1 = new StreamWriter("날짜.txt", false);
            sw1.WriteLine("");
            sw1.Close();
            StreamWriter sw2 = new StreamWriter("방탄누적.txt", false);
            sw2.WriteLine(0);
            sw2.Close();
            StreamWriter sw3 = new StreamWriter("방탄총누적.txt", false);
            sw3.WriteLine(0);
            sw3.Close();
            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
            sw4.WriteLine("총 누적시간 (예 : 3) ");
            sw4.WriteLine("총 누적 분 (예 : 30)");
            sw4.WriteLine("누적 시간 (예 : 6)");
            sw4.WriteLine("누적 분 (예 : 10)");
            sw4.WriteLine("위에 싹 다 지우고 옆에 예시처럼 작성해주세요.\r\n누적시간은 6시간 10분 총누적시간은 3시간 30분일때 경우 예를든겁니다.\r\n공백이면 에러나여");
            sw4.Close();
            StreamWriter sw5 = new StreamWriter("시간누적.txt", false);
            sw5.WriteLine("");
            sw5.Close();
            StreamWriter sw6 = new StreamWriter("방탄가격.txt", false);
            sw6.WriteLine("시민"); sw6.WriteLine("0"); sw6.WriteLine("0"); 
            sw6.WriteLine("범서"); sw6.WriteLine("0"); sw6.WriteLine("0");
            sw6.WriteLine("신의"); sw6.WriteLine("0"); sw6.WriteLine("0"); 
            sw6.WriteLine("칠성"); sw6.WriteLine("0"); sw6.WriteLine("0");
            sw6.WriteLine("1"); sw6.WriteLine("10"); sw6.WriteLine("11"); sw6.WriteLine("30");
            sw6.Close();
            tlwkr1.Text = "";
            whdfy1.Text = "";
            snwjrtlrks.Text = "";
            snwjrqns.Text = "";
            total.Text = "저장 값이 <모두 초기화> 되었습니다.\r\n\r\n시간값메모장에서 <총누적시간을 설정>하기 위해\r\n\r\n<시간은 1번째 줄> <분은 2번째 줄>에 입력하세요.\r\n\r\n     *입력하였다면 모든 셋팅은 끝났습니다.*";
            
            System.Diagnostics.Process.Start("시간값.txt");
        }

        private void vksao1_Click(object sender, EventArgs e)
        {
            String enteredtlscjd = tlscjd.Text.Trim();

            double tlscjd1 = 0, ghkswjs1 = 0;
            if (!double.TryParse(enteredtlscjd, out tlscjd1))
                return;
            double tndlr = 0;

            tndlr = tlscjd1 * 0.07;
            ghkswjs1 = tlscjd1 + tndlr;

            total.Text = "```\r\n닉네임 : " + "\r\n" + "구분 : " + job.Text + "\r\n" + "종류 : 훔친돈 판매" + "\r\n" + tlscjd1.ToString("신청금액 : " + "#,##0" + "원\r\n") + ghkswjs1.ToString("판매금액 : " + "#,##0" + "원\r\n") + "판매수익(7%) : " + tndlr.ToString("#,##0" + "원\r\n") + "\r\n아이템 : 훔친돈 \r\n주는분 : \r\n받는분 : \r\n금액 : " + tlscjd1.ToString() + "개\r\n```";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("1.사용방법.txt");
        }

        private void qkdxks_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tnwjd1.Enabled = false;
            tnwjd2.Enabled = false;
            int sum = 0, sum1 = 0;

            if (job.SelectedItem.ToString() == "시민" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                qkd[1] = tnwjd1.Text;
                qkd[2] = tnwjd2.Text;
                sum = Convert.ToInt32(qkd[1]);
                sum1 = Convert.ToInt32(qkd[2]);
                qkdxks.Text = "시민 방탄가격 저장\r\n" + qkd[12] + "~" + qkd[13] + "개\r\n" + sum.ToString("#,##0") + "원\r\n" + qkd[14] + "~" + qkd[15] + "개\r\n" + sum1.ToString("#,##0") + "원";
               
            }
            else if (job.SelectedItem.ToString() == "범서" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                qkd[4] = tnwjd1.Text;
                qkd[5] = tnwjd2.Text;
                sum = Convert.ToInt32(qkd[4]);
                sum1 = Convert.ToInt32(qkd[5]);
                qkdxks.Text = "범서 가격\r\n" + qkd[12] + "~" + qkd[13] + "개\r\n" + sum.ToString("#,##0") + "원\r\n" + qkd[14] + "~" + qkd[15] + "개\r\n" + sum1.ToString("#,##0") + "원";
                
            }
            else if (job.SelectedItem.ToString() == "신의" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                qkd[7] = tnwjd1.Text;
                qkd[8] = tnwjd2.Text;
                sum = Convert.ToInt32(qkd[7]);
                sum1 = Convert.ToInt32(qkd[8]);
                qkdxks.Text = "신의 가격\r\n" + qkd[12] + "~" + qkd[13] + "개\r\n" + sum.ToString("#,##0") + "원\r\n" + qkd[14] + "~" + qkd[15] + "개\r\n" + sum1.ToString("#,##0") + "원";
            }
            else if (job.SelectedItem.ToString() == "칠성" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                qkd[10] = tnwjd1.Text;
                qkd[11] = tnwjd2.Text;
                sum = Convert.ToInt32(qkd[10]);
                sum1 = Convert.ToInt32(qkd[11]);
                qkdxks.Text = "칠성 가격\r\n" + qkd[12] + "~" + qkd[13] + "개\r\n" + sum.ToString("#,##0") + "원\r\n" + qkd[14] + "~" + qkd[15] + "개\r\n" + sum1.ToString("#,##0") + "원";
            }
            else if (tjsxor.SelectedItem.ToString() == "구간1 수정")
            {
                if (tnwjd1.Text != "" && tnwjd2.Text != "")
                {
                    qkd[12] = tnwjd1.Text;
                    qkd[13] = tnwjd2.Text;
                    qkdxks.Text = "구간1이 설정되었습니다.";
                }
                else if (tnwjd1.Text != "")
                {
                    qkd[12] = tnwjd1.Text;
                    qkdxks.Text = "구간1이 설정되었습니다.";
                }
                else if (tnwjd2.Text != "")
                {
                    qkd[13] = tnwjd2.Text;
                    qkdxks.Text = "구간1이 설정되었습니다.";
                }
            }
            else if (tjsxor.SelectedItem.ToString() == "구간2 수정")
            {
                if (tnwjd1.Text != "" && tnwjd2.Text != "")
                {
                    qkd[14] = tnwjd1.Text;
                    qkd[15] = tnwjd2.Text;
                    qkdxks.Text = "구간2가 설정되었습니다.";
                }
                else if (tnwjd1.Text != "")
                {
                    qkd[14] = tnwjd1.Text;
                    qkdxks.Text = "구간2가 설정되었습니다.";
                }
                else if (tnwjd2.Text != "")
                {
                    qkd[15] = tnwjd2.Text;
                    qkdxks.Text = "구간2가 설정되었습니다.";
                }
            }

            StreamWriter sw = new StreamWriter("방탄가격.txt", false);
            for (int i = 0; i < 16; i++)
            {
                if (i != 0 || i != 3 || i != 6 || i != 9)
                    sw.WriteLine(qkd[i]);
            }
            sw.Close();
            Plus1.Enabled = true;
            qkdxks.ReadOnly = false;
            button1.Enabled = true;
        }

        private void tnwjd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tnwjd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (job.SelectedItem.ToString() == "시민" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                Plus.Enabled = true;
                Plus1.Enabled = true;
                Plus2.Enabled = true;
            }
            else if (job.SelectedItem.ToString() == "범서" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                Plus.Enabled = true;
                Plus1.Enabled = true;
                Plus2.Enabled = true;
            }
            else if (job.SelectedItem.ToString() == "신의" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                Plus.Enabled = true;
                Plus1.Enabled = true;
                Plus2.Enabled = true;
            }
            else if (job.SelectedItem.ToString() == "칠성" && tjsxor.SelectedItem.ToString() == "금액 수정")
            {
                Plus.Enabled = true;
                Plus1.Enabled = true;
                Plus2.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total.Text = "🌙골드문 ➰ 판매물품🌙 | 🧥방탄복🧥 | 🧨신호탄🧨 | 🏭가공공장이용권🏭 | 🛴신속배달📦";
        }

        private void qlghkf_Click(object sender, EventArgs e)
        {
            StreamReader sr2 = new StreamReader("시간값.txt", true);
            for (int i = 0; i < 2; i++)
                line[i] = sr2.ReadLine();
            sr2.Close();
            if (line[0] == "" && line[1] == "")
            {
                total.Text = "시간값 메모장에서 1번째 줄은 총누적 시간\r\n\r\n2번째 줄을 총누적 분으로 초기화 해주세요.";
            }
            else
            {

                snwjrtlrks.ReadOnly = true;
                snwjrqns.ReadOnly = true;

                snwjrtlrks.Text = line[0].ToString();
                snwjrqns.Text = line[1].ToString();

                tlwkr1.Text = "";
                whdfy1.Text = "";
            }
        }

        private void fltpt_Click(object sender, EventArgs e)
        {
            if (snwjrtlrks.ReadOnly == true && snwjrqns.ReadOnly == true)
            {
                StreamReader sr2 = new StreamReader("시간값.txt", true);
                for (int i = 0; i < 2; i++)
                    line[i] = sr2.ReadLine();
                sr2.Close();

                StreamWriter sw10 = new StreamWriter("시간값.txt", false);
                sw10.WriteLine(Convert.ToInt32(line[0]));
                sw10.WriteLine(Convert.ToInt32(line[1]));
                sw10.WriteLine(0);
                sw10.WriteLine(0);
                sw10.Close();

                StreamWriter sw = new StreamWriter("날짜.txt", false);
                sw.Write("");
                sw.Close();
                snwjrtlrks.Text = line[0];
                snwjrqns.Text = line[1];
  

                total.Text = "\r\n\t    ** 1주일 동안 기록된 **\r\n\r\n* 날짜와 누적 시간이 갱신 되었습니다.";
            }
            else
                total.Text = "가져오기를 먼저 클릭해주세요.";
        }

        private void snwjrqns_TextChanged(object sender, EventArgs e)
        {

        }

        private void whdfy_Click(object sender, EventArgs e)
        {
            if (snwjrtlrks.ReadOnly == true && snwjrqns.ReadOnly == true && ee == 1)
            {
                DateTime time2 = DateTime.Now;
                whdfy1.Text = time2.ToString();
                whdfy1.Text = System.DateTime.Now.ToString("tt hh시mm분");

                ba = time2.Day;
                cc = time2.Hour;
                dd = time2.Minute;
                                
                sum = cc - aa;
                sum1 = dd - bb;

                if (sum == 1 && sum1 != 0) // 수정 필요
                {
                    StreamReader sr2 = new StreamReader("시간값.txt", true);
                    for (int i = 0; i < 4; i++)
                        line[i] = sr2.ReadLine();
                    sr2.Close();                    
                    
                    if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) >= 60) // 이상 없음
                    {                        
                        StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                        sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw3.WriteLine("=================================");
                        sw3.Close();
                        sum1 -= 60;
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                        sw1.Close();
                        StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                        sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                        sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                        sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                        sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                        sw4.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) >= 60) // 이상 없음
                    {

                        StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                        sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw3.WriteLine("=================================");
                        sw3.Close();
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                        sw1.Close();
                        StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                        sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                        sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                        sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                        sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                        sw4.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) < 60) // 이상 없음
                    {
                        StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                        sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw3.WriteLine("=================================");
                        sw3.Close();
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                        sw1.Close();
                        StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                        sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                        sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                        sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                        sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) + 60);
                        sw4.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) < 60) // 이상 없음
                    {
                        StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                        sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw3.WriteLine("=================================");
                        sw3.Close();
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        if (sum1 + Convert.ToInt32(line[3]) +60 >= 60 && sum1 + Convert.ToInt32(line[1]) +60 >= 60)
                        {
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[3]) +60 < 60)
                        {
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2])-1, sum1 + Convert.ToInt32(line[3]) + 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2])-1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3])+60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) +60 < 60)
                        {
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) -1, sum1 + Convert.ToInt32(line[1]) + 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0])-1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1])+60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                            sw4.Close();
                        }
                        
                    }
                    StreamReader sr5 = new StreamReader("날짜.txt", true);
                    StreamReader sr6 = new StreamReader("시간누적.txt", false);
                    total.Text = sr5.ReadToEnd() + sr6.ReadToEnd();
                    sr5.Close();
                    sr6.Close();
                    tlwkr.Enabled = true;
                    snwjrtlrks.ReadOnly = false;
                    snwjrqns.ReadOnly = false;
                    ee = 0;
                }

                else if (sum < 0 && sum1 < 0) // 수정완 ( sum >= 60 일수가 없네? )
                {

                    sum += 23;
                    sum1 += 60;
                    
                    StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                    sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                    sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                    sw3.WriteLine("=================================");
                    sw3.Close();

                    StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                    sw4.WriteLine(sum + Convert.ToInt32(snwjrtlrks.Text));
                    sw4.WriteLine(sum1 + Convert.ToInt32(snwjrqns.Text));
                    sw4.WriteLine((Convert.ToInt32(sum) + Convert.ToInt32(line[2])));
                    sw4.WriteLine((Convert.ToInt32(sum1) + Convert.ToInt32(line[3])));
                    sw4.Close();

                    if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) < 60) // 수정완
                    {
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                        sw1.Close();
                        StreamWriter sw5 = new StreamWriter("시간값.txt", false);
                        sw5.WriteLine(sum + Convert.ToInt32(line[0]));
                        sw5.WriteLine(sum1 + Convert.ToInt32(line[1]));
                        sw5.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                        sw5.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                        sw5.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) >= 60) // 수정완
                    {
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                        sw1.Close();
                        StreamWriter sw5 = new StreamWriter("시간값.txt", false);
                        sw5.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                        sw5.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                        sw5.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                        sw5.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                        sw5.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) >= 60) // 수정완
                    {
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                        sw1.Close();
                        StreamWriter sw5 = new StreamWriter("시간값.txt", false);
                        sw5.WriteLine(sum + Convert.ToInt32(line[0]));
                        sw5.WriteLine(sum1 + Convert.ToInt32(line[1]));
                        sw5.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                        sw5.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                        sw5.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) < 60) // 수정완
                    {
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                        sw1.Close();
                        StreamWriter sw5 = new StreamWriter("시간값.txt", false);
                        sw5.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                        sw5.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                        sw5.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                        sw5.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                        sw5.Close();
                    }                                  

                    StreamReader sr = new StreamReader("날짜.txt", true);
                    StreamReader sr1 = new StreamReader("시간누적.txt", false);
                    total.Text = sr.ReadToEnd() + sr1.ReadToEnd();
                    sr.Close();
                    sr1.Close();
                    tlwkr.Enabled = true;
                    snwjrtlrks.ReadOnly = false;
                    snwjrqns.ReadOnly = false;
                    ee = 0;
                }

                else if (sum < 0 && sum1 == 0) // 수정완
                {
                    sum += 24;
                    StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                    sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                    sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                    sw3.WriteLine("=================================");
                    sw3.Close();
                    if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                    {
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                        sw1.Close();
                        StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                        sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                        sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                        sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                        sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                        sw4.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                    {
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1]) + 60));
                        sw1.Close();
                        StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                        sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                        sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) + 60);
                        sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                        sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                        sw4.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                    {
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3]) + 60));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                        sw1.Close();
                        StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                        sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                        sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                        sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                        sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) + 60);
                        sw4.Close();
                    }
                    else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                    {
                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                        sw1.Close();
                        StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                        sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                        sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                        sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                        sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                        sw4.Close();
                    }
                    StreamReader sr = new StreamReader("날짜.txt", true);
                    StreamReader sr1 = new StreamReader("시간누적.txt", false);
                    total.Text = sr.ReadToEnd() + sr1.ReadToEnd();
                    sr.Close();
                    sr1.Close();
                    tlwkr.Enabled = true;
                    snwjrtlrks.ReadOnly = false;
                    snwjrqns.ReadOnly = false;
                    ee = 0;
                }
                else if (ba - ab > 0) //수정중
                {                    
                    if (sum == 0 && sum1 < 0)
                    {
                        sum += 23;
                        sum1 += 60;
                        StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                        sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw3.WriteLine("=================================");
                        sw3.Close();
                        if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1]) + 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) + 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3]) + 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) + 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                            sw4.Close();
                        }
                    }
                    else
                    {
                        sum += ((ba - ab) * 24);                        
                        StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                        sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw3.WriteLine("=================================");
                        sw3.Close();
                        if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1]) + 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) + 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3]) + 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) + 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                            sw4.Close();
                        }
                    }
                    StreamReader sr = new StreamReader("날짜.txt", true);
                    StreamReader sr1 = new StreamReader("시간누적.txt", false);
                    total.Text = sr.ReadToEnd() + sr1.ReadToEnd();
                    sr.Close();
                    sr1.Close();
                    tlwkr.Enabled = true;
                    snwjrtlrks.ReadOnly = false;
                    snwjrqns.ReadOnly = false;
                    ee = 0;
                }

                else
                {
                    if (sum1 == 0)
                    {
                        StreamWriter sw = new StreamWriter("날짜.txt", true);
                        sw.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw.WriteLine("=================================");
                        sw.Close();

                        StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                        sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                        sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", Convert.ToInt32(line[0]), Convert.ToInt32(line[1])));
                        sw1.Close();
                    }

                    else if (sum < 0) // 수정완
                    {
                        sum += 23;
                        StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                        sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw3.WriteLine("=================================");
                        sw3.Close();
                        if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1]) + 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) + 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3]) + 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) + 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                            sw4.Close();
                        }
                    }

                    else if (sum1 < 0) //완
                    {
                        sum1 += 60;
                        StreamWriter sw3 = new StreamWriter("날짜.txt", true);
                        sw3.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw3.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw3.WriteLine("=================================");
                        sw3.Close();
                        StreamReader str = new StreamReader("시간값.txt", true);
                        for (int i = 0; i < 4; i++)
                        {
                            line[i] = str.ReadLine();
                        }
                        str.Close();
                        if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1]) + 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) + 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3]) + 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) + 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                            sw4.Close();
                        }

                    }

                    else //수정완
                    {
                        StreamWriter sw = new StreamWriter("날짜.txt", true);
                        sw.WriteLine("종료 시간 : " + whdfy1.Text);
                        sw.WriteLine("유지 시간 : " + sum + "시" + sum1 + "분");
                        sw.WriteLine("=================================");
                        sw.Close();
                       
                        if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) >= 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]) + 1, sum1 + Convert.ToInt32(line[3]) - 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1]) + 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) + 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]) + 1);
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) - 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) >= 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3]) + 60));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]) + 1, sum1 + Convert.ToInt32(line[1]) - 60));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]) + 1);
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]) - 60);
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]) + 60);
                            sw4.Close();
                        }
                        else if (sum1 + Convert.ToInt32(line[1]) < 60 && sum1 + Convert.ToInt32(line[3]) < 60)
                        {
                            StreamWriter sw1 = new StreamWriter("시간누적.txt", false);
                            sw1.WriteLine("\r\n누적 유지 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[2]), sum1 + Convert.ToInt32(line[3])));
                            sw1.WriteLine("총 누적 시간 : " + string.Format("{0}시간{1}분", sum + Convert.ToInt32(line[0]), sum1 + Convert.ToInt32(line[1])));
                            sw1.Close();
                            StreamWriter sw4 = new StreamWriter("시간값.txt", false);
                            sw4.WriteLine(sum + Convert.ToInt32(line[0]));
                            sw4.WriteLine(sum1 + Convert.ToInt32(line[1]));
                            sw4.WriteLine(Convert.ToInt32(sum) + Convert.ToInt32(line[2]));
                            sw4.WriteLine(Convert.ToInt32(sum1) + Convert.ToInt32(line[3]));
                            sw4.Close();
                        }

                    }

                    StreamReader sr = new StreamReader("날짜.txt", true);
                    StreamReader sr1 = new StreamReader("시간누적.txt", false);
                    total.Text = sr.ReadToEnd() + sr1.ReadToEnd();
                    sr.Close();
                    sr1.Close();
                    tlwkr.Enabled = true;
                    snwjrtlrks.ReadOnly = false;
                    snwjrqns.ReadOnly = false;
                    ee = 0;
                }
            }



            else if (ee == 0)
                total.Text = "접속하기를 먼저 눌러주세요.";
            else
                total.Text = "가져오기부터 다시 시작해주세요.";
                
            
        

        }

        private void tlwkr1_TextChanged(object sender, EventArgs e)
        {

        }

        private void whdfy1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
