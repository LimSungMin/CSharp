﻿namespace 설문조사
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
            this.plQuestion = new System.Windows.Forms.Panel();
            this.plResult = new System.Windows.Forms.Panel();
            this.gbHobby = new System.Windows.Forms.GroupBox();
            this.gbSports = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbtn01 = new System.Windows.Forms.RadioButton();
            this.rbtn02 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblHobby = new System.Windows.Forms.Label();
            this.lblSports = new System.Windows.Forms.Label();
            this.plQuestion.SuspendLayout();
            this.plResult.SuspendLayout();
            this.gbHobby.SuspendLayout();
            this.gbSports.SuspendLayout();
            this.SuspendLayout();
            // 
            // plQuestion
            // 
            this.plQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plQuestion.Controls.Add(this.btnSubmit);
            this.plQuestion.Controls.Add(this.gbSports);
            this.plQuestion.Controls.Add(this.gbHobby);
            this.plQuestion.Location = new System.Drawing.Point(12, 12);
            this.plQuestion.Name = "plQuestion";
            this.plQuestion.Size = new System.Drawing.Size(260, 156);
            this.plQuestion.TabIndex = 0;
            // 
            // plResult
            // 
            this.plResult.BackColor = System.Drawing.SystemColors.Info;
            this.plResult.Controls.Add(this.lblSports);
            this.plResult.Controls.Add(this.lblHobby);
            this.plResult.Location = new System.Drawing.Point(12, 174);
            this.plResult.Name = "plResult";
            this.plResult.Size = new System.Drawing.Size(260, 155);
            this.plResult.TabIndex = 1;
            // 
            // gbHobby
            // 
            this.gbHobby.Controls.Add(this.rbtn02);
            this.gbHobby.Controls.Add(this.rbtn01);
            this.gbHobby.Location = new System.Drawing.Point(3, 3);
            this.gbHobby.Name = "gbHobby";
            this.gbHobby.Size = new System.Drawing.Size(254, 55);
            this.gbHobby.TabIndex = 0;
            this.gbHobby.TabStop = false;
            this.gbHobby.Text = "취미는?";
            // 
            // gbSports
            // 
            this.gbSports.Controls.Add(this.checkBox2);
            this.gbSports.Controls.Add(this.checkBox1);
            this.gbSports.Location = new System.Drawing.Point(3, 64);
            this.gbSports.Name = "gbSports";
            this.gbSports.Size = new System.Drawing.Size(254, 55);
            this.gbSports.TabIndex = 1;
            this.gbSports.TabStop = false;
            this.gbSports.Text = "좋아하는 스포츠?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(147, 125);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "제출하기";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbtn01
            // 
            this.rbtn01.AutoSize = true;
            this.rbtn01.Location = new System.Drawing.Point(26, 20);
            this.rbtn01.Name = "rbtn01";
            this.rbtn01.Size = new System.Drawing.Size(71, 16);
            this.rbtn01.TabIndex = 0;
            this.rbtn01.TabStop = true;
            this.rbtn01.Text = "독서하기";
            this.rbtn01.UseVisualStyleBackColor = true;
            // 
            // rbtn02
            // 
            this.rbtn02.AutoSize = true;
            this.rbtn02.Location = new System.Drawing.Point(144, 20);
            this.rbtn02.Name = "rbtn02";
            this.rbtn02.Size = new System.Drawing.Size(71, 16);
            this.rbtn02.TabIndex = 1;
            this.rbtn02.TabStop = true;
            this.rbtn02.Text = "영화보기";
            this.rbtn02.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "축구";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(144, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "농구";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(27, 34);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(53, 12);
            this.lblHobby.TabIndex = 0;
            this.lblHobby.Text = "취미는 : ";
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Location = new System.Drawing.Point(27, 92);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(65, 12);
            this.lblSports.TabIndex = 1;
            this.lblSports.Text = "스포츠는 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.plResult);
            this.Controls.Add(this.plQuestion);
            this.Name = "Form1";
            this.Text = "설문조사";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plQuestion.ResumeLayout(false);
            this.plResult.ResumeLayout(false);
            this.plResult.PerformLayout();
            this.gbHobby.ResumeLayout(false);
            this.gbHobby.PerformLayout();
            this.gbSports.ResumeLayout(false);
            this.gbSports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plQuestion;
        private System.Windows.Forms.Panel plResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbSports;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbHobby;
        private System.Windows.Forms.RadioButton rbtn02;
        private System.Windows.Forms.RadioButton rbtn01;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.Label lblHobby;
    }
}

