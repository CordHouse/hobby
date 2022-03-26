
namespace test1
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
            this.qjxms = new System.Windows.Forms.Button();
            this.tlwkr = new System.Windows.Forms.TextBox();
            this.whdfy = new System.Windows.Forms.TextBox();
            this.rufrhk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // qjxms
            // 
            this.qjxms.BackColor = System.Drawing.Color.MediumPurple;
            this.qjxms.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.qjxms.Location = new System.Drawing.Point(558, 133);
            this.qjxms.Name = "qjxms";
            this.qjxms.Size = new System.Drawing.Size(92, 45);
            this.qjxms.TabIndex = 0;
            this.qjxms.Text = "예 상";
            this.qjxms.UseVisualStyleBackColor = false;
            this.qjxms.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlwkr
            // 
            this.tlwkr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tlwkr.Enabled = false;
            this.tlwkr.Location = new System.Drawing.Point(558, 51);
            this.tlwkr.Name = "tlwkr";
            this.tlwkr.Size = new System.Drawing.Size(92, 21);
            this.tlwkr.TabIndex = 1;
            // 
            // whdfy
            // 
            this.whdfy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.whdfy.Enabled = false;
            this.whdfy.Location = new System.Drawing.Point(558, 78);
            this.whdfy.Name = "whdfy";
            this.whdfy.Size = new System.Drawing.Size(92, 21);
            this.whdfy.TabIndex = 1;
            // 
            // rufrhk
            // 
            this.rufrhk.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rufrhk.Enabled = false;
            this.rufrhk.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rufrhk.Location = new System.Drawing.Point(12, 12);
            this.rufrhk.Multiline = true;
            this.rufrhk.Name = "rufrhk";
            this.rufrhk.Size = new System.Drawing.Size(529, 211);
            this.rufrhk.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 235);
            this.Controls.Add(this.rufrhk);
            this.Controls.Add(this.whdfy);
            this.Controls.Add(this.tlwkr);
            this.Controls.Add(this.qjxms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "카지노";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qjxms;
        private System.Windows.Forms.TextBox tlwkr;
        private System.Windows.Forms.TextBox whdfy;
        private System.Windows.Forms.TextBox rufrhk;
    }
}

