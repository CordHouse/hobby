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

namespace test3
{
    public partial class 정산프로그램 : Form
    {
        string[] list = new string[20]; //이름
        string[] list1 = new string[20]; //방탄
        string[] list2 = new string[20]; //접속
        string[] list3 = new string[20]; //진급
        string[] list4 = new string[20]; //계좌
        string[] qkdxks = new string[11]; //방탄
        string[] tlrks = new string[11]; //시간

        public 정산프로그램()
        {            
            InitializeComponent();
            rPtks.Enabled = false;
            wjdtks.Enabled = false;
            rPtks.Enabled = false;
            wjdtks.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }                

        private void text2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (whdfb.SelectedItem.ToString() == "방탄순위" || whdfb.SelectedItem.ToString() == "접속순위" || whdfb.SelectedItem.ToString() == "종합정산")
            {
                rPtks.Enabled = true;
                wjdtks.Enabled = true;
            }
                      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = false; textBox21.Enabled = false; textBox41.Enabled = false; textBox61.Enabled = false; textBox89.Enabled = false;
            textBox2.Enabled = false; textBox22.Enabled = false; textBox42.Enabled = false; textBox62.Enabled = false; textBox90.Enabled = false;
            textBox3.Enabled = false; textBox23.Enabled = false; textBox43.Enabled = false; textBox63.Enabled = false; textBox91.Enabled = false;
            textBox4.Enabled = false; textBox24.Enabled = false; textBox44.Enabled = false; textBox64.Enabled = false; textBox92.Enabled = false;
            textBox5.Enabled = false; textBox25.Enabled = false; textBox45.Enabled = false; textBox65.Enabled = false; textBox93.Enabled = false;
            textBox6.Enabled = false; textBox26.Enabled = false; textBox46.Enabled = false; textBox66.Enabled = false; textBox94.Enabled = false;
            textBox7.Enabled = false; textBox27.Enabled = false; textBox47.Enabled = false; textBox67.Enabled = false; textBox95.Enabled = false;
            textBox8.Enabled = false; textBox28.Enabled = false; textBox48.Enabled = false; textBox68.Enabled = false; textBox96.Enabled = false;
            textBox9.Enabled = false; textBox29.Enabled = false; textBox49.Enabled = false; textBox69.Enabled = false; textBox97.Enabled = false;
            textBox10.Enabled = false; textBox30.Enabled = false; textBox50.Enabled = false; textBox70.Enabled = false; textBox98.Enabled = false;
            textBox11.Enabled = false; textBox31.Enabled = false; textBox51.Enabled = false; textBox71.Enabled = false; textBox99.Enabled = false;
            textBox12.Enabled = false; textBox32.Enabled = false; textBox52.Enabled = false; textBox72.Enabled = false; textBox100.Enabled = false;
            textBox13.Enabled = false; textBox33.Enabled = false; textBox53.Enabled = false; textBox73.Enabled = false; textBox101.Enabled = false;
            textBox14.Enabled = false; textBox34.Enabled = false; textBox54.Enabled = false; textBox74.Enabled = false; textBox102.Enabled = false;
            textBox15.Enabled = false; textBox35.Enabled = false; textBox55.Enabled = false; textBox75.Enabled = false; textBox103.Enabled = false;
            textBox16.Enabled = false; textBox36.Enabled = false; textBox56.Enabled = false; textBox76.Enabled = false; textBox104.Enabled = false;
            textBox17.Enabled = false; textBox37.Enabled = false; textBox57.Enabled = false; textBox77.Enabled = false; textBox105.Enabled = false;
            textBox18.Enabled = false; textBox38.Enabled = false; textBox58.Enabled = false; textBox78.Enabled = false; textBox106.Enabled = false;
            textBox19.Enabled = false; textBox39.Enabled = false; textBox59.Enabled = false; textBox79.Enabled = false; textBox107.Enabled = false;
            textBox20.Enabled = false; textBox40.Enabled = false; textBox60.Enabled = false; textBox80.Enabled = false; textBox108.Enabled = false;

