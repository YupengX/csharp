using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSQLDescription.Utils
{
    class FileUtils
    {
        ///<summary>
        ///读取txt文件里面的信息
        ///<param name="filepath">输入文件的路径</param>
        /// </summary>
        //读取文件信息
        public static string readFile(string filepath)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                FileStream file = new FileStream(filepath, FileMode.Open);
                StreamReader fileread = new StreamReader(file, Encoding.Default);
                sb.Append(fileread.ReadToEnd());
                fileread.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return sb.ToString();
        }
        ///<summary>
        ///重新写入文件信息
        ///</summary>
        public static void writeFile(string filepath, string content)
        {
            try
            {
                FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);//找到文件如果文件不存在则创建文件如果存在则覆盖文件
                //清空文件
                fs.SetLength(0);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                Random rd = new Random();
                sw.Write(content);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static FileInfo[] getAllFilesFromCurrentDir(string folderFullName)
        {
            DirectoryInfo TheFolder = new DirectoryInfo(folderFullName);
            return TheFolder.GetFiles();

        }
        public static List<FileInfo> getAllJSONFilesFromCurrentDir(string folderFullName)
        {
            DirectoryInfo TheFolder = new DirectoryInfo(folderFullName);
            List<FileInfo> fileList = TheFolder.GetFiles().ToList<FileInfo>();
            if (fileList != null && fileList.Count > 0)
            {
                for (int i = 0;i< fileList.Count;i++)
                {
                    if (!fileList[i].Name.EndsWith(".json"))
                    {
                        Console.WriteLine("移除："+ fileList[i].Name);
                        fileList.Remove(fileList[i]);
                    }
                }
            }
            return fileList;

        }

    }
}
