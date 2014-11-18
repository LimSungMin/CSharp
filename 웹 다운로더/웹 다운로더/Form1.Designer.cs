namespace 웹_다운로더
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
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.cbOpen = new System.Windows.Forms.CheckBox();
            this.pgbDownload = new System.Windows.Forms.ProgressBar();
            this.fbdFile = new System.Windows.Forms.FolderBrowserDialog();
            this.webClient = new System.Net.WebClient();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(25, 23);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 12);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "주소";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(60, 20);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(379, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(454, 20);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "다운로드";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(535, 20);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 3;
            this.btnFolder.Text = "폴 더";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // cbOpen
            // 
            this.cbOpen.AutoSize = true;
            this.cbOpen.Location = new System.Drawing.Point(616, 23);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(64, 16);
            this.cbOpen.TabIndex = 4;
            this.cbOpen.Text = "창 열기";
            this.cbOpen.UseVisualStyleBackColor = true;
            // 
            // pgbDownload
            // 
            this.pgbDownload.Location = new System.Drawing.Point(27, 47);
            this.pgbDownload.Name = "pgbDownload";
            this.pgbDownload.Size = new System.Drawing.Size(653, 23);
            this.pgbDownload.TabIndex = 5;
            // 
            // webClient
            // 
            //this.webClient.AllowReadStreamBuffering = false;
            //this.webClient.AllowWriteStreamBuffering = false;
            this.webClient.BaseAddress = "";
            this.webClient.CachePolicy = null;
            this.webClient.Credentials = null;
            this.webClient.Encoding = ((System.Text.Encoding)(resources.GetObject("webClient.Encoding")));
            this.webClient.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("webClient.Headers")));
            this.webClient.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("webClient.QueryString")));
            this.webClient.UseDefaultCredentials = false;
            this.webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.webClient_DownloadFileCompleted);
            this.webClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(this.webClient_DownloadProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 88);
            this.Controls.Add(this.pgbDownload);
            this.Controls.Add(this.cbOpen);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "웹 다운로드";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.CheckBox cbOpen;
        private System.Windows.Forms.ProgressBar pgbDownload;
        private System.Windows.Forms.FolderBrowserDialog fbdFile;
        private System.Net.WebClient webClient;
    }
}

