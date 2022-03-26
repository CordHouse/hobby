
namespace 학교
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Khaki;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt1.Location = new System.Drawing.Point(36, 97);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(133, 55);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1학년";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.LightGreen;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt2.Location = new System.Drawing.Point(224, 97);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(133, 55);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "2학년";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Cyan;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt3.Location = new System.Drawing.Point(36, 183);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(133, 55);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3학년";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt4.Location = new System.Drawing.Point(224, 183);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(133, 55);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "4학년";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "정보통신공학과 기록지";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(395, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "정보통신공학과 기록지";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Label label1;
    }
}

