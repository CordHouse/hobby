
namespace helper
{
    partial class PCA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t8 = new System.Windows.Forms.TextBox();
            this.t9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fkaek = new System.Windows.Forms.TextBox();
            this.rmsrhdtlr = new System.Windows.Forms.TextBox();
            this.qprxj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(23, 36);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(89, 21);
            this.t1.TabIndex = 0;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(118, 36);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(89, 21);
            this.t2.TabIndex = 1;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(23, 63);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(89, 21);
            this.t3.TabIndex = 2;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(118, 63);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(89, 21);
            this.t4.TabIndex = 3;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(23, 231);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(71, 21);
            this.t5.TabIndex = 4;
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(136, 231);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(71, 21);
            this.t6.TabIndex = 5;
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(241, 231);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(71, 21);
            this.t7.TabIndex = 6;
            this.t7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(23, 405);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(71, 21);
            this.t8.TabIndex = 7;
            this.t8.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // t9
            // 
            this.t9.Location = new System.Drawing.Point(118, 405);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(71, 21);
            this.t9.TabIndex = 8;
            this.t9.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "λ 구하기 (공분산 넣기)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "근의 공식 사용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "λ^2 +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "λ +";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "λ1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "λ2";
            // 
            // fkaek
            // 
            this.fkaek.Location = new System.Drawing.Point(351, 12);
            this.fkaek.Multiline = true;
            this.fkaek.Name = "fkaek";
            this.fkaek.Size = new System.Drawing.Size(335, 147);
            this.fkaek.TabIndex = 10;
            // 
            // rmsrhdtlr
            // 
            this.rmsrhdtlr.Location = new System.Drawing.Point(351, 165);
            this.rmsrhdtlr.Multiline = true;
            this.rmsrhdtlr.Name = "rmsrhdtlr";
            this.rmsrhdtlr.Size = new System.Drawing.Size(335, 147);
            this.rmsrhdtlr.TabIndex = 11;
            // 
            // qprxj
            // 
            this.qprxj.Location = new System.Drawing.Point(351, 318);
            this.qprxj.Multiline = true;
            this.qprxj.Name = "qprxj";
            this.qprxj.Size = new System.Drawing.Size(335, 147);
            this.qprxj.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(23, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightYellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(23, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "계산";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightYellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(23, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "계산";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(274, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 33);
            this.button4.TabIndex = 16;
            this.button4.Text = "초기화";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(707, 481);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qprxj);
            this.Controls.Add(this.rmsrhdtlr);
            this.Controls.Add(this.fkaek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Name = "PCA";
            this.Text = "PCA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.TextBox t9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fkaek;
        private System.Windows.Forms.TextBox rmsrhdtlr;
        private System.Windows.Forms.TextBox qprxj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}