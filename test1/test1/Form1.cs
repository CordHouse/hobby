using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] rand = new int[1000];
            double[] red = new double[37];
            double[] black = new double[37];
            double[] green = new double[37];
            /*
            String entereddlqfur = dlqfur.Text.Trim();
            int num1 = 0;
            if (!int.TryParse(entereddlqfur, out num1))
                return;*/

            //DateTime data1 = new DateTime(num1);
            
            Random rd = new Random();

            tlwkr.Text = string.Format("{0:##-##-##-##-##}",DateTime.Now.ToString());
            //tlwkr.Text = DateTime.Now.ToString();            
                       
            for (int i = 0; i < 1000; i++)
            {                
                rand[i] = rd.Next(0, 37);
                switch (rand[i])
                {
                    case 0:
                        green[0] += 1; break;

                    case 1:
                        red[1] += 1; break;
                    case 3:
                        red[3] += 1; break;
                    case 5:
                        red[5] += 1; break;
                    case 7:
                        red[7] += 1; break;
                    case 9:
                        red[9] += 1; break;
                    case 12:
                        red[12] += 1; break;
                    case 14:
                        red[14] += 1; break;
                    case 16:
                        red[16] += 1; break;
                    case 18:
                        red[18] += 1; break;
                    case 19:
                        red[19] += 1; break;
                    case 21:
                        red[21] += 1; break;
                    case 23:
                        red[23] += 1; break;
                    case 25:
                        red[25] += 1; break;
                    case 27:
                        red[27] += 1; break;
                    case 30:
                        red[30] += 1; break;
                    case 32:
                        red[32] += 1; break;
                    case 34:
                        red[34] += 1; break;
                    case 36:
                        red[36] += 1; break;

                    case 2:
                        black[2] += 1; break;
                    case 4:
                        black[4] += 1; break;
                    case 6:
                        black[6] += 1; break;
                    case 8:
                        black[8] += 1; break;
                    case 10:
                        black[10] += 1; break;
                    case 11:
                        black[11] += 1; break;
                    case 13:
                        black[13] += 1; break;
                    case 15:
                        black[15] += 1; break;
                    case 17:
                        black[17] += 1; break;
                    case 20:
                        black[20] += 1; break;
                    case 22:
                        black[22] += 1; break;
                    case 24:
                        black[24] += 1; break;
                    case 26:
                        black[26] += 1; break;
                    case 28:
                        black[28] += 1; break;
                    case 29:
                        black[29] += 1; break;
                    case 31:
                        black[31] += 1; break;
                    case 33:
                        black[33] += 1; break;
                    case 35:
                        black[35] += 1; break;

                }                
                //Thread.Sleep(950);
            }
           
            whdfy.Text = string.Format("{0:##-##-##-##-##}", DateTime.Now.ToString());
            rufrhk.Text = string.Format("0번- {0}%  1번- {1}%  2번- {2}%  3번- {3}%  4번- {4}% \r\n\r\n5번- {5}%  6번- {6}%  7번- {7}%  8번- {8}%  9번- {9}% \r\n\r\n", green[0] / 1000, red[1] / 1000, black[2] / 1000, red[3] / 1000, black[4] / 1000, red[5] / 1000, black[6] / 1000, red[7] / 1000, black[8] / 1000, red[9] / 1000) +
                string.Format("10번- {0}%  11번- {1}%  12번- {2}%  13번- {3}%  14번- {4}% \r\n\r\n15번- {5}%  16번- {6}%  17번- {7}%  18번- {8}%  19번- {9}% \r\n\r\n", black[10] / 1000, black[11] / 1000, red[12] / 1000, black[13] / 1000, red[14] / 1000, black[15] / 1000, red[16] / 1000, black[17] / 1000, red[18] / 1000, red[19] / 1000) +
                string.Format("20번- {0}%  21번- {1}%  22번- {2}%  23번- {3}%  24번- {4}% \r\n\r\n25번- {5}%  26번- {6}%  27번- {7}%  28번- {8}%  29번- {9}% \r\n\r\n", black[20] / 1000, red[21] / 1000, black[22] / 1000, red[23] / 1000, black[24] / 1000, red[25] / 1000, black[26] / 1000, red[27] / 1000, black[28] / 1000, black[29] / 1000) +
                string.Format("30번- {0}%  31번- {1}%  32번- {2}%  33번- {3}%  34번- {4}% \r\n\r\n35번- {5}%  36번- {6}%", red[30] / 1000, black[31] / 1000, red[32] / 1000, black[33] / 1000, red[34] / 1000, black[35] / 1000, red[36] / 1000);
        
        }
    }
}