            StreamReader sr = new StreamReader("목록.txt", true);
            StreamReader sr1 = new StreamReader("방탄.txt", true);
            StreamReader sr2 = new StreamReader("접속.txt", true);
            StreamReader sr3 = new StreamReader("진급.txt", true);
            StreamReader sr4 = new StreamReader("계좌.txt", true);
            for (int i = 0; i < 20; i++)
            {
                list[i] = sr.ReadLine();
                list1[i] = sr1.ReadLine();
                list2[i] = sr2.ReadLine();
                list3[i] = sr3.ReadLine();
                list4[i] = sr4.ReadLine();
                
            }
            sr.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sr4.Close();
            textBox1.Text = list[0]; textBox21.Text = list1[0]; textBox41.Text = list2[0]; textBox61.Text = list3[0]; textBox89.Text = list4[0];
            textBox2.Text = list[1]; textBox22.Text = list1[1]; textBox42.Text = list2[1]; textBox62.Text = list3[1]; textBox90.Text = list4[1];
            textBox3.Text = list[2]; textBox23.Text = list1[2]; textBox43.Text = list2[2]; textBox63.Text = list3[2]; textBox91.Text = list4[2];
            textBox4.Text = list[3]; textBox24.Text = list1[3]; textBox44.Text = list2[3]; textBox64.Text = list3[3]; textBox92.Text = list4[3];
            textBox5.Text = list[4]; textBox25.Text = list1[4]; textBox45.Text = list2[4]; textBox65.Text = list3[4]; textBox93.Text = list4[4];
            textBox6.Text = list[5]; textBox26.Text = list1[5]; textBox46.Text = list2[5]; textBox66.Text = list3[5]; textBox94.Text = list4[5];
            textBox7.Text = list[6]; textBox27.Text = list1[6]; textBox47.Text = list2[6]; textBox67.Text = list3[6]; textBox95.Text = list4[6];
            textBox8.Text = list[7]; textBox28.Text = list1[7]; textBox48.Text = list2[7]; textBox68.Text = list3[7]; textBox96.Text = list4[7];
            textBox9.Text = list[8]; textBox29.Text = list1[8]; textBox49.Text = list2[8]; textBox69.Text = list3[8]; textBox97.Text = list4[8];
            textBox10.Text = list[9]; textBox30.Text = list1[9]; textBox50.Text = list2[9]; textBox70.Text = list3[9]; textBox98.Text = list4[9];
            textBox11.Text = list[10]; textBox31.Text = list1[10]; textBox51.Text = list2[10]; textBox71.Text = list3[10]; textBox99.Text = list4[10];
            textBox12.Text = list[11]; textBox32.Text = list1[11]; textBox52.Text = list2[11]; textBox72.Text = list3[11]; textBox100.Text = list4[11];
            textBox13.Text = list[12]; textBox33.Text = list1[12]; textBox53.Text = list2[12]; textBox73.Text = list3[12]; textBox101.Text = list4[12];
            textBox14.Text = list[13]; textBox34.Text = list1[13]; textBox54.Text = list2[13]; textBox74.Text = list3[13]; textBox102.Text = list4[13];
            textBox15.Text = list[14]; textBox35.Text = list1[14]; textBox55.Text = list2[14]; textBox75.Text = list3[14]; textBox103.Text = list4[14];
            textBox16.Text = list[15]; textBox36.Text = list1[15]; textBox56.Text = list2[15]; textBox76.Text = list3[15]; textBox104.Text = list4[15];
            textBox17.Text = list[16]; textBox37.Text = list1[16]; textBox57.Text = list2[16]; textBox77.Text = list3[16]; textBox105.Text = list4[16];
            textBox18.Text = list[17]; textBox38.Text = list1[17]; textBox58.Text = list2[17]; textBox78.Text = list3[17]; textBox106.Text = list4[17];
            textBox19.Text = list[18]; textBox39.Text = list1[18]; textBox59.Text = list2[18]; textBox79.Text = list3[18]; textBox107.Text = list4[18];
            textBox20.Text = list[19]; textBox40.Text = list1[19]; textBox60.Text = list2[19]; textBox80.Text = list3[19]; textBox108.Text = list4[19];
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            StreamReader sr = new StreamReader("목록.txt", true);
            StreamReader sr1 = new StreamReader("방탄.txt", true);
            StreamReader sr2 = new StreamReader("접속.txt", true);
            StreamReader sr3 = new StreamReader("진급.txt", true);
            StreamReader sr4 = new StreamReader("계좌.txt", true);
            for (int i = 0; i < 20; i++)
            {
                list[i] = sr.ReadLine();
                list1[i] = sr1.ReadLine();
                list2[i] = sr2.ReadLine();
                list3[i] = sr3.ReadLine();
                list4[i] = sr4.ReadLine();
                
            }
            sr.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sr4.Close();

