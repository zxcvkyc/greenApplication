using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace 批量文件重命名
{
    internal class KingDeUtils {
        // 待处理列表
        public HashSet<string> deleteList = new HashSet<string>();
        /// <summary>
        /// 查询符合要求的文件列表
        /// </summary>
        /// <param name="path">工作目录</param>
        /// <param name="word">关键词</param>
        public void AddDeleteList(DirectoryInfo path, string word) {

            // 获取所有文件列表
            FileInfo[] files = path.GetFiles();
            foreach (var f in files) {
                if (f.Name.Contains(word)) {
                    deleteList.Add(f.FullName.ToString());
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">工作路径</param>
        /// <param name="word">关键词</param>
        /// <param name="flag">是否包含子目录</param>
        public void GetFile(string path, string word, bool flag) {
            try {
                AddDeleteList(new DirectoryInfo(path), word);
                string[] dirs = Directory.GetDirectories(path);
                if (flag) {
                    foreach (string dir in dirs) {
                        GetFile(dir, word,flag);
                    }
                }


            } catch {

            }

        }
        /// <summary>
        /// 替换
        /// </summary>
        /// <param name="word">原关键字</param>
        /// <param name="repword">新关键字</param>
        /// <param name="f">文件路径</param>
        /// <returns></returns>
        public string Replace(string word,string repword,FileInfo f) {
            // 重命名
            string filepath = f.FullName.Replace(f.Name, "");
            string rename = f.Name.Replace(word,repword);
            File.Move(f.FullName, filepath + "\\" + rename);
            return filepath + "\\" + rename;
        }
        public string Remove(string word, FileInfo f) {
            return Replace(word,"",f);
        }
    }
}
