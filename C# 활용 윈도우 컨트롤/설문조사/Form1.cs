using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 설문조사
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 제출하기 버튼 눌렀을때 이벤트
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked != false || this.checkBox2.Checked != false)
            {
                foreach (RadioButton c in this.gbHobby.Controls)
                {
                    if (c.Checked == true)
                        this.lblHobby.Text = c.Text;
                }
                this.lblSports.Text = "";
                foreach (CheckBox c in this.gbSports.Controls)
                {
                    if (c.Checked == true)
                        this.lblSports.Text += c.Text+" ";
                }
            }
        }
    }
}