            textBox1.Enabled = true; textBox21.Enabled = true; textBox41.Enabled = true; textBox61.Enabled = true; textBox89.Enabled = true;
            textBox2.Enabled = true; textBox22.Enabled = true; textBox42.Enabled = true; textBox62.Enabled = true; textBox90.Enabled = true;
            textBox3.Enabled = true; textBox23.Enabled = true; textBox43.Enabled = true; textBox63.Enabled = true; textBox91.Enabled = true;
            textBox4.Enabled = true; textBox24.Enabled = true; textBox44.Enabled = true; textBox64.Enabled = true; textBox92.Enabled = true;
            textBox5.Enabled = true; textBox25.Enabled = true; textBox45.Enabled = true; textBox65.Enabled = true; textBox93.Enabled = true;
            textBox6.Enabled = true; textBox26.Enabled = true; textBox46.Enabled = true; textBox66.Enabled = true; textBox94.Enabled = true;
            textBox7.Enabled = true; textBox27.Enabled = true; textBox47.Enabled = true; textBox67.Enabled = true; textBox95.Enabled = true;
            textBox8.Enabled = true; textBox28.Enabled = true; textBox48.Enabled = true; textBox68.Enabled = true; textBox96.Enabled = true;
            textBox9.Enabled = true; textBox29.Enabled = true; textBox49.Enabled = true; textBox69.Enabled = true; textBox97.Enabled = true;
            textBox10.Enabled = true; textBox30.Enabled = true; textBox50.Enabled = true; textBox70.Enabled = true; textBox98.Enabled = true;
            textBox11.Enabled = true; textBox31.Enabled = true; textBox51.Enabled = true; textBox71.Enabled = true; textBox99.Enabled = true;
            textBox12.Enabled = true; textBox32.Enabled = true; textBox52.Enabled = true; textBox72.Enabled = true; textBox100.Enabled = true;
            textBox13.Enabled = true; textBox33.Enabled = true; textBox53.Enabled = true; textBox73.Enabled = true; textBox101.Enabled = true;
            textBox14.Enabled = true; textBox34.Enabled = true; textBox54.Enabled = true; textBox74.Enabled = true; textBox102.Enabled = true;
            textBox15.Enabled = true; textBox35.Enabled = true; textBox55.Enabled = true; textBox75.Enabled = true; textBox103.Enabled = true;
            textBox16.Enabled = true; textBox36.Enabled = true; textBox56.Enabled = true; textBox76.Enabled = true; textBox104.Enabled = true;
            textBox17.Enabled = true; textBox37.Enabled = true; textBox57.Enabled = true; textBox77.Enabled = true; textBox105.Enabled = true;
            textBox18.Enabled = true; textBox38.Enabled = true; textBox58.Enabled = true; textBox78.Enabled = true; textBox106.Enabled = true;
            textBox19.Enabled = true; textBox39.Enabled = true; textBox59.Enabled = true; textBox79.Enabled = true; textBox107.Enabled = true;
            textBox20.Enabled = true; textBox40.Enabled = true; textBox60.Enabled = true; textBox80.Enabled = true; textBox108.Enabled = true;

            StreamWriter sw = new StreamWriter("목록.txt", false);
            StreamWriter sw1 = new StreamWriter("방탄.txt", false);
            StreamWriter sw2 = new StreamWriter("접속.txt", false);
            StreamWriter sw3 = new StreamWriter("진급.txt", false);
            StreamWriter sw4 = new StreamWriter("계좌.txt", false);
            for (int i = 0; i < 20; i++)
            {
                sw.WriteLine(list[i]);
                sw1.WriteLine(list1[i]);
                sw2.WriteLine(list2[i]);
                sw3.WriteLine(list3[i]);
                sw4.WriteLine(list4[i]);
            }
            sw.Close();
            sw1.Close();
            sw2.Close();
            sw3.Close();
            sw4.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            StreamReader sr = new StreamReader("목록.txt", true);
            StreamReader sr1 = new StreamReader("방탄.txt", true);
            StreamReader sr2 = new StreamReader("접속.txt", true);
            StreamReader sr3 = new StreamReader("진급.txt", true);
            StreamReader sr4 = new StreamReader("계좌.txt", true);
            for (int i = 0; i < 20; i++)
            {
                list[i] = sr.ReadLine();
                list1[i] = sr1.ReadLine();
                list2[i] = sr2.ReadLine();
                list3[i] = sr3.ReadLine();
                list4[i] = sr4.ReadLine();
            }
            sr.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sr4.Close();

