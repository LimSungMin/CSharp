using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 트레이_아이콘
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 다음의 VisibleChange() 메서드는 메서드로 Boolean 타입의 인자를 받아
         * 폼의 Visible 속성과 nyiTray 컨트톹의 Visible 속성 값을 설정하는 역할을 한다
         */
        private void VisibleChange(Boolean FormVisible, Boolean TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nyiTray.Visible = TrayIconVisible;
        }
        /* 다음의 이벤트 핸들러는 폼을 선택하고 이벤트 창에서 FormClosing을 더블 클릭하여
         * 생선한 핸들러로 폼이 종료될 때 발생하는 이벤트를 처리하는 메서드로 e.Cancle 값을
         * true 로 설정하여 폼의 종료를 취소한다. 
         */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;            // 폼의 종료를 취소
            VisibleChange(false, true); // 폼과 트레이 아이콘의 Visible 설정
        }

        private void nyiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, false);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
