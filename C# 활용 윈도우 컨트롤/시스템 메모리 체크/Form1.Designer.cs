namespace 시스템_메모리_체크
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plBar = new System.Windows.Forms.Panel();
            this.plBar2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // plBar
            // 
            this.plBar.BackColor = System.Drawing.Color.White;
            this.plBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plBar.Location = new System.Drawing.Point(12, 12);
            this.plBar.Name = "plBar";
            this.plBar.Size = new System.Drawing.Size(361, 32);
            this.plBar.TabIndex = 0;
            this.plBar.Paint += new System.Windows.Forms.PaintEventHandler(this.plBar_Paint);
            // 
            // plBar2
            // 
            this.plBar2.BackColor = System.Drawing.Color.White;
            this.plBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plBar2.Location = new System.Drawing.Point(12, 50);
            this.plBar2.Name = "plBar2";
            this.plBar2.Size = new System.Drawing.Size(361, 32);
            this.plBar2.TabIndex = 1;
            this.plBar2.Paint += new System.Windows.Forms.PaintEventHandler(this.plBar2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 95);
            this.Controls.Add(this.plBar2);
            this.Controls.Add(this.plBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메모리 체크";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBar;
        private System.Windows.Forms.Panel plBar2;
    }
}