            list[0] = textBox1.Text; list1[0] = textBox21.Text; list2[0] = textBox41.Text; list3[0] = textBox61.Text; list4[0] = textBox89.Text;
            list[1] = textBox2.Text; list1[1] = textBox22.Text; list2[1] = textBox42.Text; list3[1] = textBox62.Text; list4[1] = textBox90.Text;
            list[2] = textBox3.Text; list1[2] = textBox23.Text; list2[2] = textBox43.Text; list3[2] = textBox63.Text; list4[2] = textBox91.Text;
            list[3] = textBox4.Text; list1[3] = textBox24.Text; list2[3] = textBox44.Text; list3[3] = textBox64.Text; list4[3] = textBox92.Text;
            list[4] = textBox5.Text; list1[4] = textBox25.Text; list2[4] = textBox45.Text; list3[4] = textBox65.Text; list4[4] = textBox93.Text;
            list[5] = textBox6.Text; list1[5] = textBox26.Text; list2[5] = textBox46.Text; list3[5] = textBox66.Text; list4[5] = textBox94.Text;
            list[6] = textBox7.Text; list1[6] = textBox27.Text; list2[6] = textBox47.Text; list3[6] = textBox67.Text; list4[6] = textBox95.Text;
            list[7] = textBox8.Text; list1[7] = textBox28.Text; list2[7] = textBox48.Text; list3[7] = textBox68.Text; list4[7] = textBox96.Text;
            list[8] = textBox9.Text; list1[8] = textBox29.Text; list2[8] = textBox49.Text; list3[8] = textBox69.Text; list4[8] = textBox97.Text;
            list[9] = textBox10.Text; list1[9] = textBox30.Text; list2[9] = textBox50.Text; list3[9] = textBox70.Text; list4[9] = textBox98.Text;
            list[10] = textBox11.Text; list1[10] = textBox31.Text; list2[10] = textBox51.Text; list3[10] = textBox71.Text; list4[10] = textBox99.Text;
            list[11] = textBox12.Text; list1[11] = textBox32.Text; list2[11] = textBox52.Text; list3[11] = textBox72.Text; list4[11] = textBox100.Text;
            list[12] = textBox13.Text; list1[12] = textBox33.Text; list2[12] = textBox53.Text; list3[12] = textBox73.Text; list4[12] = textBox101.Text;
            list[13] = textBox14.Text; list1[13] = textBox34.Text; list2[13] = textBox54.Text; list3[13] = textBox74.Text; list4[13] = textBox102.Text;
            list[14] = textBox15.Text; list1[14] = textBox35.Text; list2[14] = textBox55.Text; list3[14] = textBox75.Text; list4[14] = textBox103.Text;
            list[15] = textBox16.Text; list1[15] = textBox36.Text; list2[15] = textBox56.Text; list3[15] = textBox76.Text; list4[15] = textBox104.Text;
            list[16] = textBox17.Text; list1[16] = textBox37.Text; list2[16] = textBox57.Text; list3[16] = textBox77.Text; list4[16] = textBox105.Text;
            list[17] = textBox18.Text; list1[17] = textBox38.Text; list2[17] = textBox58.Text; list3[17] = textBox78.Text; list4[17] = textBox106.Text;
            list[18] = textBox19.Text; list1[18] = textBox39.Text; list2[18] = textBox59.Text; list3[18] = textBox79.Text; list4[18] = textBox107.Text;
            list[19] = textBox20.Text; list1[19] = textBox40.Text; list2[19] = textBox60.Text; list3[19] = textBox80.Text; list4[19] = textBox108.Text;
            StreamWriter sw = new StreamWriter("목록.txt", false);
            StreamWriter sw1 = new StreamWriter("방탄.txt", false);
            StreamWriter sw2 = new StreamWriter("접속.txt", false);
            StreamWriter sw3 = new StreamWriter("진급.txt", false);
            StreamWriter sw4 = new StreamWriter("계좌.txt", false);
            for (int i = 0; i < 20; i++)
            {
                sw.WriteLine(list[i]);
                sw1.WriteLine(list1[i]);
                sw2.WriteLine(list2[i]);
                sw3.WriteLine(list3[i]);
                sw4.WriteLine(list4[i]);
            }
            sw.Close();
            sw1.Close();
            sw2.Close();
            sw3.Close();
            sw4.Close();

            textBox1.Enabled = false; textBox21.Enabled = false; textBox41.Enabled = false; textBox61.Enabled = false; textBox89.Enabled = false;
            textBox2.Enabled = false; textBox22.Enabled = false; textBox42.Enabled = false; textBox62.Enabled = false; textBox90.Enabled = false;
            textBox3.Enabled = false; textBox23.Enabled = false; textBox43.Enabled = false; textBox63.Enabled = false; textBox91.Enabled = false;
            textBox4.Enabled = false; textBox24.Enabled = false; textBox44.Enabled = false; textBox64.Enabled = false; textBox92.Enabled = false;
            textBox5.Enabled = false; textBox25.Enabled = false; textBox45.Enabled = false; textBox65.Enabled = false; textBox93.Enabled = false;
            textBox6.Enabled = false; textBox26.Enabled = false; textBox46.Enabled = false; textBox66.Enabled = false; textBox94.Enabled = false;
            textBox7.Enabled = false; textBox27.Enabled = false; textBox47.Enabled = false; textBox67.Enabled = false; textBox95.Enabled = false;
            textBox8.Enabled = false; textBox28.Enabled = false; textBox48.Enabled = false; textBox68.Enabled = false; textBox96.Enabled = false;
            textBox9.Enabled = false; textBox29.Enabled = false; textBox49.Enabled = false; textBox69.Enabled = false; textBox97.Enabled = false;
            textBox10.Enabled = false; textBox30.Enabled = false; textBox50.Enabled = false; textBox70.Enabled = false; textBox98.Enabled = false;
            textBox11.Enabled = false; textBox31.Enabled = false; textBox51.Enabled = false; textBox71.Enabled = false; textBox99.Enabled = false;
            textBox12.Enabled = false; textBox32.Enabled = false; textBox52.Enabled = false; textBox72.Enabled = false; textBox100.Enabled = false;
            textBox13.Enabled = false; textBox33.Enabled = false; textBox53.Enabled = false; textBox73.Enabled = false; textBox101.Enabled = false;
            textBox14.Enabled = false; textBox34.Enabled = false; textBox54.Enabled = false; textBox74.Enabled = false; textBox102.Enabled = false;
            textBox15.Enabled = false; textBox35.Enabled = false; textBox55.Enabled = false; textBox75.Enabled = false; textBox103.Enabled = false;
            textBox16.Enabled = false; textBox36.Enabled = false; textBox56.Enabled = false; textBox76.Enabled = false; textBox104.Enabled = false;
            textBox17.Enabled = false; textBox37.Enabled = false; textBox57.Enabled = false; textBox77.Enabled = false; textBox105.Enabled = false;
            textBox18.Enabled = false; textBox38.Enabled = false; textBox58.Enabled = false; textBox78.Enabled = false; textBox106.Enabled = false;
            textBox19.Enabled = false; textBox39.Enabled = false; textBox59.Enabled = false; textBox79.Enabled = false; textBox107.Enabled = false;
            textBox20.Enabled = false; textBox40.Enabled = false; textBox60.Enabled = false; textBox80.Enabled = false; textBox108.Enabled = false;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            int[] qoduf = new int[20]; //방탄
            for (int j = 0; j < 20; j++)
            {
                if(list1[j] != "")
                    qoduf[j] = Convert.ToInt32(list1[j]);
            }
            Array.Sort(qoduf);
            Array.Reverse(qoduf);

