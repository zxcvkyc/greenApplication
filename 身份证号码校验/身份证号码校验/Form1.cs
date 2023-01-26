using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;

namespace 身份证号码校验
{
    public partial class Form1 : Form
    {
        public Dictionary<int, string> province = new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label2.Text = GetJiaoYanMa(txt_Id.Text);
        }
        private bool IsIdCard(string id)
        {
            string res = GetJiaoYanMa(id);
            //MessageBox.Show(res);// 程序测试代码
            if (res == "-1")
            {
                // 在控制台输出错误信息
                Console.WriteLine("身份证位数不合法");
                return false;
            }
            if (res == "-2")
            {
                // 在控制台输出错误信息
                Console.WriteLine("算出的校验码没有与之对应的值（程序内部错误）");
                return false;
            }
            // 如果算出的校验码等于 id的最后一位
            if (res == id[id.Length - 1].ToString())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 算出身份证最后一位的校验码
        /// </summary>
        /// <param name="id">要计算的18位身份证号码</param>
        /// <returns>身份证的最后一位 校验码</returns>
        private string GetJiaoYanMa(string id)
        {
            // 判断身份证位数是否合法
            if (id.Length != 18)
            {
                return "-1";
            }
            // 身份证每一位需要乘以的数
            int[] nums = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            int sum = 0;
            for (int i = 0; i < id.Length - 1; i++)
            {
                // 将身份证号码的前17位逐一乘以nums，并求和
                sum += int.Parse(id[i].ToString()) * nums[i];
            }
            // 对求和结果取余
            int step3 = sum % 11;
            switch (step3)
            {
                case 0:
                    return "1";
                case 1:
                    return "0";
                case 2:
                    return "X";
                case 3:
                    return "9";
                case 4:
                    return "8";
                case 5:
                    return "7";
                case 6:
                    return "6";
                case 7:
                    return "5";
                case 8:
                    return "4";
                case 9:
                    return "3";
                case 10:
                    return "2";
            }
            return "-2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 将省份数据添加进 province
            province.Add(44, "广东");
            province.Add(37, "山东");
            province.Add(32, "江苏");
            province.Add(41, "河南");
            province.Add(13, "河北");
            province.Add(33, "浙江");
            province.Add(61, "陕西");
            province.Add(43, "湖南");
            province.Add(35, "福建");
            province.Add(53, "云南");
            province.Add(51, "四川");
            province.Add(45, "广西");
            province.Add(34, "安徽");
            province.Add(46, "海南");
            province.Add(36, "江西");
            province.Add(42, "湖北");
            province.Add(14, "山西");
            province.Add(21, "辽宁");
            province.Add(23, "黑龙江");
            province.Add(15, "内蒙古");
            province.Add(52, "贵州");
            province.Add(62, "甘肃");
            province.Add(63, "青海");
            province.Add(65, "新疆");
            province.Add(54, "西藏");
            province.Add(22, "吉林");
            province.Add(64, "宁夏");
            province.Add(11, "北京");
            province.Add(12, "天津");
            province.Add(50, "重庆");
            province.Add(31, "上海");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = IsIdCard(txt_Id.Text).ToString();

        }
    }
}
