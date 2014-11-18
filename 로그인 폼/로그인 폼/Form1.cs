using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 로그인_폼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                this.lblResult.Text = "로그인 성공!";
            }
        }

        private bool CheckData()
        {
            if (this.txtId.Text == "")
            {
                MessageBox.Show("로그인 아이디를 입력하세요.", "알림", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                this.txtId.Focus(); // 데이터 입력을 다시 요청하기 위하여 커서 포커스를 옮겨줌
                return false;
            }
            else if (this.txtPwd.Text == "")
            {
                MessageBox.Show("로그인 아이디를 입력하세요.", "알림", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                this.txtPwd.Focus(); 
                return false;
            }
            else
            {
                if (this.txtId.Text == "test" && this.txtPwd.Text == "1234")
                {
                    return true;
                }
                else
                {
                    this.lblResult.Text = "아이디 혹은 비밀번호가 틀렸습니다.";
                    this.txtId.Focus();
                    return false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // txtPwd 컨트롤에 커서가 위치 하면서 
        // 키보드 입력이 있을 때 발생하는 이벤트를 처리하는 핸들러
        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) // 키보드 입력값이 엔터일때 다음 행을 실행
            {
                if (CheckData() == true)
                {
                    this.lblResult.Text = "로그인 성공!";
                }
            }
        }
        
    }
}
