namespace 구구단_계산기
{
    partial class 구구단폼
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbbSelect = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(12, 28);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(29, 12);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "선택";
            // 
            // cbbSelect
            // 
            this.cbbSelect.FormattingEnabled = true;
            this.cbbSelect.ItemHeight = 12;
            this.cbbSelect.Location = new System.Drawing.Point(56, 25);
            this.cbbSelect.Name = "cbbSelect";
            this.cbbSelect.Size = new System.Drawing.Size(216, 20);
            this.cbbSelect.TabIndex = 1;
            this.cbbSelect.SelectedIndexChanged += new System.EventHandler(this.cbbSelect_SelectedIndexChanged);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(14, 70);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(258, 280);
            this.lbResult.TabIndex = 2;
            // 
            // 구구단폼
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbbSelect);
            this.Controls.Add(this.lblSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "구구단폼";
            this.Text = "구구단";
            this.Load += new System.EventHandler(this.구구단폼_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbbSelect;
        private System.Windows.Forms.ListBox lbResult;
    }
}

