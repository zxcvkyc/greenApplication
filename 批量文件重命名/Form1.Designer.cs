namespace 批量文件重命名
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.file_listBox = new System.Windows.Forms.ListBox();
            this.lab_count = new System.Windows.Forms.Label();
            this.cb_flag = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_remove = new System.Windows.Forms.TabPage();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_remove = new System.Windows.Forms.TextBox();
            this.tab_replace = new System.Windows.Forms.TabPage();
            this.txt_rep2 = new System.Windows.Forms.TextBox();
            this.txt_rep1 = new System.Windows.Forms.TextBox();
            this.btn_replace = new System.Windows.Forms.Button();
            this.lab_path = new System.Windows.Forms.Label();
            this.btn_selectPath = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_remove.SuspendLayout();
            this.tab_replace.SuspendLayout();
            this.SuspendLayout();
            // 
            // file_listBox
            // 
            this.file_listBox.FormattingEnabled = true;
            this.file_listBox.ItemHeight = 12;
            this.file_listBox.Location = new System.Drawing.Point(12, 36);
            this.file_listBox.Name = "file_listBox";
            this.file_listBox.Size = new System.Drawing.Size(645, 388);
            this.file_listBox.TabIndex = 0;
            this.file_listBox.SelectedIndexChanged += new System.EventHandler(this.file_listBox_SelectedIndexChanged);
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_count.ForeColor = System.Drawing.Color.Blue;
            this.lab_count.Location = new System.Drawing.Point(106, 433);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(426, 31);
            this.lab_count.TabIndex = 1;
            this.lab_count.Text = "点击按钮后，以上00个文件将受到影响";
            // 
            // cb_flag
            // 
            this.cb_flag.AutoSize = true;
            this.cb_flag.Location = new System.Drawing.Point(790, 11);
            this.cb_flag.Name = "cb_flag";
            this.cb_flag.Size = new System.Drawing.Size(96, 16);
            this.cb_flag.TabIndex = 2;
            this.cb_flag.Text = "包含子文件夹";
            this.cb_flag.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_remove);
            this.tabControl1.Controls.Add(this.tab_replace);
            this.tabControl1.Location = new System.Drawing.Point(663, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 388);
            this.tabControl1.TabIndex = 6;
            // 
            // tab_remove
            // 
            this.tab_remove.Controls.Add(this.btn_delete);
            this.tab_remove.Controls.Add(this.label1);
            this.tab_remove.Controls.Add(this.txt_remove);
            this.tab_remove.Location = new System.Drawing.Point(4, 22);
            this.tab_remove.Name = "tab_remove";
            this.tab_remove.Padding = new System.Windows.Forms.Padding(3);
            this.tab_remove.Size = new System.Drawing.Size(346, 362);
            this.tab_remove.TabIndex = 0;
            this.tab_remove.Text = "去除";
            this.tab_remove.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(237, 171);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "去除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入要去除的内容，多个词请用回车换行隔开";
            // 
            // txt_remove
            // 
            this.txt_remove.Location = new System.Drawing.Point(36, 127);
            this.txt_remove.Name = "txt_remove";
            this.txt_remove.Size = new System.Drawing.Size(276, 21);
            this.txt_remove.TabIndex = 0;
            this.txt_remove.TextChanged += new System.EventHandler(this.txt_remove_TextChanged_1);
            // 
            // tab_replace
            // 
            this.tab_replace.Controls.Add(this.txt_rep2);
            this.tab_replace.Controls.Add(this.txt_rep1);
            this.tab_replace.Controls.Add(this.btn_replace);
            this.tab_replace.Location = new System.Drawing.Point(4, 22);
            this.tab_replace.Name = "tab_replace";
            this.tab_replace.Padding = new System.Windows.Forms.Padding(3);
            this.tab_replace.Size = new System.Drawing.Size(346, 362);
            this.tab_replace.TabIndex = 1;
            this.tab_replace.Text = "替换";
            this.tab_replace.UseVisualStyleBackColor = true;
            // 
            // txt_rep2
            // 
            this.txt_rep2.Location = new System.Drawing.Point(85, 145);
            this.txt_rep2.Name = "txt_rep2";
            this.txt_rep2.Size = new System.Drawing.Size(158, 21);
            this.txt_rep2.TabIndex = 2;
            // 
            // txt_rep1
            // 
            this.txt_rep1.Location = new System.Drawing.Point(85, 100);
            this.txt_rep1.Name = "txt_rep1";
            this.txt_rep1.Size = new System.Drawing.Size(158, 21);
            this.txt_rep1.TabIndex = 1;
            this.txt_rep1.TextChanged += new System.EventHandler(this.txt_rep1_TextChanged);
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(219, 204);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(75, 23);
            this.btn_replace.TabIndex = 0;
            this.btn_replace.Text = "替换";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // lab_path
            // 
            this.lab_path.AutoSize = true;
            this.lab_path.ForeColor = System.Drawing.Color.Blue;
            this.lab_path.Location = new System.Drawing.Point(12, 12);
            this.lab_path.Name = "lab_path";
            this.lab_path.Size = new System.Drawing.Size(77, 12);
            this.lab_path.TabIndex = 7;
            this.lab_path.Text = "当前工作目录";
            // 
            // btn_selectPath
            // 
            this.btn_selectPath.Location = new System.Drawing.Point(904, 7);
            this.btn_selectPath.Name = "btn_selectPath";
            this.btn_selectPath.Size = new System.Drawing.Size(113, 23);
            this.btn_selectPath.TabIndex = 8;
            this.btn_selectPath.Text = "切换工作目录";
            this.btn_selectPath.UseVisualStyleBackColor = true;
            this.btn_selectPath.Click += new System.EventHandler(this.btn_selectPath_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 483);
            this.Controls.Add(this.btn_selectPath);
            this.Controls.Add(this.lab_path);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cb_flag);
            this.Controls.Add(this.lab_count);
            this.Controls.Add(this.file_listBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量文件重命名";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_remove.ResumeLayout(false);
            this.tab_remove.PerformLayout();
            this.tab_replace.ResumeLayout(false);
            this.tab_replace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox file_listBox;
        private System.Windows.Forms.Label lab_count;
        private System.Windows.Forms.CheckBox cb_flag;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_remove;
        private System.Windows.Forms.TabPage tab_replace;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_remove;
        private System.Windows.Forms.Label lab_path;
        private System.Windows.Forms.Button btn_selectPath;
        private System.Windows.Forms.TextBox txt_rep2;
        private System.Windows.Forms.TextBox txt_rep1;
        private System.Windows.Forms.Button btn_replace;
    }
}

