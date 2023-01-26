using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一键去除电影天堂文件名水印
{
    class Program
    {
        // 要去除的内容
        static string word = "_(094910)www.wo21.top";
        // 要替换的内容
        static string res = "";
        static int fileCount = 0;
        static bool flag = false;
        static void Main(string[] args)
        {
            // 当前exe所在的目录
            DirectoryInfo root = new DirectoryInfo(Directory.GetCurrentDirectory());
            Console.WriteLine("请输入要删除的内容：");
            word = Console.ReadLine();
            Console.WriteLine("要把[" + word + "]替换成什么？如果想删除，请什么都不输入，按回车");
            res = Console.ReadLine();

            GetFile(Directory.GetCurrentDirectory());
            Console.WriteLine("操作完成，按任意键继续...");
            Console.WriteLine("重命名的文件个数: " + fileCount);
            Console.ReadKey();
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="path"></param>
        public static void Rename(DirectoryInfo path)
        {
            // 获取所有文件列表
            FileInfo[] files = path.GetFiles();
            foreach (var f in files)
            {
                if (f.Name.Contains(word))
                {
                    // 重命名
                    string rename = f.FullName.Replace(word, res);
                    Console.WriteLine(rename);
                    File.Move(f.FullName, rename);
                    fileCount++;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public static void GetFile(string path)
        {
            try
            {
                Rename(new DirectoryInfo(path));
                string[] dirs = Directory.GetDirectories(path);
                if (flag)
                {
                    foreach (string dir in dirs)
                    {
                        GetFile(dir);
                    }
                }
                

            }
            catch
            {

            }
            
        }
    }
}