            int[] qoduf1 = new int[20]; //접속
            for (int r = 0; r < 20; r++)
            {
                if (list2[r] != "")
                    qoduf1[r] = Convert.ToInt32(list2[r]);
            }
            Array.Sort(qoduf1);
            Array.Reverse(qoduf1);

            StreamReader sr = new StreamReader("목록.txt", true);
            StreamReader sr1 = new StreamReader("방탄.txt", true);
            StreamReader sr2 = new StreamReader("접속.txt", true);
            StreamReader sr3 = new StreamReader("진급.txt", true);
            StreamReader sr4 = new StreamReader("계좌.txt", true);
            for (int i = 0; i < 20; i++)
            {                
                list[i] = sr.ReadLine();
                list1[i] = sr1.ReadLine();
                list2[i] = sr2.ReadLine();
                list3[i] = sr3.ReadLine();
                list4[i] = sr4.ReadLine();
            }
            sr.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sr4.Close();                           
            
            if (whdfb.SelectedItem.ToString() == "방탄순위")
            {
                for (int i = 0; i < 20; i++)
                {
                    if (list1[i] != "" && list2[i] != "")
                    {
                        if (Convert.ToInt32(list1[i]) == qoduf[0])
                        {
                            qkdxks[0] = list[i] + "\r\n" + "- 방탄복 1등 : " + list1[i] + "개";
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[1])
                        {
                            qkdxks[1] = list[i] + "\r\n" + "- 방탄복 2등 : " + list1[i] + "개";
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[2])
                        {
                            qkdxks[2] = list[i] + "\r\n" + "- 방탄복 3등 : " + list1[i] + "개";
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[3])
                        {
                            qkdxks[3] = list[i] + "\r\n" + "- 방탄복 4등 : " + list1[i] + "개";
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[4])
                        {
                            qkdxks[4] = list[i] + "\r\n" + "- 방탄복 5등 : " + list1[i] + "개";
                        }
                    }
                }
                whdgkq.Text = qkdxks[0] + "\r\n\r\n" + qkdxks[1] + "\r\n\r\n" + qkdxks[2] + "\r\n\r\n" + qkdxks[3] + "\r\n\r\n" + qkdxks[4];
            }
            else if (whdfb.SelectedItem.ToString() == "접속순위")
            {
                for (int i = 0; i < 20; i++)
                {
                    if (list1[i] != "" && list2[i] != "")
                    {
                        if (Convert.ToInt32(list2[i]) == qoduf1[0])
                        {
                            tlrks[0] = list[i] + "\r\n" + "- 접률 1등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i]));
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[1])
                        {
                            tlrks[1] = list[i] + "\r\n" + "- 접률 2등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i]));
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[2])
                        {
                            tlrks[2] = list[i] + "\r\n" + "- 접률 3등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i]));
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[3])
                        {
                            tlrks[3] = list[i] + "\r\n" + "- 접률 4등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i]));
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[4])
                        {
                            tlrks[4] = list[i] + "\r\n" + "- 접률 5등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i]));
                        }
                    }
                }
                whdgkq.Text = tlrks[0] + "\r\n\r\n" + tlrks[1] + "\r\n\r\n" + tlrks[2] + "\r\n\r\n" + tlrks[3] + "\r\n\r\n" + tlrks[4];
            }            
                      

