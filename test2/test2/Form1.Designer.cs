
namespace test2
{
    partial class 골드문방탄계산기
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(골드문방탄계산기));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.ComboBox();
            this.blink1 = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.ghkswjs = new System.Windows.Forms.Button();
            this.tlsgh = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.RadioButton();
            this.blout = new System.Windows.Forms.RadioButton();
            this.tlscjd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Plus1 = new System.Windows.Forms.Button();
            this.wjrcnf = new System.Windows.Forms.RadioButton();
            this.dlsrhd = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.wkdrl = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.wkd = new System.Windows.Forms.Button();
            this.snwjr = new System.Windows.Forms.TextBox();
            this.chdsnwjr = new System.Windows.Forms.TextBox();
            this.Tmrl = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rodtls = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tlwkr = new System.Windows.Forms.Button();
            this.whdfy = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tlwkr1 = new System.Windows.Forms.TextBox();
            this.whdfy1 = new System.Windows.Forms.TextBox();
            this.snwjrtlrks = new System.Windows.Forms.TextBox();
            this.snwjrqns = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.qlghkf = new System.Windows.Forms.Button();
            this.fltpt = new System.Windows.Forms.Button();
            this.tjfaud = new System.Windows.Forms.Label();
            this.설명 = new System.Windows.Forms.Label();
            this.골드문 = new System.Windows.Forms.Label();
            this.chrlghk = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.vksao1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.qkdxks = new System.Windows.Forms.TextBox();
            this.Plus2 = new System.Windows.Forms.Button();
            this.tnwjd1 = new System.Windows.Forms.TextBox();
            this.tnwjd2 = new System.Windows.Forms.TextBox();
            this.tjsxor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "구분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "개수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "방탄 수수료";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "30%";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // job
            // 
            this.job.AutoCompleteCustomSource.AddRange(new string[] {
            "시민",
            "범서",
            "신의",
            "칠성"});
            this.job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.job.FormattingEnabled = true;
            this.job.Items.AddRange(new object[] {
            "시민",
            "범서",
            "신의",
            "칠성"});
            this.job.Location = new System.Drawing.Point(111, 92);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(109, 20);
            this.job.TabIndex = 7;
            this.job.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // blink1
            // 
            this.blink1.Location = new System.Drawing.Point(111, 202);
            this.blink1.Multiline = true;
            this.blink1.Name = "blink1";
            this.blink1.Size = new System.Drawing.Size(109, 27);
            this.blink1.TabIndex = 9;
            this.blink1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(14, 266);
            this.total.Multiline = true;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(283, 196);
            this.total.TabIndex = 14;
            this.total.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(303, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "1. 방탄";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Plus.ForeColor = System.Drawing.Color.Crimson;
            this.Plus.Location = new System.Drawing.Point(355, 118);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(37, 27);
            this.Plus.TabIndex = 16;
            this.Plus.Text = "수정";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // ghkswjs
            // 
            this.ghkswjs.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ghkswjs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ghkswjs.Location = new System.Drawing.Point(139, 489);
            this.ghkswjs.Name = "ghkswjs";
            this.ghkswjs.Size = new System.Drawing.Size(47, 27);
            this.ghkswjs.TabIndex = 18;
            this.ghkswjs.Text = "환전";
            this.ghkswjs.UseVisualStyleBackColor = false;
            this.ghkswjs.Click += new System.EventHandler(this.rjadms_Click);
            // 
            // tlsgh
            // 
            this.tlsgh.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tlsgh.ForeColor = System.Drawing.Color.Firebrick;
            this.tlsgh.Location = new System.Drawing.Point(348, 474);
            this.tlsgh.Name = "tlsgh";
            this.tlsgh.Size = new System.Drawing.Size(66, 32);
            this.tlsgh.TabIndex = 19;
            this.tlsgh.Text = "신호탄";
            this.tlsgh.UseVisualStyleBackColor = false;
            this.tlsgh.Click += new System.EventHandler(this.tlsgh_Click);
            // 
            // body
            // 
            this.body.AutoSize = true;
            this.body.Location = new System.Drawing.Point(252, 474);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(87, 16);
            this.body.TabIndex = 20;
            this.body.TabStop = true;
            this.body.Text = "신호탄 총신";
            this.body.UseVisualStyleBackColor = true;
            this.body.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // blout
            // 
            this.blout.AutoSize = true;
            this.blout.Location = new System.Drawing.Point(252, 496);
            this.blout.Name = "blout";
            this.blout.Size = new System.Drawing.Size(87, 16);
            this.blout.TabIndex = 21;
            this.blout.TabStop = true;
            this.blout.Text = "신호탄 총알";
            this.blout.UseVisualStyleBackColor = true;
            this.blout.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // tlscjd
            // 
            this.tlscjd.Location = new System.Drawing.Point(14, 489);
            this.tlscjd.Multiline = true;
            this.tlscjd.Name = "tlscjd";
            this.tlscjd.Size = new System.Drawing.Size(119, 27);
            this.tlscjd.TabIndex = 24;
            this.tlscjd.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "검은돈 신청금액";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "장기 수수료";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "30%";
            // 
            // Plus1
            // 
            this.Plus1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Plus1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Plus1.ForeColor = System.Drawing.Color.Crimson;
            this.Plus1.Location = new System.Drawing.Point(173, 122);
            this.Plus1.Name = "Plus1";
            this.Plus1.Size = new System.Drawing.Size(26, 71);
            this.Plus1.TabIndex = 30;
            this.Plus1.Text = "가져오기";
            this.Plus1.UseVisualStyleBackColor = false;
            this.Plus1.Click += new System.EventHandler(this.button2_Click);
            // 
            // wjrcnf
            // 
            this.wjrcnf.AutoSize = true;
            this.wjrcnf.Location = new System.Drawing.Point(251, 197);
            this.wjrcnf.Name = "wjrcnf";
            this.wjrcnf.Size = new System.Drawing.Size(71, 16);
            this.wjrcnf.TabIndex = 31;
            this.wjrcnf.TabStop = true;
            this.wjrcnf.Text = "적출장기";
            this.wjrcnf.UseVisualStyleBackColor = true;
            this.wjrcnf.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // dlsrhd
            // 
            this.dlsrhd.AutoSize = true;
            this.dlsrhd.Location = new System.Drawing.Point(251, 224);
            this.dlsrhd.Name = "dlsrhd";
            this.dlsrhd.Size = new System.Drawing.Size(71, 16);
            this.dlsrhd.TabIndex = 32;
            this.dlsrhd.TabStop = true;
            this.dlsrhd.Text = "인공장기";
            this.dlsrhd.UseVisualStyleBackColor = true;
            this.dlsrhd.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "브로커";
            // 
            // wkdrl
            // 
            this.wkdrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wkdrl.FormattingEnabled = true;
            this.wkdrl.Items.AddRange(new object[] {
            "소장",
            "안구",
            "쓸개",
            "위"});
            this.wkdrl.Location = new System.Drawing.Point(334, 197);
            this.wkdrl.Name = "wkdrl";
            this.wkdrl.Size = new System.Drawing.Size(98, 20);
            this.wkdrl.TabIndex = 34;
            this.wkdrl.SelectedIndexChanged += new System.EventHandler(this.wkdrl_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "환전 수수료";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(410, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 12);
            this.label13.TabIndex = 36;
            this.label13.Text = "10%";
            // 
            // wkd
            // 
            this.wkd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.wkd.ForeColor = System.Drawing.Color.Indigo;
            this.wkd.Location = new System.Drawing.Point(345, 220);
            this.wkd.Name = "wkd";
            this.wkd.Size = new System.Drawing.Size(66, 32);
            this.wkd.TabIndex = 37;
            this.wkd.Text = "장기";
            this.wkd.UseVisualStyleBackColor = false;
            this.wkd.Click += new System.EventHandler(this.button3_Click);
            // 
            // snwjr
            // 
            this.snwjr.Location = new System.Drawing.Point(376, 272);
            this.snwjr.Name = "snwjr";
            this.snwjr.ReadOnly = true;
            this.snwjr.Size = new System.Drawing.Size(59, 21);
            this.snwjr.TabIndex = 38;
            this.snwjr.Text = "0";
            this.snwjr.TextChanged += new System.EventHandler(this.snwjr_TextChanged);
            // 
            // chdsnwjr
            // 
            this.chdsnwjr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chdsnwjr.Location = new System.Drawing.Point(376, 303);
            this.chdsnwjr.Name = "chdsnwjr";
            this.chdsnwjr.ReadOnly = true;
            this.chdsnwjr.Size = new System.Drawing.Size(59, 21);
            this.chdsnwjr.TabIndex = 39;
            this.chdsnwjr.Text = "0";
            this.chdsnwjr.TextChanged += new System.EventHandler(this.chdsnwjr_TextChanged);
            // 
            // Tmrl
            // 
            this.Tmrl.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Tmrl.ForeColor = System.Drawing.Color.Blue;
            this.Tmrl.Location = new System.Drawing.Point(373, 336);
            this.Tmrl.Name = "Tmrl";
            this.Tmrl.Size = new System.Drawing.Size(66, 32);
            this.Tmrl.TabIndex = 41;
            this.Tmrl.Text = "2. 누적 저장하기";
            this.Tmrl.UseVisualStyleBackColor = false;
            this.Tmrl.Click += new System.EventHandler(this.Tmrl_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(308, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 12);
            this.label14.TabIndex = 42;
            this.label14.Text = "현재 누적";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(301, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 12);
            this.label15.TabIndex = 43;
            this.label15.Text = "현재 총누적";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // rodtls
            // 
            this.rodtls.BackColor = System.Drawing.Color.LightCyan;
            this.rodtls.ForeColor = System.Drawing.Color.MediumBlue;
            this.rodtls.Location = new System.Drawing.Point(305, 434);
            this.rodtls.Name = "rodtls";
            this.rodtls.Size = new System.Drawing.Size(65, 28);
            this.rodtls.TabIndex = 44;
            this.rodtls.Text = "방탄 갱신";
            this.rodtls.UseVisualStyleBackColor = false;
            this.rodtls.Click += new System.EventHandler(this.rodtls_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(373, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 32);
            this.button3.TabIndex = 45;
            this.button3.Text = "  4. 총     누적 값";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(303, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 32);
            this.button4.TabIndex = 46;
            this.button4.Text = "3. 누적 값";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(308, 419);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 12);
            this.label16.TabIndex = 47;
            this.label16.Text = "*1주일에 한번 갱신";
            // 
            // tlwkr
            // 
            this.tlwkr.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tlwkr.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tlwkr.Location = new System.Drawing.Point(341, 549);
            this.tlwkr.Name = "tlwkr";
            this.tlwkr.Size = new System.Drawing.Size(47, 27);
            this.tlwkr.TabIndex = 48;
            this.tlwkr.Text = "접속";
            this.tlwkr.UseVisualStyleBackColor = false;
            this.tlwkr.Click += new System.EventHandler(this.tlwkr_Click);
            // 
            // whdfy
            // 
            this.whdfy.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.whdfy.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.whdfy.Location = new System.Drawing.Point(390, 549);
            this.whdfy.Name = "whdfy";
            this.whdfy.Size = new System.Drawing.Size(47, 27);
            this.whdfy.TabIndex = 49;
            this.whdfy.Text = "종료";
            this.whdfy.UseVisualStyleBackColor = false;
            this.whdfy.Click += new System.EventHandler(this.whdfy_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 533);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 50;
            this.label17.Text = "시작시간 : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 556);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 51;
            this.label18.Text = "종료시간 : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(75, 533);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 12);
            this.label19.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(75, 556);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 12);
            this.label20.TabIndex = 53;
            // 
            // tlwkr1
            // 
            this.tlwkr1.Location = new System.Drawing.Point(77, 530);
            this.tlwkr1.Name = "tlwkr1";
            this.tlwkr1.ReadOnly = true;
            this.tlwkr1.Size = new System.Drawing.Size(109, 21);
            this.tlwkr1.TabIndex = 54;
            this.tlwkr1.TextChanged += new System.EventHandler(this.tlwkr1_TextChanged);
            // 
            // whdfy1
            // 
            this.whdfy1.Location = new System.Drawing.Point(77, 553);
            this.whdfy1.Name = "whdfy1";
            this.whdfy1.ReadOnly = true;
            this.whdfy1.Size = new System.Drawing.Size(109, 21);
            this.whdfy1.TabIndex = 55;
            this.whdfy1.TextChanged += new System.EventHandler(this.whdfy1_TextChanged);
            // 
            // snwjrtlrks
            // 
            this.snwjrtlrks.Location = new System.Drawing.Point(295, 530);
            this.snwjrtlrks.Name = "snwjrtlrks";
            this.snwjrtlrks.Size = new System.Drawing.Size(44, 21);
            this.snwjrtlrks.TabIndex = 56;
            this.snwjrtlrks.TextChanged += new System.EventHandler(this.snwjrtlrks_TextChanged);
            // 
            // snwjrqns
            // 
            this.snwjrqns.Location = new System.Drawing.Point(295, 553);
            this.snwjrqns.Name = "snwjrqns";
            this.snwjrqns.Size = new System.Drawing.Size(44, 21);
            this.snwjrqns.TabIndex = 57;
            this.snwjrqns.TextChanged += new System.EventHandler(this.snwjrqns_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(208, 533);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 12);
            this.label21.TabIndex = 58;
            this.label21.Text = "총 누적시간 : ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(216, 556);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 12);
            this.label22.TabIndex = 59;
            this.label22.Text = "총 누적 분 : ";
            // 
            // qlghkf
            // 
            this.qlghkf.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.qlghkf.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.qlghkf.Location = new System.Drawing.Point(348, 521);
            this.qlghkf.Name = "qlghkf";
            this.qlghkf.Size = new System.Drawing.Size(84, 24);
            this.qlghkf.TabIndex = 60;
            this.qlghkf.Text = "가져오기";
            this.qlghkf.UseVisualStyleBackColor = false;
            this.qlghkf.Click += new System.EventHandler(this.qlghkf_Click);
            // 
            // fltpt
            // 
            this.fltpt.BackColor = System.Drawing.Color.LightCyan;
            this.fltpt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.fltpt.Location = new System.Drawing.Point(373, 434);
            this.fltpt.Name = "fltpt";
            this.fltpt.Size = new System.Drawing.Size(64, 28);
            this.fltpt.TabIndex = 61;
            this.fltpt.Text = "시간갱신";
            this.fltpt.UseVisualStyleBackColor = false;
            this.fltpt.Click += new System.EventHandler(this.fltpt_Click);
            // 
            // tjfaud
            // 
            this.tjfaud.AutoSize = true;
            this.tjfaud.Location = new System.Drawing.Point(22, 251);
            this.tjfaud.Name = "tjfaud";
            this.tjfaud.Size = new System.Drawing.Size(317, 12);
            this.tjfaud.TabIndex = 62;
            this.tjfaud.Text = "* 방탄 총 누적값 설정 후 사용할 땐 3 -> 4 -> 1 -> 2 순서";
            // 
            // 설명
            // 
            this.설명.AutoSize = true;
            this.설명.ForeColor = System.Drawing.Color.Maroon;
            this.설명.Location = new System.Drawing.Point(4, 9);
            this.설명.Name = "설명";
            this.설명.Size = new System.Drawing.Size(295, 12);
            this.설명.TabIndex = 63;
            this.설명.Text = "*맨 처음 사용시 방탄과 시간모두 갱신 후 사용하세요.";
            // 
            // 골드문
            // 
            this.골드문.AutoSize = true;
            this.골드문.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.골드문.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.골드문.ForeColor = System.Drawing.Color.Goldenrod;
            this.골드문.Image = ((System.Drawing.Image)(resources.GetObject("골드문.Image")));
            this.골드문.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.골드문.Location = new System.Drawing.Point(47, 40);
            this.골드문.Name = "골드문";
            this.골드문.Size = new System.Drawing.Size(275, 30);
            this.골드문.TabIndex = 64;
            this.골드문.Text = "   골드문 종합 판매 계산기";
            // 
            // chrlghk
            // 
            this.chrlghk.BackColor = System.Drawing.Color.Red;
            this.chrlghk.Cursor = System.Windows.Forms.Cursors.Default;
            this.chrlghk.ForeColor = System.Drawing.Color.Crimson;
            this.chrlghk.Location = new System.Drawing.Point(12, 40);
            this.chrlghk.Name = "chrlghk";
            this.chrlghk.Size = new System.Drawing.Size(24, 32);
            this.chrlghk.TabIndex = 65;
            this.chrlghk.UseVisualStyleBackColor = false;
            this.chrlghk.Click += new System.EventHandler(this.chrlghk_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.ForeColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(14, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 24);
            this.button5.TabIndex = 66;
            this.button5.Text = "판매목록";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // vksao1
            // 
            this.vksao1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.vksao1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.vksao1.Location = new System.Drawing.Point(189, 489);
            this.vksao1.Name = "vksao1";
            this.vksao1.Size = new System.Drawing.Size(47, 27);
            this.vksao1.TabIndex = 67;
            this.vksao1.Text = "판매";
            this.vksao1.UseVisualStyleBackColor = false;
            this.vksao1.Click += new System.EventHandler(this.vksao1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(378, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 24);
            this.button2.TabIndex = 68;
            this.button2.Text = "설명서";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // qkdxks
            // 
            this.qkdxks.Location = new System.Drawing.Point(16, 122);
            this.qkdxks.Multiline = true;
            this.qkdxks.Name = "qkdxks";
            this.qkdxks.Size = new System.Drawing.Size(151, 71);
            this.qkdxks.TabIndex = 69;
            this.qkdxks.TextChanged += new System.EventHandler(this.qkdxks_TextChanged);
            // 
            // Plus2
            // 
            this.Plus2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Plus2.ForeColor = System.Drawing.Color.Crimson;
            this.Plus2.Location = new System.Drawing.Point(355, 147);
            this.Plus2.Name = "Plus2";
            this.Plus2.Size = new System.Drawing.Size(37, 27);
            this.Plus2.TabIndex = 70;
            this.Plus2.Text = "저장";
            this.Plus2.UseVisualStyleBackColor = false;
            this.Plus2.Click += new System.EventHandler(this.button6_Click);
            // 
            // tnwjd1
            // 
            this.tnwjd1.Location = new System.Drawing.Point(252, 122);
            this.tnwjd1.Name = "tnwjd1";
            this.tnwjd1.Size = new System.Drawing.Size(97, 21);
            this.tnwjd1.TabIndex = 71;
            this.tnwjd1.TextChanged += new System.EventHandler(this.tnwjd1_TextChanged);
            // 
            // tnwjd2
            // 
            this.tnwjd2.Location = new System.Drawing.Point(251, 151);
            this.tnwjd2.Name = "tnwjd2";
            this.tnwjd2.Size = new System.Drawing.Size(97, 21);
            this.tnwjd2.TabIndex = 72;
            this.tnwjd2.TextChanged += new System.EventHandler(this.tnwjd2_TextChanged);
            // 
            // tjsxor
            // 
            this.tjsxor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tjsxor.FormattingEnabled = true;
            this.tjsxor.Items.AddRange(new object[] {
            "금액 수정",
            "구간1 수정",
            "구간2 수정"});
            this.tjsxor.Location = new System.Drawing.Point(273, 92);
            this.tjsxor.Name = "tjsxor";
            this.tjsxor.Size = new System.Drawing.Size(75, 20);
            this.tjsxor.TabIndex = 73;
            this.tjsxor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // 골드문방탄계산기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(444, 586);
            this.Controls.Add(this.tjsxor);
            this.Controls.Add(this.tnwjd2);
            this.Controls.Add(this.tnwjd1);
            this.Controls.Add(this.Plus2);
            this.Controls.Add(this.qkdxks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vksao1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chrlghk);
            this.Controls.Add(this.골드문);
            this.Controls.Add(this.설명);
            this.Controls.Add(this.tjfaud);
            this.Controls.Add(this.fltpt);
            this.Controls.Add(this.qlghkf);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.snwjrqns);
            this.Controls.Add(this.snwjrtlrks);
            this.Controls.Add(this.whdfy1);
            this.Controls.Add(this.tlwkr1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.whdfy);
            this.Controls.Add(this.tlwkr);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rodtls);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Tmrl);
            this.Controls.Add(this.chdsnwjr);
            this.Controls.Add(this.snwjr);
            this.Controls.Add(this.wkd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.wkdrl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dlsrhd);
            this.Controls.Add(this.wjrcnf);
            this.Controls.Add(this.Plus1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tlscjd);
            this.Controls.Add(this.blout);
            this.Controls.Add(this.body);
            this.Controls.Add(this.tlsgh);
            this.Controls.Add(this.ghkswjs);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.blink1);
            this.Controls.Add(this.job);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "골드문방탄계산기";
            this.Text = "골드문방탄계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox job;
        private System.Windows.Forms.TextBox blink1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button ghkswjs;
        private System.Windows.Forms.Button tlsgh;
        private System.Windows.Forms.RadioButton body;
        private System.Windows.Forms.RadioButton blout;
        private System.Windows.Forms.TextBox tlscjd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Plus1;
        private System.Windows.Forms.RadioButton wjrcnf;
        private System.Windows.Forms.RadioButton dlsrhd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox wkdrl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button wkd;
        private System.Windows.Forms.TextBox snwjr;
        private System.Windows.Forms.TextBox chdsnwjr;
        private System.Windows.Forms.Button Tmrl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button rodtls;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button tlwkr;
        private System.Windows.Forms.Button whdfy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tlwkr1;
        private System.Windows.Forms.TextBox whdfy1;
        private System.Windows.Forms.TextBox snwjrtlrks;
        private System.Windows.Forms.TextBox snwjrqns;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button qlghkf;
        private System.Windows.Forms.Button fltpt;
        private System.Windows.Forms.Label tjfaud;
        private System.Windows.Forms.Label 설명;
        private System.Windows.Forms.Label 골드문;
        private System.Windows.Forms.Button chrlghk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button vksao1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox qkdxks;
        private System.Windows.Forms.Button Plus2;
        private System.Windows.Forms.TextBox tnwjd1;
        private System.Windows.Forms.TextBox tnwjd2;
        private System.Windows.Forms.ComboBox tjsxor;
    }
}

