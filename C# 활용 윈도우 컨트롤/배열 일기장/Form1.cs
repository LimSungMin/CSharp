using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace 배열_일기장
{
    public partial class Form1 : Form
    {
        string[] i = new string[366];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var datTim1 = Convert.ToDateTime("#1/1/2014#"); // 2014년 1월 1일을 초기 날짜로 지정
            DateTime datTim2 = this.dtpTime.Value;
            int wD = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Day, datTim1, datTim2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));    // 날짜 차이 저장
            i[wD] = this.txtMemo.Text;
            if (i[wD].Length > 0)
            {
                MessageBox.Show("일기가 정상적으로 저장되었습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMemo.Clear();
            }
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime datTim1 = Convert.ToDateTime("#1/1/2014#");
            DateTime datTim2 = this.dtpTime.Value;
            int wD = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Day, datTim1, datTim2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));    // 날짜 차이 저장
            this.txtMemo.Text = i[wD];
        }
    }
}
