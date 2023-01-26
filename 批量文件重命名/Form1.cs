using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace 批量文件重命名
{
    public partial class Main_Form : Form
    {
        // 程序工作目录
        DirectoryInfo root = new DirectoryInfo(Directory.GetCurrentDirectory());
        // 初始化Utils
        KingDeUtils utils = null;
        
        public Main_Form(){
            InitializeComponent();
            // 初始化Utils
            utils = new KingDeUtils();
        }
        /// <summary>
        /// 移除按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string word = txt_remove.Text;
            foreach (var strFile in utils.deleteList) {
                utils.Remove(word, new FileInfo(strFile));
            }
            utils.deleteList = new HashSet<string>();
            ShowList(utils.deleteList);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            lab_path.Text = "当前工作目录：" + root;
        }

        private void btn_selectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            // 选择文件夹对话框
            if(DialogResult.OK == fbd.ShowDialog())
            {
                root = new DirectoryInfo(fbd.SelectedPath);
            }
            lab_path.Text = "当前工作目录：" + root;
        }

        /// <summary>
        /// 显示集合中的内容到listbox
        /// </summary>
        /// <param name="obj"></param>
        public void ShowList(HashSet<string> obj)
        {
            // 清空列表
            file_listBox.Items.Clear();
            foreach (var item in obj)
            {
                file_listBox.Items.Add(item);
            }
            //lab_count.Text = "点击按钮后，以上" + file_listBox.Items.Count + "个文件将受到影响";
            lab_count.Text = "点击按钮后，以上" + obj.Count + "个文件将受到影响";
        }

        private void file_listBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                // 吧listbox中选择的内容，反查到文本框
                string selectFileName = file_listBox.SelectedItem.ToString();
                txt_remove.Text = new FileInfo(selectFileName).Name;
                txt_rep1.Text = new FileInfo(selectFileName).Name;
            } catch { }
            
        }
        /// <summary>
        /// 替换模块，搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_rep1_TextChanged(object sender, EventArgs e) {
            file_listBox.Items.Clear();
            utils.deleteList.Clear();
            string input = txt_rep1.Text.Trim();
            utils.GetFile(root.ToString(), input, cb_flag.Checked == true);
            ShowList(utils.deleteList);
        }
        /// <summary>
        /// 移除模块，搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_remove_TextChanged_1(object sender, EventArgs e) {
            file_listBox.Items.Clear();
            utils.deleteList.Clear();
            string[] strings = txt_remove.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in strings) {
                utils.GetFile(root.ToString(), item, cb_flag.Checked == true);
            }
            ShowList(utils.deleteList);
        }
        /// <summary>
        /// 移除按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_replace_Click(object sender, EventArgs e) {
            string rep1 = txt_rep1.Text;
            string rep2 = txt_rep2.Text;
            foreach (var strFile in utils.deleteList) {
                utils.Replace(rep1,rep2, new FileInfo(strFile));
            }
            utils.deleteList = new HashSet<string>();
            ShowList(utils.deleteList);
        }
    }
}
