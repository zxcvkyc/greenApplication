using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 暴力摩托2002花屏补丁
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_startGame_Click(object sender, EventArgs e)
        {
            try
            {
                RunPro("Roadrash");
                if (IsContainsProcess("explorer"))
                {
                    KillProcess("explorer");
                }
            }
            catch
            {
                MessageBox.Show("请把本补丁放在游戏目录中运行");
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            CloseGame();
        }
        /// <summary>
        /// 运行exe
        /// </summary>
        /// <param name="exeName">绝对路径或相对路径</param>
        public void RunPro(string exeName)
        {
            Process process = new Process();
            process.StartInfo.FileName = exeName;
            process.Start();
        }
        /// <summary>
        /// 判断是否存在指定的进程
        /// </summary>
        /// <param name="processName">要判断的进程名称</param>
        /// <returns>是否存在的结果</returns>
        public bool IsContainsProcess(string processName)
        {
            Process[] prolist = Process.GetProcessesByName(processName);
            foreach (var item in prolist)
            {
                if (item.ProcessName.Equals(processName))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 调用任务管理器结束进程
        /// </summary>
        /// <param name="pricessName">要结束的进程名</param>
        public void KillProcess(string pricessName)
        {
            pricessName += ".exe";
            // explorer.exe
            //Process.Start("taskkill.exe", " /f /im explorer.exe");
            Process.Start("taskkill.exe", " /f /im " + pricessName);
        }
        public void CloseGame()
        {
            if (IsContainsProcess("Roadrash"))
            {
                KillProcess("Roadrash");
            }
            if (IsContainsProcess("explorer"))
            {
                // 如果已经打开了，什么都不用做
            }
            else
            {
                RunPro("C:\\windows\\explorer");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Process.Start("taskkill.exe", " /f /im explorer.exe");
        }
    }
}
