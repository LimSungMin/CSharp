using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using playsound;

namespace wav파일_재생기
{
    public partial class Form1 : Form
    {
        private Thread SoundPlayThread;
        private string FilePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        // [열기]버튼을 클릭하였을 때 발생하는 이벤트 처리
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtOpen.Text = this.ofdFile.FileName;
                this.FilePath = this.ofdFile.FileName;
                SoundPlayThread = new Thread(SoundPlayGo);
                SoundPlayThread.Start();
            }
        }

        // 외부 스레드에서 실행될 메서드로 DLL 클래스 라이브러리의 PlaySoundStart 메서드를 호출하는 작업을 수행한다.
        private void SoundPlayGo()
        {
            PlaySoundGo.PlaySoundStart(FilePath, new System.IntPtr(), PlaySoundGo.PlaySoundFlags.SND_SYNC);
            SoundPlayThread.Abort();
        }
    }
}
