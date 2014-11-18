namespace 헤더정렬
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
            this.lvCall = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbName = new System.Windows.Forms.Label();
            this.lvPhoneNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCall
            // 
            this.lvCall.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPhoneNumber});
            this.lvCall.FullRowSelect = true;
            this.lvCall.GridLines = true;
            this.lvCall.Location = new System.Drawing.Point(12, 12);
            this.lvCall.Name = "lvCall";
            this.lvCall.Size = new System.Drawing.Size(260, 165);
            this.lvCall.TabIndex = 0;
            this.lvCall.UseCompatibleStateImageBehavior = false;
            this.lvCall.View = System.Windows.Forms.View.Details;
            this.lvCall.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvCall_ColumnClick);
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 82;
            // 
            // chPhoneNumber
            // 
            this.chPhoneNumber.Text = "전화번호";
            this.chPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPhoneNumber.Width = 167;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(10, 191);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "이름";
            // 
            // lvPhoneNumber
            // 
            this.lvPhoneNumber.AutoSize = true;
            this.lvPhoneNumber.Location = new System.Drawing.Point(10, 223);
            this.lvPhoneNumber.Name = "lvPhoneNumber";
            this.lvPhoneNumber.Size = new System.Drawing.Size(53, 12);
            this.lvPhoneNumber.TabIndex = 2;
            this.lvPhoneNumber.Text = "전화번호";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 183);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(72, 220);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 189);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 52);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "입 력";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lvPhoneNumber);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lvCall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "헤더 정렬";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCall;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lvPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPhoneNumber;
    }
}