            if (whdfb.SelectedItem.ToString() == "종합정산")
            {
                for (int i = 0; i < 20; i++) 
                {
                    if (list1[i] != "" && list2[i] != "")
                    {
                        if (Convert.ToInt32(list1[i]) == qoduf[0])
                        {
                            qkdxks[0] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 1등 : " + list1[i] + "개" + " 2500만원\r\n" + "=25,000,000원";
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[1])
                        {
                            qkdxks[1] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 2등 : " + list1[i] + "개" + " 2000만원\r\n" + "=20,000,000원";
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[2])
                        {
                            qkdxks[2] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 3등 : " + list1[i] + "개" + " 1500만원\r\n" + "=15,000,000원";
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[3])
                        {
                            qkdxks[3] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 4등 : " + list1[i] + "개" + " 1000만원\r\n" + "=10,000,000원";
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[4])
                        {
                            qkdxks[4] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 5등 : " + list1[i] + "개" + " 500만원\r\n" + "=5,000,000원";
                        }
                        if (Convert.ToInt32(list2[i]) == qoduf1[0])
                        {
                            tlrks[0] = list[i] + "\r\n" + "- 접률 1등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i])) + " 2500만원\r\n" + "=25,000,000원";
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[1])
                        {
                            tlrks[1] = list[i] + "\r\n" + "- 접률 2등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i])) + " 2000만원\r\n" + "=20,000,000원";
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[2])
                        {
                            tlrks[2] = list[i] + "\r\n" + "- 접률 3등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i])) +" 1500만원\r\n" + "=15,000,000원";
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[3])
                        {
                            tlrks[3] = list[i] + "\r\n" + "- 접률 4등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i])) + " 1000만원\r\n" + "=10,000,000원";
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[4])
                        {
                            tlrks[4] = list[i] + "\r\n" + "- 접률 5등 : " + string.Format("{0:0#시간#0분}", Convert.ToInt32(list2[i])) + " 500만원\r\n" + "=5,000,000원";
                        }
                    }
                }
                whdgkq.Text = "[방탄]\r\n\r\n" + qkdxks[0] + "\r\n\r\n" + qkdxks[1] + "\r\n\r\n" + qkdxks[2] + "\r\n\r\n" + qkdxks[3] + "\r\n\r\n" + qkdxks[4] + "\r\n\r\n\r\n" 
                    + "[접률]\r\n\r\n" + tlrks[0] + "\r\n\r\n" + tlrks[1] + "\r\n\r\n" + tlrks[2] + "\r\n\r\n" + tlrks[3] + "\r\n\r\n" + tlrks[4];
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] qoduf = new int[20]; //방탄
            for (int j = 0; j < 20; j++)
            {
                if (list1[j] != "")
                    qoduf[j] = Convert.ToInt32(list1[j]);
            }
            Array.Sort(qoduf);
            Array.Reverse(qoduf);

            int[] qoduf1 = new int[20]; //접속
            for (int r = 0; r < 20; r++)
            {
                if (list2[r] != "")
                    qoduf1[r] = Convert.ToInt32(list2[r]);
            }
            Array.Sort(qoduf1);
            Array.Reverse(qoduf1);

            StreamReader sr = new StreamReader("목록.txt", true);
            StreamReader sr1 = new StreamReader("방탄.txt", true);
            StreamReader sr2 = new StreamReader("접속.txt", true);
            StreamReader sr3 = new StreamReader("진급.txt", true);
            StreamReader sr4 = new StreamReader("계좌.txt", true);
            for (int i = 0; i < 20; i++)
            {
                list[i] = sr.ReadLine();
                list1[i] = sr1.ReadLine();
                list2[i] = sr2.ReadLine();
                list3[i] = sr3.ReadLine();
                list4[i] = sr4.ReadLine();
            }
            sr.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sr4.Close();

            if (whdfb.SelectedItem.ToString() == "종합정산")
            {                
                for (int i = 0; i < 20; i++)
                {
                    if (list1[i] != "" && list2[i] != "")
                    {

                        if (Convert.ToInt32(list1[i]) == qoduf[0]) //방탄 1등일때
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                qkdxks[0] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 1등" + " 2500만원 ";

                                if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) != 0)
                                    tlrks[0] = String.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 25000000 + Convert.ToInt32(list3[i]) * 10000);

