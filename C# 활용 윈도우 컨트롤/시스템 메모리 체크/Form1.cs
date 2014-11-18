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
using System.Diagnostics;

namespace 시스템_메모리_체크
{
    public partial class Form1 : Form
    {
        private PerformanceCounter oCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter oRAM = new PerformanceCounter("Memory", "Available MBytes");
        private bool bExit = false;

        private int iCPU = 0;
        private int iRAM = 0;

        private Font F = new Font("굴림", 9);
        private Thread checkThread;

        public Form1()
        {
            InitializeComponent();
        }

        // 폼이 로드될 때 발생하는 이벤트 처리
        private void Form1_Load(object sender, EventArgs e)
        {
            checkThread = new Thread(get_Info);
            checkThread.Start();
        }
        private void get_Info()
        {
            while (!bExit)
            {
                iCPU = (int)oCPU.NextValue();
                iRAM = (int)oRAM.NextValue();
                
                plBar.Invalidate();
                plBar2.Invalidate();

                Thread.Sleep(1000);
            }
        }
        // plBar 컨트롤을 다시 그릴 때 발생하는 이벤트 처리
        private void plBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            if (iCPU <= 60)
                G.FillRectangle(Brushes.BlanchedAlmond, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 120)
                G.FillRectangle(Brushes.Wheat, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 180)
                G.FillRectangle(Brushes.NavajoWhite, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 240)
                G.FillRectangle(Brushes.Orange, 0, 0, iCPU, plBar.Height);
            else
                G.FillRectangle(Brushes.DarkOrange, 0, 0, iCPU, plBar.Height);
            
            G.DrawString("CPU 사용량 : "+iCPU.ToString() + " %", F, Brushes.DarkRed, plBar.Width / 2 - 17, plBar.Height / 4);
        }

        // 폼이 종료될 때 발생하는 이벤트 처리
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkThread.Abort();
        }

        private void plBar2_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            if (iRAM <= 60)
                G.FillRectangle(Brushes.BlanchedAlmond, 0, 0, iRAM, plBar.Height);
            else if (iRAM <= 120)
                G.FillRectangle(Brushes.Wheat, 0, 0, iRAM, plBar.Height);
            else if (iRAM <= 180)
                G.FillRectangle(Brushes.NavajoWhite, 0, 0, iRAM, plBar.Height);
            else if (iRAM <= 240)
                G.FillRectangle(Brushes.Orange, 0, 0, iRAM, plBar.Height);
            else
                G.FillRectangle(Brushes.DarkOrange, 0, 0, iRAM, plBar.Height);
            
            G.DrawString("RAM 사용가능 : " + iRAM.ToString() + " MB", F, Brushes.DarkRed, plBar.Width / 2 - 17, plBar.Height / 4);
        }
    }
}
