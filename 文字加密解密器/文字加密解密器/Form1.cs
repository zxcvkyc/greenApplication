using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文字加密解密器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = textBox1.Text;
            string res = "";
            for (int i = 0; i < msg.Length; i++)
            {
                res += (char)(msg[i] + Convert.ToInt32(textBox3.Text));
            }
            textBox2.Text = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string res = textBox2.Text;
            string msg = "";
            for (int i = 0; i < res.Length; i++)
            {
                msg += (char)(res[i] - Convert.ToInt32(textBox3.Text));
            }
            textBox1.Text = msg;
        }
    }
}