                                if (Convert.ToInt32(list2[i]) == qoduf1[j])
                                {
                                    if (list3[i] == "0")
                                    {
                                        if (j == 0)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원" + "=50,000,000원";
                                        else if (j == 1)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원" + "=45,000,000원";
                                        else if (j == 2)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원" + "=40,000,000원";
                                        else if (j == 3)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원" + "=35,000,000원";
                                        else if (j == 4)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원" + "=30,000,000원";
                                    }
                                    else if (list3[i] != "0")
                                    {
                                        if (j == 0)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 50000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 1)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 45000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 2)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 40000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 3)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 35000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 4)
                                            tlrks[0] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 30000000 + Convert.ToInt32(list3[i]) * 10000);
                                    }
                                }
                                else if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) == 0)
                                {
                                    qkdxks[0] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 1등" + " 2500만원\r\n";
                                    tlrks[0] = string.Format("={0:#,##0}원", 25000000);
                                }
                            }
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[1]) //방탄 2등일때
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                qkdxks[1] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 2등" + " 2000만원 ";

                                if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) != 0)
                                {
                                    tlrks[1] = String.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 20000000 + Convert.ToInt32(list3[i]) * 10000);
                                }
                                if (Convert.ToInt32(list2[i]) == qoduf1[j])
                                {
                                    if (list3[i] == "0")
                                    {
                                        if (j == 0)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원" + "=45,000,000원";
                                        else if (j == 1)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원" + "=40,000,000원";
                                        else if (j == 2)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원" + "=35,000,000원";
                                        else if (j == 3)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원" + "=30,000,000원";
                                        else if (j == 4)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원" + "=25,000,000원";
                                    }
                                    else if (list3[i] != "0")
                                    {
                                        if (j == 0)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 45000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 1)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 40000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 2)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 35000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 3)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 30000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 4)
                                            tlrks[1] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 25000000 + Convert.ToInt32(list3[i]) * 10000);
                                    }
                                }
                                else if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) == 0)
                                {
                                    qkdxks[1] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 2등" + " 2000만원\r\n";
                                    tlrks[1] = string.Format("={0:#,##0}원", 20000000);
                                }
                            }
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[2]) //방탄 3등일때
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                qkdxks[2] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 3등" + " 1500만원 ";

                                if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) != 0)
                                {
                                    tlrks[2] = String.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 15000000 + Convert.ToInt32(list3[i]) * 10000);
                                }
                                if (Convert.ToInt32(list2[i]) == qoduf1[j])
                                {
                                    if (list3[i] == "0")
                                    {
                                        if (j == 0)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원" + "=40,000,000원";
                                        else if (j == 1)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원" + "=35,000,000원";
                                        else if (j == 2)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원" + "=30,000,000원";
                                        else if (j == 3)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원" + "=25,000,000원";
                                        else if (j == 4)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원" + "=20,000,000원";
                                    }
                                    else if (list3[i] != "0")
                                    {
                                        if (j == 0)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 40000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 1)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 35000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 2)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 30000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 3)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 25000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 4)
                                            tlrks[2] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 20000000 + Convert.ToInt32(list3[i]) * 10000);
                                    }
                                }
                                else if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) == 0)
                                {
                                    qkdxks[2] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 3등" + " 1500만원\r\n";
                                    tlrks[2] = string.Format("={0:#,##0}원", 15000000);
                                }
                            }
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[3]) //방탄 4등일때
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                qkdxks[3] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 4등" + " 1000만원 ";

                                if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) != 0)
                                {
                                    tlrks[3] = String.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + String.Format("\r\n ={0:#,##0}원", 10000000 + Convert.ToInt32(list3[i]) * 10000);
                                }
                                if (Convert.ToInt32(list2[i]) == qoduf1[j])
                                {
                                    if (list3[i] == "0")
                                    {
                                        if (j == 0)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원" + "=35,000,000원";
                                        else if (j == 1)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원" + "=30,000,000원";
                                        else if (j == 2)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원" + "=25,000,000원";
                                        else if (j == 3)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원" + "=20,000,000원";
                                        else if (j == 4)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원" + "=15,000,000원";
                                    }
                                    else if (list3[i] != "0")
                                    {
                                        if (j == 0)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 35000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 1)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 30000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 2)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 25000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 3)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 20000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 4)
                                            tlrks[3] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 15000000 + Convert.ToInt32(list3[i]) * 10000);
                                    }
                                }
                                else if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) == 0)
                                {
                                    qkdxks[3] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 4등" + " 1000만원\r\n";
                                    tlrks[3] = string.Format("={0:#,##0}원", 10000000);
                                }
                            }
                        }
                        else if (Convert.ToInt32(list1[i]) == qoduf[4]) //방탄 5등일때
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                qkdxks[4] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 5등" + " 500만원 ";

                                if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) != 0)
                                {
                                    tlrks[4] = String.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 5000000 + Convert.ToInt32(list3[i]) * 10000);
                                }
                                if (Convert.ToInt32(list2[i]) == qoduf1[j])
                                {
                                    if (list3[i] == "0")
                                    {
                                        if (j == 0)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원" + "=30,000,000원";
                                        else if (j == 1)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원" + "=25,000,000원";
                                        else if (j == 2)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원" + "=20,000,000원";
                                        else if (j == 3)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원" + "=15,000,000원";
                                        else if (j == 4)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원" + "=10,000,000원";
                                    }
                                    else if (list3[i] != "0")
                                    {
                                        if (j == 0)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 30000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 1)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 2000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 25000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 2)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 20000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 3)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 1000만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 15000000 + Convert.ToInt32(list3[i]) * 10000);
                                        else if (j == 4)
                                            tlrks[4] = string.Format("+ 접률 {0}등 : ", j + 1) + " 500만원 + " + string.Format("승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 10000000 + Convert.ToInt32(list3[i]) * 10000);
                                    }
                                }
                                else if (Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) == 0)
                                {
                                    qkdxks[4] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 방탄복 5등" + " 500만원\r\n";
                                    tlrks[4] = string.Format("={0:#,##0}원", 5000000);
                                }
                            }
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[0]) //접률 1등일때
                        {
                            qkdxks[5] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 접률 1등" + " 2500만원 ";

                            if (Convert.ToInt32(list3[i]) != 0)
                            {
                                tlrks[5] = string.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 25000000 + Convert.ToInt32(list3[i]) * 10000);
                            }

                            else if (Convert.ToInt32(list3[i]) == 0)
                            {
                                tlrks[5] = string.Format("\r\n={0:#,##0}원", 25000000);
                            }

                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[1]) //접률 2등일때
                        {
                            qkdxks[6] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 접률 2등" + " 2000만원 ";

                            if (Convert.ToInt32(list3[i]) != 0)
                            {
                                tlrks[6] = string.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 20000000 + Convert.ToInt32(list3[i]) * 10000);
                            }

                            else if (Convert.ToInt32(list3[i]) == 0)
                            {
                                tlrks[6] = string.Format("\r\n={0:#,##0}원", 20000000);
                            }

                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[2]) //접률 3등일때
                        {
                            qkdxks[7] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 접률 3등" + " 1500만원 ";

                            if (Convert.ToInt32(list3[i]) != 0)
                            {
                                tlrks[7] = string.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 15000000 + Convert.ToInt32(list3[i]) * 10000);
                            }

                            else if ( Convert.ToInt32(list3[i]) == 0)
                            {
                                tlrks[7] = string.Format("\r\n={0:#,##0}원", 15000000);
                            }

                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[3]) //접률 4등일때
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                qkdxks[8] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 접률 4등" + " 1000만원 ";

                                if (Convert.ToInt32(list3[i]) != 0)
                                {
                                    tlrks[8] = string.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 10000000 + Convert.ToInt32(list3[i]) * 10000);
                                }

                                else if (Convert.ToInt32(list3[i]) == 0)
                                {
                                    tlrks[8] = string.Format("\r\n={0:#,##0}원", 10000000);
                                }
                            }
                        }
                        else if (Convert.ToInt32(list2[i]) == qoduf1[4]) //접률 5등일때
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                qkdxks[9] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n" + "- 접률 5등" + " 500만원 ";

                                if ( Convert.ToInt32(list3[i]) != 0)
                                {
                                    tlrks[9] = string.Format("+ 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원", 5000000 + Convert.ToInt32(list3[i]) * 10000);
                                }

                                else if (Convert.ToInt32(list3[i]) == 0)
                                {
                                    tlrks[9] = string.Format("\r\n={0:#,##0}원", 5000000);
                                }
                            }
                        }
                        else if(Convert.ToInt32(list1[i]) < qoduf[4] && Convert.ToInt32(list2[i]) < qoduf1[4] && Convert.ToInt32(list3[i]) != 0)
                        {
                            qkdxks[10] = list[i] + "[계좌번호 : " + list4[i] + "]\r\n";
                            tlrks[10] = string.Format("- 승진비 {0}만원", Convert.ToInt32(list3[i])) + string.Format("\r\n ={0:#,##0}원",Convert.ToInt32(list3[i]) * 10000);
                        }

                    }

                }
                whdgkq.Text ="```\r\n" + qkdxks[0] + tlrks[0] + "\r\n\r\n" + qkdxks[1] + tlrks[1] + "\r\n\r\n" + qkdxks[2] + tlrks[2] + "\r\n\r\n" + qkdxks[3] + tlrks[3] + "\r\n\r\n" + qkdxks[4] + tlrks[4] + "\r\n\r\n" + qkdxks[5] + tlrks[5] + "\r\n\r\n" + qkdxks[6] + tlrks[6] + "\r\n\r\n" + qkdxks[7] + tlrks[7] + "\r\n\r\n" + qkdxks[8] + tlrks[8] + "\r\n\r\n" + qkdxks[9] + tlrks[9] + "\r\n\r\n" + qkdxks[10] + tlrks[10] + "```";
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {            
            StreamWriter sw1 = new StreamWriter("방탄.txt", false);
            StreamWriter sw2 = new StreamWriter("접속.txt", false);
            StreamWriter sw3 = new StreamWriter("진급.txt", false);
            for (int i = 0; i < 20; i++)
            {
                sw1.WriteLine("0");
                sw2.WriteLine("0");
                sw3.WriteLine("0");
            }
            sw1.Close();
            sw2.Close();
            sw3.Close();
            whdgkq.Text = "* 기록이 초기화 되었습니다.";
        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
