using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace 헤더정렬
{
    public partial class Form1 : Form
    {
        private bool Isort = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ControlCheck())
            {
                var strArray = new String[] { this.txtName.Text, this.txtPhoneNumber.Text };
                var lvt = new ListViewItem(strArray);
                this.lvCall.Items.Add(lvt);
                this.txtName.Clear();
                this.txtPhoneNumber.Clear();
            }
            else
            {
                return;
            }
        }

        private Boolean ControlCheck()
        {
            if (this.txtName.Text == "" || this.txtPhoneNumber.Text == "")
            {
                MessageBox.Show("이름 혹은 전화번호가 잘못 입력됐습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lvCall_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (Isort == true)
            {
                this.lvCall.ListViewItemSorter = new ListViewItemComparer(e.Column, Isort);
                Isort = false;
            }
            else
            {
                this.lvCall.ListViewItemSorter = new ListViewItemComparer(e.Column, Isort);
                Isort = true;
            }
        }
    }
    class ListViewItemComparer : IComparer      // 두 객체를 비교하는 Compare 메서드를 사용하기 위해 ICompare 상속
    {
        private int col;
        private bool z;
        public ListViewItemComparer(int col, bool z)
        {
            this.col = col;
            this.z = z;
        }
        public int Compare(object x, object y)
        {
            object a, b;
            if (z == true)
            {
                a = x;
                b = y;
            }
            else
            {
                a = y;
                b = x;
            }
            return String.Compare(((ListViewItem)a).SubItems[col].Text, ((ListViewItem)b).SubItems[col].Text);
        }
    }
}
