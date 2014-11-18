namespace 트레이_아이콘
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nyiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기 = new System.Windows.Forms.ToolStripMenuItem();
            this.종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // nyiTray
            // 
            this.nyiTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nyiTray.Icon")));
            this.nyiTray.Text = "notifyIcon1";
            this.nyiTray.Visible = true;
            this.nyiTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nyiTray_MouseDoubleClick);
            // 
            // cmsPopup
            // 
            this.cmsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기,
            this.toolStripSeparator1,
            this.종료});
            this.cmsPopup.Name = "cmsPopup";
            this.cmsPopup.Size = new System.Drawing.Size(153, 76);
            // 
            // 열기
            // 
            this.열기.Name = "열기";
            this.열기.Size = new System.Drawing.Size(152, 22);
            this.열기.Text = "열 기";
            this.열기.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 종료
            // 
            this.종료.Name = "종료";
            this.종료.Size = new System.Drawing.Size(152, 22);
            this.종료.Text = "종 료";
            this.종료.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Text = "트레이 아이콘";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.cmsPopup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nyiTray;
        private System.Windows.Forms.ContextMenuStrip cmsPopup;
        private System.Windows.Forms.ToolStripMenuItem 열기;
        private System.Windows.Forms.ToolStripMenuItem 종료;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

