using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 구구단_계산기
{
    public partial class 구구단폼 : Form
    {
        public 구구단폼()
        {
            InitializeComponent();
        }

        // 선택된 구구단에 따라 lbResult 리스트박스 수정
        private void cbbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbResult.Items.Clear();

            var s = this.cbbSelect.SelectedItem.ToString();
            // var gustr = s.Split(new char[]{' '});
            this.lbResult.Items.Add(s + " 실행결과");
            for (int i = 1; i < 10; i++)
            {
                this.lbResult.Items.Add(s[0] + " * " + i + " = " +(s[0]-'0') * i);  // 아스키코드 값에 값을 곱해주면 큰 값이 나오므로, '0'을 빼줘야함
            }
        }

        private void 구구단폼_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
                this.cbbSelect.Items.Add(i + " 단");
        }
    }
}
