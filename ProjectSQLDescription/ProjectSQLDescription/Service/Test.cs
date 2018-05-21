using ProjectSQLDescription.POJO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ProjectSQLDescription.Service
{
     class Test
    {
        public string generateJSON()
        {
            ProjectInfo p = new ProjectInfo("ZJXT", "质检系统", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "lili");
            SqlParamInfo sp = new SqlParamInfo("p1", "参数1");
            SqlParamInfo sp2 = new SqlParamInfo("p2", "参数2");
            SqlTableInfo st = new SqlTableInfo("t1", "表1");
            SqlTableInfo st2 = new SqlTableInfo("t2", "表2");
            List<SqlParamInfo> spl = new List<SqlParamInfo>();
            List<SqlTableInfo> stl = new List<SqlTableInfo>();
            List<SqlInfo> sql = new List<SqlInfo>();
            spl.Add(sp);
            spl.Add(sp2);
            stl.Add(st);
            stl.Add(st2);
            SqlInfo sl = new SqlInfo("sql1", "select * from user",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "lili");
            sl.SqlParamList = spl;
            sl.SqlTableList = stl;
            sql.Add(sl);
            p.SqlList = sql;
            Console.WriteLine("sql===="+p.SqlList[0].Sql);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize(p);
            Console.WriteLine(json);
            return json;
        }
        public void parseJSON2Object(string json)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            SqlInfo o = serializer.Deserialize<SqlInfo>(json);
            Console.WriteLine(o.Sql);
        }
        ///<summary>
        ///读取txt文件里面的信息
        ///<param name="filepath">输入文件的路径</param>
        /// </summary>
        //读取文件信息
        public string ReadFile(string filepath)
        {
            StringBuilder sb =new StringBuilder();
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
        public void writeFile(string filepath,string content)
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
        public  void forEachDir(string folderFullName)
        {
            DirectoryInfo TheFolder = new DirectoryInfo(folderFullName);
            //遍历文件夹
            foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
                Console.WriteLine("文件夹：\t\t"+NextFolder.Name);
            //遍历文件
            foreach (FileInfo NextFile in TheFolder.GetFiles())
                Console.WriteLine("文件：\t\t" + NextFile.Name);
        }
        public void forEachDir2(string folderFullName)
        {
            DirectoryInfo TheFolder = new DirectoryInfo(folderFullName);
        
            //遍历文件夹
            foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
            {
                Console.WriteLine("文件夹：\t\t" + NextFolder.Name);
                //遍历文件
                foreach (FileInfo NextFile in NextFolder.GetFiles())
                    Console.WriteLine("文件：\t\t" + NextFile.Name);
            }
            


        }
        static Dictionary<string,string> FileList = new Dictionary<string, string>();
        public static Dictionary<string, string> GetAllFiles(DirectoryInfo dir)
        {
            FileInfo[] allFile = dir.GetFiles();
            foreach (FileInfo fi in allFile)
            {
                FileList.Add(fi.Name,fi.FullName);
            }
            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                GetAllFiles(d);
            }
            return FileList;
        }

    }
}
